using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class StudentData
    {
        private static List<Student> _testStudents;
        public static List<Student> TestStudents
        {
            get
            {
                Reset_test_student_data();
                return _testStudents;
            }
            set { }
        }
        private static void Reset_test_student_data()
        {
            if (_testStudents == null)
            {
                _testStudents = new List<Student>();
                _testStudents.Add(new Student());
                _testStudents[0].first_name = "Koleda";
                _testStudents[0].second_name = "hah";
                _testStudents[0].last_name = "new";
                _testStudents[0].faculty = "FKST";
                _testStudents[0].speciality = "KSI";
                _testStudents[0].degree = "bachelor";
                _testStudents[0].status = (int)Student_status.GRADUATED;
                _testStudents[0].faculty_num = "121218027";
                _testStudents[0].course = 3;
                _testStudents[0].flow = 1;
                _testStudents[0].group = 49;

            }
        }
    }
}
