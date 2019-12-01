using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAssignment
{
    public partial class AttendanceMark : Form
    {
        List<Student> one = new List<Student>();
        Student temp = new Student();
        public AttendanceMark()
        {
            InitializeComponent();
           // one.AddRange(ReadonLoad());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mark_btn_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (Student item in one)
            {
                s = mark_att.Text;
            }
            temp.UpdateFile(one);
           
        }
    }
}
