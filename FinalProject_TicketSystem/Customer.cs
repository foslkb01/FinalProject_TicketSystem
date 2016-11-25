using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_TicketSystem
{
    public partial class Customer : Form
    {

       

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.txtName.Text))
            {
                MessageBox.Show("Please fill in the name");
            }

            else if (string.IsNullOrWhiteSpace(this.txtPhone.Text))
            {
                MessageBox.Show("Please fill in the phone number");
            }

            else if (string.IsNullOrWhiteSpace(this.txtEmail.Text))
            {
                MessageBox.Show("Please fill in your email");
            }

            else if (string.IsNullOrWhiteSpace(this.txtLocation.Text))
            {
                MessageBox.Show("Please fill in your location");
            }

            else if (string.IsNullOrWhiteSpace(this.dtpDate.Text))
            {
                MessageBox.Show("Please pick a date");
            }

            else if (string.IsNullOrWhiteSpace(this.drpPriority.Text))
            {
                MessageBox.Show("Please choose a priority");
            }

            else if (string.IsNullOrWhiteSpace(this.txtDescription.Text))
            {
                MessageBox.Show("Please fill in the descrition");
            }





        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
