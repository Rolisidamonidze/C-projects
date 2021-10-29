using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain {

  public interface IIdentity<T> {
    T ID { get; }
  }
}