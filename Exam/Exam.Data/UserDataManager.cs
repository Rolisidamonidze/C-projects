using Exam.Domain;

namespace Exam.Data {

  public class UserDataManager : DataManager<int, User> {

    public UserDataManager() : base(FileManager.Users) {
    }
  }
}