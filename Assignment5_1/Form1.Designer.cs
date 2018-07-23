namespace Assignment5_1
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
            this.lblStudentProfile = new System.Windows.Forms.Label();
            this.lblrollno = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbldept = new System.Windows.Forms.Label();
            this.lblcourse = new System.Windows.Forms.Label();
            this.lblsem = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblphno = new System.Windows.Forms.Label();
            this.tbrollno = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.cbdept = new System.Windows.Forms.ComboBox();
            this.cbcourse = new System.Windows.Forms.ComboBox();
            this.cbsem = new System.Windows.Forms.ComboBox();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.tbphno = new System.Windows.Forms.TextBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.lbDisplaySelect = new System.Windows.Forms.ListBox();
            this.cbchoose = new System.Windows.Forms.ComboBox();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentsDatabaseDataSet = new Assignment5_1.AssignmentsDatabaseDataSet();
            this.studentInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new Assignment5_1.AssignmentsDatabaseDataSetTableAdapters.StudentInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentProfile
            // 
            this.lblStudentProfile.AutoSize = true;
            this.lblStudentProfile.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentProfile.Location = new System.Drawing.Point(322, 40);
            this.lblStudentProfile.Name = "lblStudentProfile";
            this.lblStudentProfile.Size = new System.Drawing.Size(217, 30);
            this.lblStudentProfile.TabIndex = 0;
            this.lblStudentProfile.Text = "STUDENT PROFILE";
            // 
            // lblrollno
            // 
            this.lblrollno.AutoSize = true;
            this.lblrollno.Location = new System.Drawing.Point(139, 101);
            this.lblrollno.Name = "lblrollno";
            this.lblrollno.Size = new System.Drawing.Size(42, 13);
            this.lblrollno.TabIndex = 1;
            this.lblrollno.Text = "Roll No";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(142, 148);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(142, 197);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(66, 13);
            this.lbldob.TabIndex = 3;
            this.lbldob.Text = "Date of Birth";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(142, 248);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(42, 13);
            this.lblgender.TabIndex = 4;
            this.lblgender.Text = "Gender";
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Location = new System.Drawing.Point(139, 286);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(62, 13);
            this.lbldept.TabIndex = 5;
            this.lbldept.Text = "Department";
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Location = new System.Drawing.Point(139, 332);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(40, 13);
            this.lblcourse.TabIndex = 6;
            this.lblcourse.Text = "Course";
            // 
            // lblsem
            // 
            this.lblsem.AutoSize = true;
            this.lblsem.Location = new System.Drawing.Point(142, 370);
            this.lblsem.Name = "lblsem";
            this.lblsem.Size = new System.Drawing.Size(51, 13);
            this.lblsem.TabIndex = 7;
            this.lblsem.Text = "Semester";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(142, 421);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(45, 13);
            this.lbladdress.TabIndex = 8;
            this.lbladdress.Text = "Address";
            // 
            // lblphno
            // 
            this.lblphno.AutoSize = true;
            this.lblphno.Location = new System.Drawing.Point(140, 462);
            this.lblphno.Name = "lblphno";
            this.lblphno.Size = new System.Drawing.Size(78, 13);
            this.lblphno.TabIndex = 9;
            this.lblphno.Text = "Phone Number";
            // 
            // tbrollno
            // 
            this.tbrollno.Location = new System.Drawing.Point(253, 93);
            this.tbrollno.Name = "tbrollno";
            this.tbrollno.Size = new System.Drawing.Size(157, 20);
            this.tbrollno.TabIndex = 10;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(253, 148);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(157, 20);
            this.tbname.TabIndex = 11;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(253, 243);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(48, 17);
            this.rbmale.TabIndex = 13;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(413, 243);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(59, 17);
            this.rbfemale.TabIndex = 14;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // cbdept
            // 
            this.cbdept.FormattingEnabled = true;
            this.cbdept.Items.AddRange(new object[] {
            "Computer Science",
            "Information Science",
            "Mechanical Engineering",
            "Electrical and Electronic Engineering",
            "Telecommunication Engg"});
            this.cbdept.Location = new System.Drawing.Point(253, 277);
            this.cbdept.Name = "cbdept";
            this.cbdept.Size = new System.Drawing.Size(184, 21);
            this.cbdept.TabIndex = 15;
            // 
            // cbcourse
            // 
            this.cbcourse.FormattingEnabled = true;
            this.cbcourse.Items.AddRange(new object[] {
            "B.E",
            "B.Tech",
            "BSc",
            "M S",
            "Msc",
            "M.Tech"});
            this.cbcourse.Location = new System.Drawing.Point(253, 323);
            this.cbcourse.Name = "cbcourse";
            this.cbcourse.Size = new System.Drawing.Size(184, 21);
            this.cbcourse.TabIndex = 16;
            // 
            // cbsem
            // 
            this.cbsem.FormattingEnabled = true;
            this.cbsem.Items.AddRange(new object[] {
            "Semester I",
            "Semester II",
            "Semester III",
            "Semester IV",
            "Semester V",
            "Semester VI",
            "Semester VII",
            "Semester VIII",
            ""});
            this.cbsem.Location = new System.Drawing.Point(253, 370);
            this.cbsem.Name = "cbsem";
            this.cbsem.Size = new System.Drawing.Size(184, 21);
            this.cbsem.TabIndex = 17;
            // 
            // dtpdob
            // 
            this.dtpdob.Location = new System.Drawing.Point(253, 189);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(200, 20);
            this.dtpdob.TabIndex = 18;
            // 
            // tbaddress
            // 
            this.tbaddress.Location = new System.Drawing.Point(253, 414);
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(184, 20);
            this.tbaddress.TabIndex = 19;
            // 
            // tbphno
            // 
            this.tbphno.Location = new System.Drawing.Point(253, 454);
            this.tbphno.Name = "tbphno";
            this.tbphno.Size = new System.Drawing.Size(184, 20);
            this.tbphno.TabIndex = 20;
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(446, 90);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 21;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(226, 496);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 22;
            this.btnnew.Text = "Add New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(362, 496);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 23;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(495, 495);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 24;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(652, 495);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 25;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // lbDisplaySelect
            // 
            this.lbDisplaySelect.FormattingEnabled = true;
            this.lbDisplaySelect.Location = new System.Drawing.Point(578, 131);
            this.lbDisplaySelect.Name = "lbDisplaySelect";
            this.lbDisplaySelect.Size = new System.Drawing.Size(286, 238);
            this.lbDisplaySelect.TabIndex = 26;
            // 
            // cbchoose
            // 
            this.cbchoose.DataSource = this.studentInfoBindingSource1;
            this.cbchoose.DisplayMember = "Name";
            this.cbchoose.FormattingEnabled = true;
            this.cbchoose.Location = new System.Drawing.Point(578, 90);
            this.cbchoose.Name = "cbchoose";
            this.cbchoose.Size = new System.Drawing.Size(121, 21);
            this.cbchoose.TabIndex = 27;
            this.cbchoose.ValueMember = "RollNo";
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            // 
            // assignmentsDatabaseDataSet
            // 
            this.assignmentsDatabaseDataSet.DataSetName = "AssignmentsDatabaseDataSet";
            this.assignmentsDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoBindingSource1
            // 
            this.studentInfoBindingSource1.DataMember = "StudentInfo";
            this.studentInfoBindingSource1.DataSource = this.assignmentsDatabaseDataSet;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(942, 521);
            this.Controls.Add(this.cbchoose);
            this.Controls.Add(this.lbDisplaySelect);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.tbphno);
            this.Controls.Add(this.tbaddress);
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.cbsem);
            this.Controls.Add(this.cbcourse);
            this.Controls.Add(this.cbdept);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbrollno);
            this.Controls.Add(this.lblphno);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblsem);
            this.Controls.Add(this.lblcourse);
            this.Controls.Add(this.lbldept);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblrollno);
            this.Controls.Add(this.lblStudentProfile);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentProfile;
        private System.Windows.Forms.Label lblrollno;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Label lblsem;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblphno;
        private System.Windows.Forms.TextBox tbrollno;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.ComboBox cbdept;
        private System.Windows.Forms.ComboBox cbcourse;
        private System.Windows.Forms.ComboBox cbsem;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.TextBox tbphno;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ListBox lbDisplaySelect;
        private System.Windows.Forms.ComboBox cbchoose;
        private System.Windows.Forms.BindingSource assignmentsDatabaseDataSetBindingSource;
      //  private AssignmentsDatabaseDataSet assignmentsDatabaseDataSet;
      //  private AssignmentsDatabaseDataSet2 assignmentsDatabaseDataSet2;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private AssignmentsDatabaseDataSet assignmentsDatabaseDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource1;
        private AssignmentsDatabaseDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        // private AssignmentsDatabaseDataSet2TableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
    }
//#endregion

}


