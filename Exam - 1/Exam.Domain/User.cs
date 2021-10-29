using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain {

  public class User {
    public int ID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public Test Test { get; set; }
  }
}