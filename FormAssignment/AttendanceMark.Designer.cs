namespace FormAssignment
{
    partial class AttendanceMark
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
            this.label1 = new System.Windows.Forms.Label();
            this.mark_att = new System.Windows.Forms.TextBox();
            this.mark_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter 0 to absent and 1 to Present";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mark_att
            // 
            this.mark_att.Location = new System.Drawing.Point(131, 74);
            this.mark_att.Name = "mark_att";
            this.mark_att.Size = new System.Drawing.Size(100, 20);
            this.mark_att.TabIndex = 1;
            // 
            // mark_btn
            // 
            this.mark_btn.Location = new System.Drawing.Point(142, 113);
            this.mark_btn.Name = "mark_btn";
            this.mark_btn.Size = new System.Drawing.Size(75, 23);
            this.mark_btn.TabIndex = 2;
            this.mark_btn.Text = "Mark";
            this.mark_btn.UseVisualStyleBackColor = true;
            this.mark_btn.Click += new System.EventHandler(this.mark_btn_Click);
            // 
            // AttendanceMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 148);
            this.Controls.Add(this.mark_btn);
            this.Controls.Add(this.mark_att);
            this.Controls.Add(this.label1);
            this.Name = "AttendanceMark";
            this.Text = "AttendanceMark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mark_att;
        private System.Windows.Forms.Button mark_btn;
    }
}