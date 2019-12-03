using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEasyEvent
{
    public partial class okform : Form
    {
        int id;
        private string msg;
        public Boolean conf = false;
        public okform()
        {
            InitializeComponent();
        }
        public okform( String m)
        {
            InitializeComponent();
            this.msg = m;
            label1.Text = m;
        }


        public okform(String m,int i)
        {
            InitializeComponent();
            this.msg = m;
            label1.Text = m;
            this.id = i;
        }


        private void okform_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {

            if( this.id==2)
            {
                conf = true;
                Dashboard dss = new Dashboard();
                dss.ShowDialog();
                this.Close();

            }

            this.Hide();
        }
    }
}
