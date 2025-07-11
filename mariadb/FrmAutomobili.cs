using mariadb.Data;
using mariadb.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mariadb
{
    public partial class FrmAutomobili : Form
    {
        private Automobil ctx = new Automobil();
        public FrmAutomobili()
        {
            InitializeComponent();
        }

        private void FrmAutomobili_Load(object sender, EventArgs e)
        {
            ClearForm();
            btnUpdate.Visible = false;
            LoadAutomobili();
        }
    }
}
