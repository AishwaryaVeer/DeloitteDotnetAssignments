using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_1
{
    public partial class Form1 : Form
    {
        AssignmentsDatabaseEntities db = new AssignmentsDatabaseEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            StudentInfo ob = new StudentInfo();

            int Roll = int.Parse(tbrollno.Text);
            string Name = tbname.Text;
            DateTime DOB = DateTime.Parse(dtpdob.Value.ToString());
            string Gender = "";
            if (rbmale.Checked)
                Gender = "Male";
            if (rbfemale.Checked)
                Gender = "Female";
            string Dept = cbdept.SelectedItem.ToString();
            string Course = cbcourse.SelectedItem.ToString();
            string Sem = cbsem.SelectedItem.ToString();
            string addr = tbaddress.Text;
            string PhNo = tbphno.Text;

            MessageBox.Show(Roll + "\n" + Name + "\n" + DOB + "\n" + Gender + "\n" + Dept + "\n" + Course + "\n" + Sem + "\n" + addr + "\n" + PhNo);

          
          
                ob.RollNo = Roll;
                ob.Name = Name;
                ob.DateOfBirth = DOB;
                ob.Gender = Gender;
                ob.Department = Dept;
                ob.Course = Course;
                ob.Semester = Sem;
                ob.Address = addr;
                ob.PhoneNo = PhNo;

                db.StudentInfoes.Add(ob);

                int res = db.SaveChanges();
                if (res > 0)
                    MessageBox.Show("data inserted : " + res);
            this.studentInfoTableAdapter.Fill(this.assignmentsDatabaseDataSet.StudentInfo);
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            foreach (var ob in db.StudentInfoes)
            {
                lbDisplaySelect.Items.Add(ob.RollNo);
                lbDisplaySelect.Items.Add(ob.Name);
                lbDisplaySelect.Items.Add(ob.DateOfBirth);
                lbDisplaySelect.Items.Add(ob.Gender);
                lbDisplaySelect.Items.Add(ob.Department);
                lbDisplaySelect.Items.Add(ob.Course);
                lbDisplaySelect.Items.Add(ob.Semester);
                lbDisplaySelect.Items.Add(ob.Address);
                lbDisplaySelect.Items.Add(ob.PhoneNo);
                lbDisplaySelect.Items.Add("=================================");
               

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string Dept = cbdept.SelectedItem.ToString();
            string Course = cbcourse.SelectedItem.ToString();
            string Sem = cbsem.SelectedItem.ToString();
            string PhNo = tbphno.Text;

            int roll = (int)cbchoose.SelectedValue;

            var olddata = db.StudentInfoes.Where(x => x.RollNo.Equals( roll)).SingleOrDefault();

            olddata.Department = Dept;
            olddata.Course = Course;
            olddata.Semester = Sem;
            olddata.PhoneNo = PhNo;

            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("data updated");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignmentsDatabaseDataSet.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.assignmentsDatabaseDataSet.StudentInfo);

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int roll = (int)cbchoose.SelectedValue;
            var olddata = db.StudentInfoes.Where(x => x.RollNo.Equals(roll)).SingleOrDefault();

            db.StudentInfoes.Remove(olddata);
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Data deleted");
            this.studentInfoTableAdapter.Fill(this.assignmentsDatabaseDataSet.StudentInfo);
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            int roll = (int)cbchoose.SelectedValue;
            var ob = db.StudentInfoes.Where(x => x.RollNo.Equals(roll)).SingleOrDefault();
            lbDisplaySelect.Items.Clear();

            lbDisplaySelect.Items.Add(ob.RollNo);
            lbDisplaySelect.Items.Add(ob.Name);
            lbDisplaySelect.Items.Add(ob.DateOfBirth);
            lbDisplaySelect.Items.Add(ob.Gender);
            lbDisplaySelect.Items.Add(ob.Department);
            lbDisplaySelect.Items.Add(ob.Course);
            lbDisplaySelect.Items.Add(ob.Semester);
            lbDisplaySelect.Items.Add(ob.Address);
            lbDisplaySelect.Items.Add(ob.PhoneNo);
            lbDisplaySelect.Items.Add("=================================");
        }
    }
}
