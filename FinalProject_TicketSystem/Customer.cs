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
        private TicketsDataSetTableAdapters.TicketsTableAdapter adapter;


        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            adapter = new TicketsDataSetTableAdapters.TicketsTableAdapter();
            dtpDate.MaxDate = DateTime.Now;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double phone = Convert.ToDouble(txtPhone.Text);
            string email = txtEmail.Text;
            string location = txtLocation.Text;
            double priority = Convert.ToDouble(drbPriority.Text);
            string description = txtDescription.Text;



            if (string.IsNullOrWhiteSpace(this.txtName.Text))
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

            else if (string.IsNullOrWhiteSpace(this.drbPriority.Text))
            {
                MessageBox.Show("Please choose a priority");
            }

            else if (string.IsNullOrWhiteSpace(this.txtDescription.Text))
            {
                MessageBox.Show("Please fill in the descrition");
            }

            try
            {

                adapter.Insert(name, phone, email, location, dtpDate.Value, priority, description);
            }

            catch
            {
                MessageBox.Show("Error");
            }
        }



    }
}