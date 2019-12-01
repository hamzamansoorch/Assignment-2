namespace FormAssignment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_main = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top3StudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.name_searchP = new System.Windows.Forms.Panel();
            this.searchName_grid = new System.Windows.Forms.DataGridView();
            this.name_search = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.name_tb1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.del_pan = new System.Windows.Forms.Panel();
            this.tb_del = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.del_btn = new System.Windows.Forms.Button();
            this.at_panel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dis_pnl = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_pnl = new System.Windows.Forms.Panel();
            this.search_grid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.id_search = new System.Windows.Forms.Label();
            this.panel_profile = new System.Windows.Forms.Panel();
            this.add_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_uni = new System.Windows.Forms.TextBox();
            this.tb_dept = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_sem = new System.Windows.Forms.TextBox();
            this.tb_gpa = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grid_view = new System.Windows.Forms.DataGridView();
            this.btn_grid = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.name_searchP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchName_grid)).BeginInit();
            this.del_pan.SuspendLayout();
            this.at_panel.SuspendLayout();
            this.dis_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.search_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_grid)).BeginInit();
            this.panel_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.menuStrip1);
            this.panel_main.Controls.Add(this.name_searchP);
            this.panel_main.Location = new System.Drawing.Point(12, 12);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(837, 25);
            this.panel_main.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stToolStripMenuItem,
            this.markAttendanceToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // stToolStripMenuItem
            // 
            this.stToolStripMenuItem.Name = "stToolStripMenuItem";
            this.stToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.stToolStripMenuItem.Text = "Student Profile";
            this.stToolStripMenuItem.Click += new System.EventHandler(this.stToolStripMenuItem_Click);
            // 
            // markAttendanceToolStripMenuItem
            // 
            this.markAttendanceToolStripMenuItem.Name = "markAttendanceToolStripMenuItem";
            this.markAttendanceToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.markAttendanceToolStripMenuItem.Text = "Mark Attendance";
            this.markAttendanceToolStripMenuItem.Click += new System.EventHandler(this.markAttendanceToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByIDToolStripMenuItem,
            this.listToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // searchByIDToolStripMenuItem
            // 
            this.searchByIDToolStripMenuItem.Name = "searchByIDToolStripMenuItem";
            this.searchByIDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchByIDToolStripMenuItem.Text = "Search by ID/Name";
            this.searchByIDToolStripMenuItem.Click += new System.EventHandler(this.searchByIDToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteByIDToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // deleteByIDToolStripMenuItem
            // 
            this.deleteByIDToolStripMenuItem.Name = "deleteByIDToolStripMenuItem";
            this.deleteByIDToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.deleteByIDToolStripMenuItem.Text = "Delete by ID";
            this.deleteByIDToolStripMenuItem.Click += new System.EventHandler(this.deleteByIDToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.top3StudentsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // top3StudentsToolStripMenuItem
            // 
            this.top3StudentsToolStripMenuItem.Name = "top3StudentsToolStripMenuItem";
            this.top3StudentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.top3StudentsToolStripMenuItem.Text = "Top 3 Students";
            this.top3StudentsToolStripMenuItem.Click += new System.EventHandler(this.top3StudentsToolStripMenuItem_Click);
            // 
            // name_searchP
            // 
            this.name_searchP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name_searchP.Controls.Add(this.searchName_grid);
            this.name_searchP.Controls.Add(this.name_search);
            this.name_searchP.Controls.Add(this.name_tb1);
            this.name_searchP.Controls.Add(this.label10);
            this.name_searchP.Location = new System.Drawing.Point(18, 31);
            this.name_searchP.Name = "name_searchP";
            this.name_searchP.Size = new System.Drawing.Size(819, 509);
            this.name_searchP.TabIndex = 3;
            // 
            // searchName_grid
            // 
            this.searchName_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchName_grid.Location = new System.Drawing.Point(23, 210);
            this.searchName_grid.Name = "searchName_grid";
            this.searchName_grid.Size = new System.Drawing.Size(773, 150);
            this.searchName_grid.TabIndex = 4;
            // 
            // name_search
            // 
            this.name_search.BackColor = System.Drawing.Color.Transparent;
            this.name_search.FlatAppearance.BorderSize = 0;
            this.name_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.name_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.name_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_search.ImageIndex = 1;
            this.name_search.ImageList = this.imageList1;
            this.name_search.Location = new System.Drawing.Point(488, 125);
            this.name_search.Name = "name_search";
            this.name_search.Size = new System.Drawing.Size(102, 54);
            this.name_search.TabIndex = 3;
            this.name_search.Text = "Search";
            this.name_search.UseVisualStyleBackColor = false;
            this.name_search.Click += new System.EventHandler(this.name_search_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "buttons_PNG165.png");
            this.imageList1.Images.SetKeyName(1, "button2.png");
            this.imageList1.Images.SetKeyName(2, "delete-button-pngrepo-com.png");
            // 
            // name_tb1
            // 
            this.name_tb1.Location = new System.Drawing.Point(410, 81);
            this.name_tb1.Name = "name_tb1";
            this.name_tb1.Size = new System.Drawing.Size(180, 20);
            this.name_tb1.TabIndex = 2;
            this.name_tb1.TextChanged += new System.EventHandler(this.name_tb1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(271, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Enter Name";
            // 
            // del_pan
            // 
            this.del_pan.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_pan.Controls.Add(this.tb_del);
            this.del_pan.Controls.Add(this.label11);
            this.del_pan.Controls.Add(this.del_btn);
            this.del_pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.del_pan.ForeColor = System.Drawing.SystemColors.Control;
            this.del_pan.Location = new System.Drawing.Point(0, 0);
            this.del_pan.Name = "del_pan";
            this.del_pan.Size = new System.Drawing.Size(879, 583);
            this.del_pan.TabIndex = 5;
            this.del_pan.Paint += new System.Windows.Forms.PaintEventHandler(this.del_pan_Paint);
            // 
            // tb_del
            // 
            this.tb_del.Location = new System.Drawing.Point(414, 165);
            this.tb_del.Name = "tb_del";
            this.tb_del.Size = new System.Drawing.Size(223, 20);
            this.tb_del.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(195, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "Enter ID to be deleted";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // del_btn
            // 
            this.del_btn.FlatAppearance.BorderSize = 0;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.del_btn.ImageIndex = 1;
            this.del_btn.ImageList = this.imageList1;
            this.del_btn.Location = new System.Drawing.Point(527, 210);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(110, 60);
            this.del_btn.TabIndex = 5;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // at_panel
            // 
            this.at_panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.at_panel.Controls.Add(this.button3);
            this.at_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.at_panel.ForeColor = System.Drawing.SystemColors.Control;
            this.at_panel.Location = new System.Drawing.Point(0, 0);
            this.at_panel.Name = "at_panel";
            this.at_panel.Size = new System.Drawing.Size(879, 583);
            this.at_panel.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ImageIndex = 1;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(731, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "Mark";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dis_pnl
            // 
            this.dis_pnl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dis_pnl.Controls.Add(this.button4);
            this.dis_pnl.Controls.Add(this.dataGridView1);
            this.dis_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dis_pnl.Location = new System.Drawing.Point(0, 0);
            this.dis_pnl.Name = "dis_pnl";
            this.dis_pnl.Size = new System.Drawing.Size(879, 583);
            this.dis_pnl.TabIndex = 4;
            this.dis_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.dis_pnl_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(407, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "List";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 310);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // search_pnl
            // 
            this.search_pnl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search_pnl.Controls.Add(this.button5);
            this.search_pnl.Controls.Add(this.textBox2);
            this.search_pnl.Controls.Add(this.label12);
            this.search_pnl.Controls.Add(this.search_grid);
            this.search_pnl.Controls.Add(this.button2);
            this.search_pnl.Controls.Add(this.textBox1);
            this.search_pnl.Controls.Add(this.id_search);
            this.search_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_pnl.Location = new System.Drawing.Point(0, 0);
            this.search_pnl.Name = "search_pnl";
            this.search_pnl.Size = new System.Drawing.Size(879, 583);
            this.search_pnl.TabIndex = 2;
            // 
            // search_grid
            // 
            this.search_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.search_grid.Location = new System.Drawing.Point(63, 241);
            this.search_grid.Name = "search_grid";
            this.search_grid.Size = new System.Drawing.Size(773, 150);
            this.search_grid.TabIndex = 3;
            this.search_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(263, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 48);
            this.button2.TabIndex = 2;
            this.button2.TabStop = false;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // id_search
            // 
            this.id_search.AutoSize = true;
            this.id_search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id_search.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_search.Location = new System.Drawing.Point(99, 111);
            this.id_search.Name = "id_search";
            this.id_search.Size = new System.Drawing.Size(74, 23);
            this.id_search.TabIndex = 0;
            this.id_search.Text = "Enter ID";
            // 
            // panel_profile
            // 
            this.panel_profile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_profile.Controls.Add(this.add_btn);
            this.panel_profile.Controls.Add(this.label9);
            this.panel_profile.Controls.Add(this.label8);
            this.panel_profile.Controls.Add(this.label7);
            this.panel_profile.Controls.Add(this.label6);
            this.panel_profile.Controls.Add(this.label5);
            this.panel_profile.Controls.Add(this.label4);
            this.panel_profile.Controls.Add(this.label3);
            this.panel_profile.Controls.Add(this.tb_uni);
            this.panel_profile.Controls.Add(this.tb_dept);
            this.panel_profile.Controls.Add(this.tb_name);
            this.panel_profile.Controls.Add(this.tb_sem);
            this.panel_profile.Controls.Add(this.tb_gpa);
            this.panel_profile.Controls.Add(this.tb_id);
            this.panel_profile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_profile.Location = new System.Drawing.Point(0, 0);
            this.panel_profile.Name = "panel_profile";
            this.panel_profile.Size = new System.Drawing.Size(879, 583);
            this.panel_profile.TabIndex = 1;
            // 
            // add_btn
            // 
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.ImageIndex = 1;
            this.add_btn.ImageList = this.imageList1;
            this.add_btn.Location = new System.Drawing.Point(399, 422);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(96, 47);
            this.add_btn.TabIndex = 13;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(247, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "University";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(247, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(247, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "CGPA";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(247, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(247, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(247, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(354, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Entries";
            // 
            // tb_uni
            // 
            this.tb_uni.Location = new System.Drawing.Point(350, 383);
            this.tb_uni.Name = "tb_uni";
            this.tb_uni.Size = new System.Drawing.Size(224, 20);
            this.tb_uni.TabIndex = 5;
            // 
            // tb_dept
            // 
            this.tb_dept.Location = new System.Drawing.Point(350, 337);
            this.tb_dept.Name = "tb_dept";
            this.tb_dept.Size = new System.Drawing.Size(224, 20);
            this.tb_dept.TabIndex = 4;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(350, 188);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(224, 20);
            this.tb_name.TabIndex = 3;
            // 
            // tb_sem
            // 
            this.tb_sem.Location = new System.Drawing.Point(350, 241);
            this.tb_sem.Name = "tb_sem";
            this.tb_sem.Size = new System.Drawing.Size(224, 20);
            this.tb_sem.TabIndex = 2;
            // 
            // tb_gpa
            // 
            this.tb_gpa.Location = new System.Drawing.Point(350, 289);
            this.tb_gpa.Name = "tb_gpa";
            this.tb_gpa.Size = new System.Drawing.Size(224, 20);
            this.tb_gpa.TabIndex = 1;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(350, 136);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(224, 20);
            this.tb_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click Enter to Continue";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(371, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grid_view
            // 
            this.grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view.Location = new System.Drawing.Point(73, 315);
            this.grid_view.Name = "grid_view";
            this.grid_view.Size = new System.Drawing.Size(721, 144);
            this.grid_view.TabIndex = 5;
            // 
            // btn_grid
            // 
            this.btn_grid.FlatAppearance.BorderSize = 0;
            this.btn_grid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grid.ImageIndex = 1;
            this.btn_grid.ImageList = this.imageList1;
            this.btn_grid.Location = new System.Drawing.Point(719, 500);
            this.btn_grid.Name = "btn_grid";
            this.btn_grid.Size = new System.Drawing.Size(87, 42);
            this.btn_grid.TabIndex = 6;
            this.btn_grid.Text = "Display";
            this.btn_grid.UseVisualStyleBackColor = true;
            this.btn_grid.Click += new System.EventHandler(this.btn_grid_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ImageIndex = 1;
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(690, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 48);
            this.button5.TabIndex = 6;
            this.button5.TabStop = false;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(626, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(501, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Enter Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 583);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.btn_grid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_profile);
            this.Controls.Add(this.at_panel);
            this.Controls.Add(this.del_pan);
            this.Controls.Add(this.dis_pnl);
            this.Controls.Add(this.search_pnl);
            this.Controls.Add(this.grid_view);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.name_searchP.ResumeLayout(false);
            this.name_searchP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchName_grid)).EndInit();
            this.del_pan.ResumeLayout(false);
            this.del_pan.PerformLayout();
            this.at_panel.ResumeLayout(false);
            this.dis_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.search_pnl.ResumeLayout(false);
            this.search_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_grid)).EndInit();
            this.panel_profile.ResumeLayout(false);
            this.panel_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteByIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top3StudentsToolStripMenuItem;
        private System.Windows.Forms.Panel panel_profile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_uni;
        private System.Windows.Forms.TextBox tb_dept;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_sem;
        private System.Windows.Forms.TextBox tb_gpa;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel search_pnl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label id_search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel name_searchP;
        private System.Windows.Forms.Button name_search;
        private System.Windows.Forms.TextBox name_tb1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel dis_pnl;
        private System.Windows.Forms.Panel del_pan;
        private System.Windows.Forms.TextBox tb_del;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.DataGridView grid_view;
        private System.Windows.Forms.Button btn_grid;
        private System.Windows.Forms.Panel at_panel;
        private System.Windows.Forms.ToolStripMenuItem markAttendanceToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView search_grid;
        private System.Windows.Forms.DataGridView searchName_grid;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
    }
}

