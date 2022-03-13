using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class UserData
    {
        private static List<User> testUsers;

        public static List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return testUsers;
            }
            set { }
        }

        static public void ResetTestUserData()
        {
            testUsers = new List<User>();

            testUsers.Add(new User()
            {
                Username = "admin",
                Password = "admin",
                UserRole = UserRoles.ADMIN,
                FacultyNumber = "111111111",
                DateOfCreation = DateTime.Now,
                DateActiveTo = DateTime.MaxValue
            });

            testUsers.Add(new User()
            {
                Username = "student1",
                Password = "student",
                UserRole = UserRoles.STUDENT,
                FacultyNumber = "123456789",
                DateOfCreation = DateTime.Now,
                DateActiveTo = DateTime.MaxValue
            });

            testUsers.Add(new User()
            {
                Username = "student2",
                Password = "student",
                UserRole = UserRoles.STUDENT,
                FacultyNumber = "123456790",
                DateOfCreation = DateTime.Now,
                DateActiveTo = DateTime.MaxValue
            });
        }

        public static User IsUserPassCorrect(string username, string password)
        {
            return TestUsers.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
        }

        public static void SetUserActiveTo(string username, DateTime dateActiveTo)
        {
            foreach (var user in TestUsers)
            {
                if (user.Username == username)
                {
                    user.DateActiveTo = dateActiveTo;
                    Console.Write("Датата променена на " + dateActiveTo.ToShortDateString());
                    Logger.LogActivity("Промяна на активност на " + username);
                }
            }
        }

        public static void AssignUserRole(string username, UserRoles userRole)
        {
            foreach (var user in TestUsers)
            {
                if (user.Username == username)
                {
                    user.UserRole = userRole;
                    Console.Write("Ролята променена на " + userRole);
                    Logger.LogActivity("Промяна на роля на " + username);
                }
            }
        }
    }
}
