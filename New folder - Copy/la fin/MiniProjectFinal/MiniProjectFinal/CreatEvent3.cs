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
        public CreatEvent3(String t,String n)
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
            String dtdti = startTime.Text.ToString();
            String dtfti = endTime.Text.ToString();

            CreateEvent5 c4 = new CreateEvent5(this.type1,this.nom1,a,c,s,zc,dtd,dtf, dtdti, dtfti);
            MainControlClass.showControl(c4,this);
        }

        private void back_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.type1);
            // MessageBox.Show(this.nom1);
            CreatEvent2 c2 = new CreatEvent2(this.type1);
            MainControlClass.showControl(c2, this);
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void address_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void city_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void state_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void zCode_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void startDate_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void startTime_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void endTime_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void addressleave(object sender, EventArgs e)
        {
            if (address.Text == "")
                address.Text = "Adresse";
        }

        private void addressenter(object sender, EventArgs e)
        {
            if (address.Text == "Adresse")
                address.Text = "";
        }

        private void Villeleave(object sender, EventArgs e)
        {
            if (city.Text == "")
                city.Text = "Ville";
        }

        private void Villeenter(object sender, EventArgs e)
        {
            if (city.Text == "Ville")
                city.Text = "";
        }

        private void Organisateurleave(object sender, EventArgs e)
        {
            if (state.Text == "")
                state.Text = "Organisateur";
        }

        private void Organisateurenter(object sender, EventArgs e)
        {
            if (state.Text == "Organisateur")
                state.Text = "";
        }

        private void zCodeleave(object sender, EventArgs e)
        {
            if (zCode.Text == "")
                zCode.Text = "Code postal";
        }

        private void zCodeenter(object sender, EventArgs e)
        {
            if (zCode.Text == "Code postal")
                zCode.Text = "";
        }

        private void CreatEvent3_Load(object sender, EventArgs e)
        {

        }
    }
}
