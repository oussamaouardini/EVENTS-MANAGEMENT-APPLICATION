using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProjectFinal;



namespace AdminEasyEvent
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            learninga h = new learninga();
            // MainControlClass.showControl(home, content);
            MainControlClass.showControl(h, content);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatEvent c1 = new CreatEvent();
            MainControlClass.showControl(c1, content);
        }

        private void home_Click(object sender, EventArgs e)
        {
            //homeUC home = new homeUC();
            learninga h = new learninga();
            // MainControlClass.showControl(home, content);
            MainControlClass.showControl(h, content);
        }

        private void approve_Click(object sender, EventArgs e)
        {
            Approve pr = new Approve();
            MainControlClass.showControl(pr, content);
        }

        private void addTicket_Click(object sender, EventArgs e)
        {
            AddTicket ticket = new AddTicket();
            MainControlClass.showControl(ticket, content);
        }

        private void deleteEvent_Click(object sender, EventArgs e)
        {
            remove rv = new remove();
            MainControlClass.showControl(rv, content);
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fm = new Form1();
            fm.ShowDialog();
        }

        private void track_Click(object sender, EventArgs e)
        {
            Grraph gr = new Grraph();
            MainControlClass.showControl(gr, content);
        }

        private void homeUC1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
