using DataLibrary.DBAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class UsersDB
    {
        public static void CreateUser(int age, string name, string surname, string email, string password)
        {
            UsersModel user = new UsersModel
            {
                Age = age,
                Name = name,
                Surname = surname,
                Email = email,
                Password = password
            };

            string sql = @"INSERT INTO dbo.Users (age, name, surname, email, password)
                          VALUES(@Age, @Name, @Surname, @Email, @Password)";

            SqlWorkflow.SaveData(sql, user);
        }

        public static List<UsersModel> LoadUsers()
        {
            string sql = @"SELECT * FROM dbo.Users";
            return SqlWorkflow.LoadData<UsersModel>(sql);
        }
    }
}
