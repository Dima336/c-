using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace lab2
{
    class Class1 : Button
    {
        public void CreateMyButton(Button btn, Form frm, string str, int x, int y, int w, int h, EventHandler evh)
        {
            btn = new Button();

            btn.Text = str;
            btn.Location = new Point(x, y);
            btn.Size = new Size(w, h);
            btn.Click += evh;

            frm.Controls.Add(btn);

        }
    }
}
