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


        }

        

           

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ticketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketsDataSet);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            adapter.Insert(nameTextBox.Text, locationTextBox.Text, descriptionTextBox.Text, dateDateTimePicker.Value);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.nameTextBox.Text))
            {
                MessageBox.Show("Please fill in the name");
            }

            else if (string.IsNullOrWhiteSpace(this.locationTextBox.Text))
            {
                MessageBox.Show("Please fill in your location");
            }

            else if (string.IsNullOrWhiteSpace(this.descriptionTextBox.Text))
            {
                MessageBox.Show("Please fill in your location");
            }


            adapter.Insert(nameTextBox.Text, locationTextBox.Text, descriptionTextBox.Text, dateDateTimePicker.Value);
        }
    }
}
