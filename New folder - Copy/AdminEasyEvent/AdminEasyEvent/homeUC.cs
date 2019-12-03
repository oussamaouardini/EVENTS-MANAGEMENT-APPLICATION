using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectFinal
{
    public partial class homeUC : UserControl
    {
        public homeUC()
        {
            InitializeComponent();
        }

        private void homeUC_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clickEvent cl = new clickEvent();
            MainControlClass.showControl(cl, this);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
