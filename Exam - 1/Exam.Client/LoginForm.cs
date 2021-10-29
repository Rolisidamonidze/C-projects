using System.Windows.Forms;
using Exam.Domain;
using Exam.Core;

namespace Exam.Client {

  public partial class LoginForm : Form {
    private Process process = new Process();
    public bool LoginSuccess;

    public LoginForm() {
      InitializeComponent();
    }

    private void btnLogin(object sender, System.EventArgs e) {
      LoginSuccess = process.Authorize(txtUsername.Text, txtPassword.Text);
      if (LoginSuccess) {
        ExamForm examForm = new ExamForm();
        examForm.Show(this);
        //this.Owner.Enabled = false;
        //this.Close();
      }
      else {
        lblLoginResult.Text = "მომხმარებლის სახელი ან პაროლი არასწორია";
      }
    }

    private void LoginForm_Load(object sender, System.EventArgs e) {
    }
  }
}