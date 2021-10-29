using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using Exam.Domain;
using System.Configuration;
using System.Data.Common;

namespace Exam.Data {

  public static class FileManager {
    private static string provider => ConfigurationManager.AppSettings["provider"];
    private static string connectionString => ConfigurationManager.AppSettings["connectionString"];
    private static DbProviderFactory factory => DbProviderFactories.GetFactory(provider);

    public static IList<User> Users { get; set; }
    public static IList<Test> Exams { get; set; }

    static FileManager() {
      Users = new List<User>();
      Exams = new List<Test>();
    }

    public static void SaveData() {
      SaveUsers();
      SaveExams();
    }

    public static void LoadData() {
      LoadUsers();
      LoadExams();
    }

    public static void SaveUsers() {
    }

    public static void LoadUsers() {
      //using (var connection = factory.CreateConnection()) {
      //  connection.ConnectionString = connectionString;
      //  connection.Open();
      //  var command = factory.CreateCommand();
      //  command.Connection = connection;
      //  command.CommandText = "Select * From Users";
      //  using (DbDataReader reader = command.ExecuteReader()) {
      //    while (reader.Read()) {
      //      Users.Add(new User() {
      //        ID = (int)reader["Id"],
      //        Username = (string)reader["Username"],
      //        Password = (string)reader["Password"],
      //        IsAdmin = (bool)reader["IsAdmin"]
      //      });
      //    }
      //  }
      //}
    }

    public static void SaveExams() {
    }

    public static void LoadExams() {
    }
  }
}