
namespace Exam.Client {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.btnOpenEnterForm = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnOpenEnterForm
      // 
      this.btnOpenEnterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnOpenEnterForm.Location = new System.Drawing.Point(312, 215);
      this.btnOpenEnterForm.Name = "btnOpenEnterForm";
      this.btnOpenEnterForm.Size = new System.Drawing.Size(174, 61);
      this.btnOpenEnterForm.TabIndex = 0;
      this.btnOpenEnterForm.Text = "შესვლა";
      this.btnOpenEnterForm.UseVisualStyleBackColor = true;
      this.btnOpenEnterForm.Click += new System.EventHandler(this.btnOpenEnterForm_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(160, 143);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(475, 26);
      this.label1.TabIndex = 1;
      this.label1.Text = "ტესტის დასაწერად გაიარეთ ავტორიზაცია";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnOpenEnterForm);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOpenEnterForm;
    private System.Windows.Forms.Label label1;
  }
}

