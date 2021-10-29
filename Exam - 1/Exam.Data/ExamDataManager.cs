using Exam.Domain;

namespace Exam.Data {

  public class ExamDataManager {
    public Test LoadTest() {
      Answer a1 = new Answer() { Text = "ჟან პოლ სარტრი" };
      Answer a2 = new Answer() { Text = "ალბერტ კამიუ" };
      Answer a3 = new Answer() { Text = "ვიქტორ ჰიუგო" };
      Answer a4 = new Answer() { Text = "ჟიულ ვერნი" };
      Answer a5 = new Answer() { Text = "ჰერმან ჰესე" };

      Question q1 = new Question() {
        Text = "ვინ არის \"უცხოს\" ავტორი ?",
        Answers = new Answer[] { a1, a2, a3, a4 },
        Correct = a2,
      };
      Question q2 = new Question() {
        Text = "ვინ არის \"ტრამალის მგელის\" ავტორი?",
        Answers = new Answer[] { a1, a3, a4, a5 },
        Correct = a5,
      };

      Test test = new Test() { Questions = new Question[] { q1, q2 } };

      return test;
    }
  }
}