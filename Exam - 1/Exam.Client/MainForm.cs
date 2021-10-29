using System;
using System.Windows.Forms;
using Exam.Domain;

namespace Exam.Client {

  public partial class MainForm : Form {

    public MainForm() {
      InitializeComponent();
    }

    private void btnOpenEnterForm_Click(object sender, EventArgs e) {
      LoginForm loginForm = new LoginForm();
      //Enabled = false;
      loginForm.Show(this);
    }
  }
}