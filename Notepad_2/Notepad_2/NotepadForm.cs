using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;

namespace Notepad_2 {

   public partial class NotepadForm : Form {

      #region PrivateField

      private FontFamily[] _fontsInstalled = new InstalledFontCollection().Families;
      private readonly Stack<string> _history = new Stack<string>();
      private Font _currentFont;
      private FontFamily _currentFontFamily;
      private uint _FontSize = 16;
      private string _fileLocation;
      private string _lastSavedVersion;

      #endregion PrivateField

      #region Constructor

      public NotepadForm() {
         InitializeComponent();
         AddFonts();
         Reset();
      }

      #endregion Constructor

      #region Operations

      #region NewFile

      private void newFile_Click(object sender, EventArgs e) {
         NewFile();
      }

      private void newFileFromMenu_Click(object sender, EventArgs e) {
         NewFile();
      }

      private void NewFile() {
         var result = WantToSave();
         if (result == DialogResult.Yes) {
            Save();
            Reset();
         }
         else if (result == DialogResult.No) {
            Reset();
         }
      }

      #endregion NewFile

      #region Open

      private void Open() {
         OpenFileDialog open = new OpenFileDialog();
         if (open.ShowDialog() == DialogResult.OK) {
            ReadFile(Path.GetFullPath(open.FileName));
            DisplayFileName();
         }
      }

      private void open_Click(object sender, EventArgs e) {
         Open();
      }

      private void openFromMenu_Click(object sender, EventArgs e) {
         Open();
      }

      #endregion Open

      #region Save

      private void save_Click(object sender, EventArgs e) {
         Save();
      }

      private void saveFromMenu_Click(object sender, EventArgs e) {
         Save();
      }

      private void saveAsFromMenu_Click(object sender, EventArgs e) {
         SaveAs();
      }

      private void Save() {
         if (!FileHasLocation()) {
            SaveAs();
         }
         else if (TextHasChanged()) {
            WriteFile();
            _lastSavedVersion = _textBox.Text;
            DisplayFileName();
         }
      }

      private void SaveAs() {
         ChooseFileLocation();
         if (FileHasLocation()) {
            WriteFile();
            _lastSavedVersion = _textBox.Text;
            DisplayFileName();
         }
      }

      private void DisplayFileName() {
         if (!FileHasLocation()) {
            this.Text = $"Notepad - Untitled";
         }
         else {
            this.Text = $"Notepad - {Path.GetFileName(_fileLocation)}";
         }
      }

      private void ChooseFileLocation() {
         SaveFileDialog save = new SaveFileDialog();
         if (save.ShowDialog() == DialogResult.OK) {
            _fileLocation = Path.GetFullPath(save.FileName);
         }
      }

      #endregion Save

      #region Copy

      private void copy_Click(object sender, EventArgs e) {
         Copy();
      }

      private void copyFromMenu_Click(object sender, EventArgs e) {
         Copy();
      }

      private void Copy() {
         if (TextIsSelected()) {
            Clipboard.SetText(_textBox.SelectedText);
         }
      }

      #endregion Copy

      #region Cut

      private void cut_Click(object sender, EventArgs e) {
         Cut();
      }

      private void cutFromMenu_Click(object sender, EventArgs e) {
         Cut();
      }

      private void Cut() {
         if (TextIsSelected()) {
            var saveSelectionStart = _textBox.SelectionStart;
            Clipboard.SetText(_textBox.SelectedText);
            _textBox.Text = _textBox.Text.Remove(_textBox.SelectionStart, _textBox.SelectedText.Length);
            _textBox.SelectionStart = saveSelectionStart;
         }
      }

      #endregion Cut

      #region Paste

      private void Paste() {
         int saveSelectionStart = _textBox.SelectionStart;
         if (TextIsSelected()) {
            _textBox.Text = _textBox.Text.Remove(_textBox.SelectionStart, _textBox.SelectionLength);
         }
         _textBox.Text = _textBox.Text.Insert(saveSelectionStart, Clipboard.GetText());
         _textBox.SelectionStart = saveSelectionStart + Clipboard.GetText().Length;
      }

      private void paste_Click(object sender, EventArgs e) {
         Paste();
      }

      private void pasteFromMenu_Click(object sender, EventArgs e) {
         Paste();
      }

      #endregion Paste

      #region Undo

      private void undoFromMenu_Click(object sender, EventArgs e) {
         Undo();
      }

      private void Undo() {
         if (_history.Count > 1) {
            _history.Pop();
            _textBox.Text = _history.Peek();
         }
      }

      #endregion Undo

      #region SelectAll

      private void selectAllFromMenu_Click(object sender, EventArgs e) {
         _textBox.SelectAll();
      }

      #endregion SelectAll

      #endregion Operations

      #region Fonts

      private void AddFonts() {
         for (int i = 0; i < _fontsInstalled.Length; i++) {
            fontsList.DropDownItems.Add(_fontsInstalled[i].Name);
            fontsList.DropDownItems[i].Click += (s, e) => {
               _currentFont = new Font(((ToolStripMenuItem)s).Text, _FontSize);
               _textBox.Font = _currentFont;
            };
         }
         _currentFontFamily = _fontsInstalled[0];
         _currentFont = new Font(_currentFontFamily, _FontSize);
         _textBox.Font = _currentFont;
      }

      private void sizeIncrease_Click(object sender, EventArgs e) {
         _currentFont = new Font(_currentFont.FontFamily, _FontSize++);
         _textBox.Font = _currentFont;
      }

      private void sizeDecrease_Click(object sender, EventArgs e) {
         _currentFont = new Font(_currentFont.FontFamily, _FontSize--);
         _textBox.Font = _currentFont;
      }

      #endregion Fonts

      #region Form

      private void NotepadForm_FormClosing(object sender, FormClosingEventArgs e) {
         switch (WantToSave()) {
            case DialogResult.Yes:
               Save();
               if (!FileHasLocation()) {
                  e.Cancel = true;
               }
               break;

            case DialogResult.Cancel:
               e.Cancel = true;
               break;
         }
      }

      private void _textBox_KeyPress(object sender, KeyPressEventArgs e) {
         _history.Push(_textBox.Text);
      }

      #endregion Form

      #region Dialog

      private DialogResult WantToSave() {
         return MessageBox.Show("Do you want to save?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
      }

      #endregion Dialog

      #region FileStream

      private void WriteFile() {
         using (StreamWriter writer = new StreamWriter(new FileStream(_fileLocation, FileMode.Create))) {
            writer.Write(_textBox.Text);
         }
      }

      private void ReadFile(string path) {
         using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open))) {
            _textBox.Text = reader.ReadToEnd();
         }
      }

      #endregion FileStream

      #region HelperFunctions

      private bool FileHasLocation() => _fileLocation != "";

      private bool TextHasChanged() => _lastSavedVersion != _textBox.Text;

      private bool TextIsSelected() => _textBox.SelectionLength > 0;

      private void Reset() {
         _fileLocation = "";
         _lastSavedVersion = "";
         _textBox.Text = "";
         DisplayFileName();
      }

      #endregion HelperFunctions
   }
}