using System;
using System.Drawing;
using System.Windows.Forms;
using Exam.Data;

namespace Exam.Client {

  public partial class Exam : Form {
    private Button btnLogin;
    private Label lblUsername;
    private Label lblPassword;
    private Label lblWelcome;
    private TextBox txtBoxUsername;
    private TextBox txtBoxPassword;

    public Exam() {
      InitializeComponent();
      DisplayLogin();
      Data.FileManager.LoadUsers();
      UserDataManager userDataManager = new UserDataManager();
      var users = userDataManager.Get();
      foreach (var user in users) {
        lblUsername.Text = user.Username;
      }
    }

    private void Authorize() {
      UserDataManager userManager = new UserDataManager();
    }

    private void BtnLogin_Click(object sender, EventArgs e) {
    }

    private void DisplayWelcome() {
    }

    private void DisplayLogin() {
      btnLogin = new Button() {
        Name = "btnLogin",
        Text = "Login",
        Location = new Point(300, 200)
      };

      btnLogin.Click += BtnLogin_Click;

      lblUsername = new Label() {
        Name = "lblUsername",
        Text = "Username",
        Location = new Point(200, 100),
        TextAlign = ContentAlignment.MiddleRight,
      };

      lblPassword = new Label() {
        Name = "lblPassword",
        Text = "Password",
        Location = new Point(200, 150),
        TextAlign = ContentAlignment.MiddleRight,
      };

      txtBoxUsername = new TextBox() {
        Name = "txtBoxUsername",
        Location = new Point(300, 100),
      };

      txtBoxPassword = new TextBox() {
        Location = new Point(300, 150),
      };

      Controls.Add(btnLogin);
      Controls.Add(lblUsername);
      Controls.Add(lblPassword);
      Controls.Add(txtBoxUsername);
      Controls.Add(txtBoxPassword);
    }
  }
}