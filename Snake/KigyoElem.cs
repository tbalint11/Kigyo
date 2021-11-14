using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    class KigyoElem : PictureBox
    {
        public static int meret = 30;
        public KigyoElem()
        {
            Width = meret;
            Height = meret;
            BackColor = Color.Black;
        }
    }
}
