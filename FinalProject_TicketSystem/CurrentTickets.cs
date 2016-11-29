using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FinalProject_TicketSystem
{
    public partial class CurrentTickets : Form

    {



        public CurrentTickets()
        {
            InitializeComponent();
        }

        private void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DisplayTable()
        {

        }
        private void CurrentTickets_Load(object sender, EventArgs e)
        {



        }

        private void CurrentTickets_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketsDataSet.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.ticketsDataSet.Tickets);


        }

        private void ticketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketsDataSet);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (this.ticketsDataGridView.SelectedRows.Count > 0)
            {
               
        { ticketsDataGridView.Rows.RemoveAt(this.ticketsDataGridView.SelectedRows[0].Index);
                    txtstatus.Text = "Row Deleted"; }

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Edit ed = new Edit();
            ed.Show();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int totaltickets;
            totaltickets = (int)ticketsTableAdapter.Count();
            string total = totaltickets.ToString();
            txtstatus.Text = "Total Tickets: " + totaltickets;


        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int search = 0;
            Int32.TryParse(txtSearch.Text, out search);
            ticketsDataGridView.DataSource = 
            ticketsDataSet.Tickets.Select("Id = '" + search + "'");
        }
    }
    }

