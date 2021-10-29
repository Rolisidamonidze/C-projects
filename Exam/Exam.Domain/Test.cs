using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain {

  public class Test : IIdentity<int> {
    public int ID { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
    public ICollection<Question> Questions { get; set; }

    public override bool Equals(object obj) {
      return GetHashCode().Equals(obj.GetHashCode());
    }

    public override int GetHashCode() {
      return 1234 + ID.GetHashCode();
    }
  }
}