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
    public partial class CreatEvent : UserControl
    {
        public CreatEvent()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {

            String type = bunifuDropdown1.selectedValue.ToString();
            CreatEvent2 c2 = new CreatEvent2(type);
            MainControlClass.showControl(c2,this);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            homeUC hm = new homeUC();
            learninga uc = new learninga();
            MainControlClass.showControl(uc,this);
        }

        private void CreatEvent_Load(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }
    }
}
