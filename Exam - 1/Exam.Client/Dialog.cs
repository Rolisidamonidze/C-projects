using System;
using System.Windows.Forms;

namespace Exam.Client {

  public static class Dialog {

    public static DialogResult ExitDialog() {
      return MessageBox.Show("გსურთ გამოსვლა?", "დადასტურება", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    }
  }
}