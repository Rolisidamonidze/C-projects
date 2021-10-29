
namespace Exam.Client {
  partial class LoginForm {
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
      this.btnEnter = new System.Windows.Forms.Button();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.lblUsername = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblLoginResult = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnEnter
      // 
      this.btnEnter.Location = new System.Drawing.Point(138, 132);
      this.btnEnter.Name = "btnEnter";
      this.btnEnter.Size = new System.Drawing.Size(75, 23);
      this.btnEnter.TabIndex = 0;
      this.btnEnter.Text = "შესვლა";
      this.btnEnter.UseVisualStyleBackColor = true;
      this.btnEnter.Click += new System.EventHandler(this.btnLogin);
      // 
      // txtUsername
      // 
      this.txtUsername.Location = new System.Drawing.Point(106, 32);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(185, 20);
      this.txtUsername.TabIndex = 1;
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(106, 67);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(185, 20);
      this.txtPassword.TabIndex = 1;
      // 
      // lblUsername
      // 
      this.lblUsername.AutoSize = true;
      this.lblUsername.Location = new System.Drawing.Point(45, 35);
      this.lblUsername.Name = "lblUsername";
      this.lblUsername.Size = new System.Drawing.Size(55, 13);
      this.lblUsername.TabIndex = 2;
      this.lblUsername.Text = "Username";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(45, 70);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Password";
      // 
      // lblAuthorizationResult
      // 
      this.lblLoginResult.AutoSize = true;
      this.lblLoginResult.ForeColor = System.Drawing.Color.Red;
      this.lblLoginResult.Location = new System.Drawing.Point(45, 98);
      this.lblLoginResult.Name = "lblAuthorizationResult";
      this.lblLoginResult.Size = new System.Drawing.Size(0, 13);
      this.lblLoginResult.TabIndex = 3;
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(353, 176);
      this.Controls.Add(this.lblLoginResult);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblUsername);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.txtUsername);
      this.Controls.Add(this.btnEnter);
      this.Name = "LoginForm";
      this.Text = "LoginForm";
      this.Load += new System.EventHandler(this.LoginForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnEnter;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblLoginResult;
  }
}