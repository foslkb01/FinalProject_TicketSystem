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

        //Use the following for testing within Visual Studio
        private const string dbTICKETS = "Data Source = ../../tickets.db; Version = 3";

        //Use the following for deployment.
       //private const string dbEMPLOYEES = "Data Source = CSIndustries.db; Version = 3";

        SQLiteConnection connection = new SQLiteConnection(dbTICKETS);
        SQLiteDataAdapter dataAdapter;
        SQLiteCommand command;
        DataSet ds = new DataSet();
        string sql;
       

        public CurrentTickets()
        {
            InitializeComponent();
        }

        private void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CurrentTickets_Load(object sender, EventArgs e)
        {
            
        }
    }
}
