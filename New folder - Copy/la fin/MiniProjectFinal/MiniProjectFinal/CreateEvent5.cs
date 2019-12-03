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
    public partial class CreateEvent5 : UserControl
    {
        private String type2;
        private String nom2;
        private String add;
        private String cite;
        private String statee;
        private String code;
        private String datedebu;
        private String datedebutime;
        private String datefin;
        private String datefintime;



        public CreateEvent5()
        {
            InitializeComponent();
          //  city.Visible = false;
           // label2.Visible = false;
            label4.Visible = false;
            city.Text = "0";
            state.Text = "0";
            state.Visible = false;
        }

        public CreateEvent5(String t, String n, String ad, String ci, String sta, String codepostal, String dtb, String dtbti, String dfin, String dfintime)
        {
            InitializeComponent();
            this.type2 = t;
            this.nom2 = n;
            this.add = ad;
            this.cite = ci;
            this.statee = sta;
            this.code = codepostal;
            this.datedebu = dtb;
            this.datedebutime = dtbti;
            this.datefin = dfin;
            this.datefintime = dfintime;
           // city.Visible = false;
            city.Text = "0";
            state.Text = "0";
            state.Visible = false;

           // label2.Visible = false;
            label4.Visible = false;
        }



        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            if (bunifuDropdown1.selectedValue.ToString() == "privé")
            {
              //  city.Visible = true;
                state.Visible = true;

                //label2.Visible = true;
                label4.Visible = true;
                // public
            }
            else
            {
              //  city.Visible = false;
                state.Visible = false;

               // label2.Visible = false;
                label4.Visible = false;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            CreatEvent3 c3 = new CreatEvent3(this.type2, this.nom2);
            MainControlClass.showControl(c3, this);
        }

        private void CreateEvent5_Load(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            String sta = bunifuDropdown1.selectedValue.ToString();
            String pr =state.Text.ToString();
            String n = city.Text.ToString();
            CreatEvent4 c4 = new CreatEvent4(this.type2, this.nom2, this.add, this.cite, this.statee, this.code, this.datedebu, this.datefin, this.datedebutime, this.datefintime, sta, pr, n);

            MainControlClass.showControl(c4, this);
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
