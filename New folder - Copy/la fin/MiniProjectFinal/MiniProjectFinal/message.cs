using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectFinal
{
    public partial class message : Form
    {
        private String mess;
        private String lastfrm;
        public message()
        {
            InitializeComponent();
        }
        public message(String m,String nm)
        {
            InitializeComponent();
            this.mess = m;
            label1.Text = m;
            lastfrm = nm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            //SignUp S = new SignUp();
            //if (S.Name == this.lastfrm)
            //{
            //    S.Show();
            //    this.Hide();
            //}
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
