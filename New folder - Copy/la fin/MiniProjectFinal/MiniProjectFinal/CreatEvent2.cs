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
    public partial class CreatEvent2 : UserControl
    {

        private String typeEvent;
        public CreatEvent2()
        {
            InitializeComponent();
        }

        public CreatEvent2(String typee )
        {
            InitializeComponent();
            this.typeEvent = typee;
            
        }


        private void next_Click(object sender, EventArgs e)
        {
            string n;
            n = name.Text.ToString();
            CreatEvent3 c3 = new CreatEvent3(this.typeEvent, n);
            MainControlClass.showControl(c3, this);
        }

        private void back_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show(this.typeEvent);
            CreatEvent c1 = new CreatEvent();
            MainControlClass.showControl(c1, this);

        }

        private void name_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nameleave(object sender, EventArgs e)
        {
            if (name.Text == "")
                name.Text = "Entrez le nom de l'événement";
        }

        private void nameenter(object sender, EventArgs e)
        {
            if (name.Text == "Entrez le nom de l'événement")
                name.Text = "";
        }

        private void CreatEvent2_Load(object sender, EventArgs e)
        {

        }
    }
}
