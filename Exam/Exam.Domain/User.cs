using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exam.Domain {

  public class User : IIdentity<int> {
    public int ID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }

    public override bool Equals(object obj) {
      return this.GetHashCode().Equals(obj.GetHashCode());
    }

    public override int GetHashCode() {
      return 1234 + ID.GetHashCode();
    }
  }
}