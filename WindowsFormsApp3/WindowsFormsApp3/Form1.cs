using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x, y, a;
        Jirachi jirachi;

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            Graphics g = CreateGraphics();
            PaintEventArgs p = new PaintEventArgs(g, ClientRectangle);

            x = e.X;
            y = e.Y;
            a = 30;
            for (int i = 0; i < 1; i++)
            {
                //x = r.Next(-400, ClientRectangle.Width + 400);
                //y = r.Next(-400, ClientRectangle.Height + 400);
                //a = r.Next(4, 4);
                jirachi = new jirachi(x, y, a);
                jirachi.crtaj(g);
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
