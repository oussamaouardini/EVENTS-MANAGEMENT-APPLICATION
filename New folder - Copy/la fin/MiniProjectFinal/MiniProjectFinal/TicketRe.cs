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
    public partial class TicketRe : Form
    {
     /*   public TicketRe()
        {
            InitializeComponent();
        }*/
        public TicketRe(String name, String imgloc, String Ev_id, String dtb, String orga, String add, String price,String dtf,String m,String p )
        {
            InitializeComponent(name, imgloc, Ev_id, dtb, orga, add, price, dtf,m,p);
            Registre r = new Registre(name, imgloc, Ev_id, dtb, orga, add, price, dtf,m,p);
        }

        private void register1_Load(object sender, EventArgs e)
        {

        }

        private void register1_Load_1(object sender, EventArgs e)
        {

        }

        private void registre1_Load(object sender, EventArgs e)
        {

        }
    }
}
