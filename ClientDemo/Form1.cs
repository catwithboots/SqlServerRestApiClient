using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BindingSource bs = new BindingSource();
            bs.DataSource = DemoMethods.GetInstanceNames();
            cmbInstances.DataSource = bs;
        }

        private void cmbInstances_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DemoMethods.GetDatabaseNames(cmbInstances.SelectedValue.ToString());
            cmbDatabases.DataSource = bs;
        }
    }
}
