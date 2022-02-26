using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class Logger
    {
        private static List<string> currentSessionActivities = new List<string>();

        public static void LogActivity(string activity)
        {
            string activityLine = "************************************************\n" +
                DateTime.Now + "\n"
                + LoginValidation.CurrentUsername + "\n"
                + LoginValidation.CurrentUserRole + "\n"
                + activity + "\n************************************************\n";
            currentSessionActivities.Add(activityLine);

            File.AppendAllText("LogFile.txt", activityLine);
            File.Delete(Path.GetFullPath(@"..\..\..\LogFile.txt"));
            File.Copy("LogFile.txt", Path.GetFullPath(@"..\..\..\LogFile.txt"));
        }

        public static string GetCurrentSessionActivities()
        {
            StringBuilder sessionActivities = new StringBuilder();

            foreach (var currentSession in currentSessionActivities)
            {
                sessionActivities.Append(currentSession);
            }

            return sessionActivities.ToString();
        }
    }
}
