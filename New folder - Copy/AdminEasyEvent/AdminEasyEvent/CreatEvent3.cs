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
    public partial class CreatEvent3 : UserControl
    {
        private String type1;
        private String nom1;


        public CreatEvent3()
        {
            InitializeComponent();
        }
        public CreatEvent3(String t, String n)
        {
            InitializeComponent();
            this.nom1 = n;
            this.type1 = t;
        }


        private void next_Click(object sender, EventArgs e)
        {
            String a = address.Text.ToString();
            String c = city.Text.ToString();
            String s = state.Text.ToString();
            String zc = zCode.Text.ToString();
            String dtd = startDate.Value.ToString();
            String dtf = bunifuDatepicker1.Value.ToString();
            String dtdti = endTime.Text.ToString();
            String dtfti = startTime.Text.ToString();




            CreatEvent4 c4 = new CreatEvent4();
            //UserControl1 u1 = new UserControl1()
            UserControl1 u1 = new UserControl1(this.type1, this.nom1, a, c, s, zc, dtd, dtf, dtdti, dtfti);
            MainControlClass.showControl(u1, this);
        }

        private void back_Click(object sender, EventArgs e)
        {
            CreatEvent2 c2 = new CreatEvent2(this.type1);
            MainControlClass.showControl(c2, this);
        }

        private void CreatEvent3_Load(object sender, EventArgs e)
        {

        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void zCode_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Justn(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void debutime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fintime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


