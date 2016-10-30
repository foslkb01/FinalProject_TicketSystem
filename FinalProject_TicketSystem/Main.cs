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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer Form1 = new Customer();
            Form1.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            CurrentTickets Form1 = new CurrentTickets();


            Form1.Show();

          
        }
    }
}
