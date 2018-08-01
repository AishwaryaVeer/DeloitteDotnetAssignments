using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cardno = int.Parse(txtcardno.Text);
            DateTime exp = DateTime.Parse(txtdate.Text);
            int cvv = int.Parse(txtcvv.Text);
            float amt = float.Parse(txtamt.Text);
            try
            {
                ServiceReference1.ValidateClient ob = new ServiceReference1.ValidateClient();
                var ans = ob.Transaction(cardno, exp, cvv, amt);
                if(ans)
                {
                    MessageBox.Show("Transaction Completed!");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
