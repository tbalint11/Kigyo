using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class Snake : Form
    {
        int fejx = 100;
        int fejy = 100;
        int iranyx = 1;
        int iranyy = 0;
        int hossz = 5;
        int lepes = 0;

        public Snake()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fejx += iranyx * KigyoElem.meret;
            fejy += iranyy * KigyoElem.meret;

            foreach (KigyoElem item in Controls)
            {
                if ((item.Top == fejy && item.Left == fejx) || (item.Top < 0 || item.Left < 0 || item.Top > 600 || item.Left > 600))
                {
                    Application.Restart();
                }
            }

            KigyoElem ujFej = new KigyoElem();
            ujFej.Left = fejx;
            ujFej.Top = fejy;
            Controls.Add(ujFej);

            if (Controls.Count > hossz) Controls.RemoveAt(0);
            
            if (lepes % 5 == 0) hossz++;

            lepes++;

        }
        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && iranyx != 0 && iranyy != -1) { iranyx = 0; iranyy = -1; }
            if (e.KeyCode == Keys.S && iranyx != 0 && iranyy != 1) { iranyx = 0; iranyy = 1; }
            if (e.KeyCode == Keys.A && iranyx != -1 && iranyy != 0) { iranyx = -1; iranyy = 0; }
            if (e.KeyCode == Keys.D && iranyx != 1 && iranyy != 0) { iranyx = 1; iranyy = 0; }
        }


    }
}
