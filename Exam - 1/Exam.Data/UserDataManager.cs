using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Domain;
namespace Exam.Data {

   public class UserDataManager {
      public User LoadUser() {
         User user = new User() { Username = "admin", Password = "admin", ID = 123 };
         return user;
      }
   }
}