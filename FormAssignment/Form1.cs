using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormAssignment
{
    public partial class Form1 : Form
    {
        List<Student> one = new List<Student>();
        Student temp = new Student();
        public Form1()
        {
            InitializeComponent();
            grid_view.Visible = false;
            panel_main.Visible = false;
            panel_profile.Visible = false;
            search_pnl.Visible = false;
            name_searchP.Visible = false;
            dis_pnl.Visible = false;
            del_pan.Visible = false;
            btn_grid.Visible = false;
            at_panel.Visible = false;
            one.AddRange(ReadonLoad());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // wel_panel.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            panel_main.Visible = true;
        }

        private void stToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //wel_panel.Visible = false;
            btn_grid.Visible = false;
            grid_view.Visible = false;
            del_pan.Visible = false;
            panel_main.Visible = true;
            panel_profile.Visible = true;
            search_pnl.Visible = false;
            dis_pnl.Visible = false;
            at_panel.Visible = false;

            //panel_profile.Location = new Point(
            //this.ClientSize.Width / 2 - panel_profile.Size.Width / 2,
            //this.ClientSize.Height / 2 - panel_profile.Size.Height / 2);
            //panel_profile.Anchor = AnchorStyles.None;


        }




        List<Student> ReadonLoad()
        {
            List<Student> load = new List<Student>();
            Student temp = new Student();
            string fileName = @"C:\Users\Hamza_PC\source\repos\FormAssignment\Test.txt";
            using (StreamReader sr = new StreamReader(@"C:\Users\Hamza_PC\source\repos\FormAssignment\Test.txt"))
            {

                if (new FileInfo(fileName).Length == 0)
                {
                    Console.WriteLine("FILE IS EMPTY\n");

                }
                else
                {
                    while (!sr.EndOfStream)
                    {
                        temp = new Student();
                        temp.student_ID = sr.ReadLine();
                        temp.Student_Name = sr.ReadLine();
                        temp.s_GPA = sr.ReadLine();
                        temp.s_semester = sr.ReadLine();
                        temp.s_department = sr.ReadLine();
                        temp.s_university = sr.ReadLine();
                        temp.s_attendance = sr.ReadLine();
                        load.Add(temp);
                    }
                }
                return load;
            }
        }
        Student addProfile(Student temp)
        {
            temp = new Student();
            // Console.WriteLine("Enter Student unique ID");
            temp.student_ID = tb_id.Text;
            //Console.WriteLine("Enter Student name");
            temp.Student_Name = tb_name.Text;
            // Console.WriteLine("Enter Student GPA");
            temp.s_GPA = tb_gpa.Text;

            // Console.WriteLine("Enter Student current semester");
            temp.s_semester = tb_sem.Text;
            // Console.WriteLine("Enter Student Department");
            temp.s_department = tb_dept.Text;
            //  Console.WriteLine("Enter Student University");
            temp.s_university = tb_uni.Text;
            temp.s_attendance = "0";

            temp.WriteonFile();
            return temp;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            one.Add(addProfile(temp));
            MessageBox.Show("Student Added");

        }

        private void searchByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // wel_panel.Visible = false;
            //button2.Image = System.Drawing.Image.FromFile(@"C:\Users\Hamza_PC\Desktop\buttons_PNG165.png");
            btn_grid.Visible = false;
            grid_view.Visible = false;
            dis_pnl.Visible = false;
            at_panel.Visible = false;
            panel_main.Visible = true;
            panel_profile.Visible = false;
            search_pnl.Visible = true;
            //search_pnl.Location = new Point(
            // this.ClientSize.Width / 2 - search_pnl.Size.Width / 2,
            // this.ClientSize.Height / 2 - search_pnl.Size.Height / 2);
            //panel_profile.Anchor = AnchorStyles.None;


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Student temp = new Student();

            string id;
            id = textBox1.Text;
            List<Student> check = one.FindAll(x => x.student_ID.Equals(id));
            //MessageBox.Show();
            if (check.Count == 0)
            {
                MessageBox.Show("Not Found\n");
            }
            else
            {
                // MessageBox.Show("Student ID" + '\t' + "Student Name" + '\t' + "CGPA" + '\t' + '\t' + "Department" + '\t' + "Semester" + '\t' + "University\n");
                //foreach (Student item in check)
                //{
                //    temp = item.Display();

                //    MessageBox.Show(temp.student_ID + '\n' + temp.Student_Name + '\n' + temp.s_GPA + '\n' + temp.s_semester + '\n' + temp.s_department + '\n' + temp.s_university + '\n' + temp.s_attendance);
                //}
                search_grid.DataSource = check;

            }
        }

        private void searchByNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // wel_panel.Visible = false;
            panel_main.Visible = false;
            panel_profile.Visible = false;
            search_pnl.Visible = false;
            name_searchP.Visible = true;
        }

        private void name_search_Click(object sender, EventArgs e)
        {
            //foreach (Student item in N)
            //{
            //    temp = item.Display();
            //    MessageBox.Show(temp.student_ID + '\n' + temp.Student_Name + '\n' + temp.s_GPA + '\n' + temp.s_semester + '\n' + temp.s_department + '\n' + temp.s_university + '\n' + temp.s_attendance);
            //}



        }

        private bool Contains()
        {
            throw new NotImplementedException();
        }

        private void searchByNameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel_main.Visible = true;
            panel_profile.Visible = false;
            search_pnl.Visible = false;
            del_pan.Visible = false;
            name_searchP.Visible = true;
            //name_search.Location = new Point(
            //this.ClientSize.Width / 2 - name_search.Size.Width / 2,
            //this.ClientSize.Height / 2 - name_search.Size.Height / 2);
            //name_search.Anchor = AnchorStyles.None;

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_grid.Visible = false;
            grid_view.Visible = false;
            
            panel_main.Visible = true;
            panel_profile.Visible = false;
            search_pnl.Visible = false;
            name_searchP.Visible = false;
            dis_pnl.Visible = true;
            dataGridView1.Visible = true;
            del_pan.Visible = false;
            at_panel.Visible = false;

        }

        private void btn_list_Click(object sender, EventArgs e)
        {

            //foreach (Student items in one)
            //{
            //    lb_display.Items.AddRange(items.ToString());

            //}



        }

        private void deleteByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_grid.Visible = false;
            grid_view.Visible = false;

            panel_main.Visible = true;
            dis_pnl.Visible = false;
            at_panel.Visible = false;
            panel_profile.Visible = false;
            search_pnl.Visible = false;
            name_searchP.Visible = true;
            del_pan.Visible = true;

            //pictureBox1.Visible = true;

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void del_btn_Click(object sender, EventArgs e)
        {
            string id = "";
            id = tb_del.Text;

            List<Student> c = one.FindAll(x => x.student_ID.Equals(id));

            if (one.Count == 0)
            {
                MessageBox.Show("Not Found\n\n");
            }

            else
            {

                foreach (Student item in c)
                {
                    if (id == item.student_ID)
                    {

                        int deleteIndex = one.FindIndex(y => y.student_ID.Equals(id));
                        MessageBox.Show("Student Record removed");
                        one.RemoveAt(deleteIndex);

                    }

                }
                //List<Student> f = one.FindAll(x => x.student_ID.Equals(id));
                //  Student p2 = new Student();
                // List<Student> result = one.Where(p => !p.student_ID.Any(p2 => p2.student_ID == p.student_ID));
                //  List<Student> f = peopleList2.Where(p => !excludedIDs.Contains(p.ID))
                // List<Student> f= one.Where(p => c.All(p2 => p2.student_ID != p.student_ID));
                foreach (Student item in c)
                {
                    if (id != item.student_ID)
                    {
                        MessageBox.Show("Invalid");
                    }

                }


            }

            temp.UpdateFile(one);
        }

        private void top3StudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_grid.Visible = true;
            panel_main.Visible = true;
            panel_profile.Visible = false;
            search_pnl.Visible = false;
            del_pan.Visible = false;
            grid_view.Visible = true;



        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_display_Click(object sender, EventArgs e)
        {







        }
        List<Student> TopThree(List<Student> mainList)
        {
            mainList = mainList.OrderBy(o => o.s_GPA).ToList();
            return mainList;

        }//thisClass.displayGPA(one);

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_grid_Click(object sender, EventArgs e)
        {
            one = TopThree(one);
            bool isEmpty = !one.Any();
            if (one.Count < 3)
            {
                MessageBox.Show("File does not have needed entries");
            }
            else
            {
                //st2.Text = "Student ID" + '\n' + "Student Name" + '\n' + "CGPA" + '\n' + "Department" + '\n' + "Semester" + '\n' + "University";
                //st3.Text = "Student ID" + '\n' + "Student Name" + '\n' + "CGPA" + '\n' + "Department" + '\n' + "Semester" + '\n' + "University";

                for (int i = this.one.Count - 1; i > this.one.Count - 4; i--)
                {
                    var list = new BindingList<Student>(one);
                    list.Reverse();
                    grid_view.DataSource = list;
                    //temp = one[i].Display();
                    //id_tb1.Text = temp.student_ID;
                    //textBox3.Text = temp.Student_Name;
                    //gp_tb1.Text = temp.s_GPA;
                    //sem_tb1.Text = temp.s_semester;
                    //uni_tb1.Text = temp.s_university;
                    //att_tb1.Text = temp.s_attendance;

                    //MessageBox.Show("Student ID: "+temp.student_ID + '\n' +"Student Name: "+ temp.Student_Name + '\n' +"Student GPA: "+ temp.s_GPA + '\n' +"Semester: "+ temp.s_semester + '\n' +"Department: "+ temp.s_department + '\n' +"University: "+ temp.s_university + '\n' +"Attendance: "+ temp.s_attendance);

                }
            }
            temp.UpdateFile(one);
        }

        private void markAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 40;

            btn_grid.Visible = false;
            grid_view.Visible = false;

            panel_main.Visible = true;
            panel_profile.Visible = false;
            search_pnl.Visible = false;
            del_pan.Visible = false;
            dis_pnl.Visible = false;
            at_panel.Visible = true;

            foreach (Student item in one)
            {
                a = a + 25;
                Label label_one = new Label();
                Label label_two = new Label();
                CheckBox check_at = new CheckBox();

                //label_one.Dock = System.Windows.Forms.DockStyle.Fill;
                label_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label_one.Location = new System.Drawing.Point(23, a);
                label_one.Text = item.student_ID;

                //label_one.Dock = System.Windows.Forms.DockStyle.Fill;
                label_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label_two.Location = new System.Drawing.Point(120, a);
                label_two.Text = item.Student_Name;

                //label_one.Dock = System.Windows.Forms.DockStyle.Fill;
                check_at.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                check_at.Location = new System.Drawing.Point(250, a);
                check_at.Text = "Present";

                //Console.ReadLine();
                //this.Controls.Add(label_one);
                at_panel.Controls.Add(label_one);
                at_panel.Controls.Add(label_two);
                at_panel.Controls.Add(check_at);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> o = new List<string>();
            int a = 0;
            foreach (CheckBox item in at_panel.Controls.OfType<CheckBox>())
            {
                if (item.Checked == true)
                {
                    o.Add("1");
                }
                else if (item.Checked == false)
                {
                    o.Add("0");
                }
            }

            foreach (Student item in one)
            {
                item.s_attendance = o[a];
                a++;
            }

            temp.UpdateFile(one);

            //foreach (Student item in one)
            //{
            //    Console.WriteLine("ID = " + item.student_ID.ToString() + "\n");
            //    Console.WriteLine("Name = " + item.Student_Name + "\n");
            //    Console.WriteLine("Attendance = ");
            //    item.s_attendance = Convert.ToInt32(Console.ReadLine());
            //}
            //thisClass.updateFile(one);
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid_view.Visible = false;
            del_pan.Visible = false;
            dis_pnl.Visible = false;
            at_panel.Visible = true;
            panel_main.Visible = true;
            panel_profile.Visible = false;
            search_pnl.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //one.AddRange(ReadonLoad());

            var list1 = new BindingList<Student>(one);
            dataGridView1.DataSource = list1;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void del_pan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dis_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadExistingFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sName = "";
            sName = textBox2.Text;
            List<Student> N = one.FindAll(y => y.Student_Name.Equals(sName));


            if (N.Count == 0)
            {
                Console.WriteLine("Not Found\n");
            }
            else
            {

                search_grid.DataSource = N;
            }
        }
    }
}

        

    



