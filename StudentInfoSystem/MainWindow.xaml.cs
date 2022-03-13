using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Student _Teststud;
        public Student Teststud
        {
            get
            {
                return _Teststud;
            }
            set
            {
                student_validity_check(value);
            }
        }
        private void student_validity_check(Student st)
        {
            if (st == null)
            {
                clear_controls();
                deactivate_all_control();
            }
            else
            {
                activate_all_control();
                fill_with_student(st);
                _Teststud = st;
            }
        }
        public void clear_controls()
        {
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }
        public void fill_with_student(Student st)
        {
            name_txtbox.Text = st.first_name;
            sec_name_txtbox.Text = st.second_name;
            last_name_txtbox.Text = st.last_name;
            faculty_txtbox.Text = st.faculty;
            spec_txtbox.Text = st.speciality;
            degree_txtbox.Text = st.degree;
            status_txtbox.Text = ((Student_status)st.status).ToString();
            fac_num_txtbox.Text = st.faculty_num;
            course_txtbox.Text = st.course.ToString();
            flow_txtbox.Text = st.flow.ToString();
            group_txtbox.Text = st.group.ToString();
        }
        public void deactivate_all_control()
        {
            //MainGrid.IsEnabled = false;
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = false;
                }
            }
        }
        public void activate_all_control()
        {
            //MainGrid.IsEnabled = true;
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;
                }
            }
        }

        private void clear_all_butt_Click(object sender, RoutedEventArgs e)
        {
            clear_controls();
        }

        private void send_student_butt_Click(object sender, RoutedEventArgs e)
        {
            Student st = new Student();
            st.first_name = "new";
            st.second_name = "second";
            st.last_name = "latest";
            st.faculty = "FKST";
            st.speciality = "KSI";
            st.degree = "bache";
            st.status = (int)Student_status.GRADUATED;
            st.faculty_num = "121218027";
            st.course = 3;
            st.flow = 3;
            st.group = 49;
            //fill_with_student(st);
            Teststud = st;
        }

        private void deactivate_butt_Click(object sender, RoutedEventArgs e)
        {
            deactivate_all_control();
        }

        private void activate_butt_Click(object sender, RoutedEventArgs e)
        {
            activate_all_control();
        }

        private void _TestStud_butt_Click(object sender, RoutedEventArgs e)
        {
            Student st = null;
            Teststud = st;
        }
    }
}
