using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FormAssignment
{
    class Student
    {
        private string studentID;
        private string StudentName;
        private string Semester;
        private string CGPA;
        private string Department;
        private string University;
        private string Attendance;
       

        public Student()
        {

        }

        public string student_ID
        {
            get { return studentID; }

            set { studentID = value; }
        }

        public string Student_Name
        {
            get { return StudentName; }

            set
            {
                StudentName = value;
            }
        }
        public string s_semester
        {
            get { return Semester; }

            set { Semester = value; }
        }
        public string s_GPA
        {
            get { return CGPA; }

            set { CGPA = value; }
        }
        public string s_department
        {
            get { return Department; }

            set { Department = value; }
        }
        public string s_university
        {
            get { return University; }

            set { University = value; }
        }
        public string s_attendance
        {
            get { return Attendance; }
            set { Attendance = value; }
        }

        public Student Display()
        {
            Student temp = new Student();
            temp.studentID = student_ID;
            temp.StudentName = Student_Name;
            temp.CGPA = s_GPA;
            temp.Semester = s_semester;
            temp.Department = s_department;
            temp.University = s_university;
            temp.Attendance = s_attendance;
            return temp;
        }
        public void UpdateFile(List<Student> mainList)
        {
            File.WriteAllText(@"C:\Users\Hamza_PC\source\repos\FormAssignment\Test.txt", String.Empty);
            foreach (Student item in mainList)
            {
                item.WriteonFile();
            }
        }
        public void Att_Display()
        {
            string atten;
            if (Attendance == "0")
            {
                atten = "Absent";
            }
            else
            {
                atten = "Present";
            }
            Console.WriteLine(student_ID.ToString() + '\n' + StudentName + '\n' + atten);
        }

        public void WriteonFile()
        {
            using (StreamWriter sw = File.AppendText(@"C:\Users\Hamza_PC\source\repos\FormAssignment\Test.txt"))
            {
                sw.WriteLine(student_ID);
                sw.WriteLine(StudentName);
                sw.WriteLine(CGPA);
                sw.WriteLine(Semester);
                sw.WriteLine(Department);
                sw.WriteLine(University);
                sw.WriteLine(Attendance);
            }
        }
    }
}


