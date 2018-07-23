using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment4_2
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;
        string constr = "Data Source=DESKTOP-LT51R1L\\MSSQLSERVERR;Initial Catalog=AssignmentsDatabase;Integrated Security=True;Pooling=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
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

            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "insert into StudentInfo values (@rn,@nm,@dob,@gen,@dept,@crs,@sem,@adr,@phno)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@rn", Roll);
                cmd.Parameters.AddWithValue("@nm", Name);
                cmd.Parameters.AddWithValue("@dob", DOB);
                cmd.Parameters.AddWithValue("@gen", Gender);
                cmd.Parameters.AddWithValue("@dept", Dept);
                cmd.Parameters.AddWithValue("@crs", Course);
                cmd.Parameters.AddWithValue("@sem", Sem);
                cmd.Parameters.AddWithValue("@adr", addr);
                cmd.Parameters.AddWithValue("@phno", PhNo);
                
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("data inserted : " + res);
                //this.registerShoppingTableAdapter.Fill(this.trainingDBDataSet.RegisterShopping);
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }




        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "select * from StudentInfo";
                cmd = new SqlCommand(query, con);
                r = cmd.ExecuteReader();
                lbDisplaySelect.Items.Clear();
                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        lbDisplaySelect.Items.Add(r[i]);

                    }
                    lbDisplaySelect.Items.Add("*****************");
                }

            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string Dept = cbdept.SelectedItem.ToString();
                string Course = cbcourse.SelectedItem.ToString();
                string Sem = cbsem.SelectedItem.ToString();
                string PhNo = tbphno.Text;
                
                string roll = cbchoose.SelectedValue.ToString();

                con = new SqlConnection(constr);
                con.Open();
                string query = "update StudentInfo set Department = @dept , Course= @crs ,Semester= @sem, PhoneNo =@phno where RollNo =@roll";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@dept", Dept);
                cmd.Parameters.AddWithValue("@crs", Course);
                cmd.Parameters.AddWithValue("@roll", roll);
                cmd.Parameters.AddWithValue("@sem", Sem);
                cmd.Parameters.AddWithValue("@phno", PhNo);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("data updated : " + res);
                
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignmentsDatabaseDataSet2.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.assignmentsDatabaseDataSet2.StudentInfo);

        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                string roll = cbchoose.SelectedValue.ToString();
                con = new SqlConnection(constr);
                con.Open();
                string query = "select * from StudentInfo where RollNo=@roll";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roll", roll);
                r = cmd.ExecuteReader();
                lbDisplaySelect.Items.Clear();
                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        lbDisplaySelect.Items.Add(r[i]);

                    }
                    lbDisplaySelect.Items.Add("*****************");
                }

            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string roll = cbchoose.SelectedValue.ToString();
                con = new SqlConnection(constr);
                con.Open();
                string query = "delete from StudentInfo where RollNo=@roll";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roll", roll);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("data deleted : " + res);
                this.studentInfoTableAdapter.Fill(this.assignmentsDatabaseDataSet2.StudentInfo);


            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }

        }
    }
}
