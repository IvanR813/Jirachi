using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class Jirachi
    {
        protected int x, y, a;

        public Jirachi(int x, int y, int a)
        {
            this.x = x;
            this.y = y;
            this.a = a;
        }

        public void crtaj(Graphics g)
        {
            GraphicsPath puteljak = new GraphicsPath();
            GraphicsPath puteljak1 = new GraphicsPath();
            GraphicsPath puteljak2 = new GraphicsPath();
            GraphicsPath puteljak22 = new GraphicsPath();
            SolidBrush cetka = new SolidBrush(Color.FromArgb(229, 232, 232));
            SolidBrush cetka1 = new SolidBrush(Color.Yellow);
            SolidBrush cetka2 = new SolidBrush(Color.Black);
            SolidBrush cetka3 = new SolidBrush(Color.DarkTurquoise);
            SolidBrush cetka4 = new SolidBrush(Color.LightGoldenrodYellow);
            Pen olovka = new Pen(Color.Black, a / 20);
            Point[] p = new Point[4];
            //desni gornji deo 1
            p[0] = new Point(x, y);
            p[1] = new Point(x + a / 2 + a / 4, y);
            p[2] = new Point(x + a + a / 2, y - 2 * a / 3);
            p[3] = new Point(x + a + a / 2, y - 2 * a / 3);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            //levi gornji deo 2
            p[0] = new Point(x, y);
            p[1] = new Point(x - a / 2 - a / 4, y);
            p[2] = new Point(x - a - a / 2, y - 2 * a / 3);
            p[3] = new Point(x - a - a / 2, y - 2 * a / 3);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            //desni deo uz gornji 3
            //g.DrawLine(olovka, x + 3 * a / 2, y - 2 * a / 3, x + 5 * a / 2, y);
            //levi deo uz gornji 4
            //g.DrawLine(olovka, x - 3 * a / 2, y - 2 * a / 3, x - 5 * a / 2, y);
            p[0] = new Point(x - 5 * a / 2, y);
            p[1] = new Point(x - 5 * a / 2 + a / 16, y + a / 2);
            p[2] = new Point(x - 5 * a / 2 + a / 16, y + a);
            p[3] = new Point(x - 5 * a / 2 - a / 8, y + 2 * a);
            //levi deo 5
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x + 5 * a / 2, y);
            p[1] = new Point(x + 5 * a / 2 - a / 16, y + a / 2);
            p[2] = new Point(x + 5 * a / 2 - a / 16, y + a);
            p[3] = new Point(x + 5 * a / 2 + a / 8, y + 2 * a);
            //desni deo 6
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x - 5 * a / 2 - a / 8, y + 2 * a);
            p[1] = new Point(x - 2 * a + a / 2, y + 2 * a + a / 2 + a / 3);
            p[2] = new Point(x - a - a / 2 + a, y + 3 * a - a / 3);
            p[3] = new Point(x - a / 2 - a / 4, y + 3 * a - a / 8);
            //levi deo 7
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x + 5 * a / 2 + a / 8, y + 2 * a);
            p[1] = new Point(x + 2 * a - a / 2, y + 2 * a + a / 2 + a / 3);
            p[2] = new Point(x + a + a / 2 - a, y + 3 * a - a / 3);
            p[3] = new Point(x + a / 2 + a / 4, y + 3 * a - a / 8);
            //desni deo 8
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x - a / 2 - a / 4, y + 3 * a - a / 8 - a / 32);
            p[1] = new Point(x - a - a / 2, y + 3 * a + a / 8);
            p[2] = new Point(x - 3 * a / 2, y + 3 * a);
            p[3] = new Point(x - 4 * a, y + 5 * a);
            //levi deo ruke 9
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x + a / 2 + a / 4, y + 3 * a - a / 8 - a / 32);
            p[1] = new Point(x + a + a / 2, y + 3 * a + a / 8);
            p[2] = new Point(x + 3 * a / 2, y + 3 * a);
            p[3] = new Point(x + 4 * a, y + 5 * a);
            //desni deo ruke 10
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x - 4 * a, y + 5 * a);
            p[1] = new Point(x - 3 * a - 3 * a / 4 - a / 16, y + 5 * a + a / 8);
            p[2] = new Point(x - 3 * a - 13 * a / 16, y + 5 * a + a / 16);
            p[3] = new Point(x - 3 * a - 2 * a / 3 + a / 8, y + 5 * a);
            //donji deo prvog prsta sa leve strane 11
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x + 4 * a, y + 5 * a);
            p[1] = new Point(x + 3 * a + 3 * a / 4 + a / 16, y + 5 * a + a / 8);
            p[2] = new Point(x + 3 * a + 13 * a / 16, y + 5 * a + a / 16);
            p[3] = new Point(x + 3 * a + 2 * a / 3, y + 5 * a);
            //desni deo donji deo prvog prsta 12
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x - 3 * a - 2 * a / 3 + a / 8, y + 5 * a);
            p[1] = new Point(x - 3 * a - 2 * a / 5, y + 5 * a);
            p[2] = new Point(x - 3 * a - 3 * a / 3 - a / 16, y + 5 * a + a / 8 + a / 32);
            p[3] = new Point(x - 4 * a + a / 8 + a / 16, y + 5 * a + a / 4 + a / 16);

            //gornji deo srednjeg levog prsta 13

            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x + 3 * a + 2 * a / 3 - a / 8, y + 5 * a);
            p[1] = new Point(x + 3 * a + 2 * a / 5, y + 5 * a);
            p[2] = new Point(x + 3 * a + 3 * a / 3 + a / 16, y + 5 * a + a / 8 + a / 32);
            p[3] = new Point(x + 4 * a - a / 8 - a / 16, y + 5 * a + a / 4 + a / 16);
            //gornji deo srednjeg desnog prsta 14

            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);

            p[0] = new Point(x - 4 * a + a / 8 + a / 16, y + 5 * a + a / 4 + a / 16);
            p[1] = new Point(x - 4 * a + a / 4, y + 5 * a + a / 4 + a / 32);
            p[2] = new Point(x - 4 * a + a / 2, y + 5 * a + a / 4 - a / 16);
            p[3] = new Point(x - 3 * a - a / 2, y + 5 * a + a / 4);
            //donji deo srednjeg levog prsta 15

            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x + 4 * a - a / 8 - a / 16, y + 5 * a + a / 4 + a / 16);
            p[1] = new Point(x + 4 * a - a / 4, y + 5 * a + a / 4 + a / 32);
            p[2] = new Point(x + 4 * a - a / 2, y + 5 * a + a / 4 - a / 16);
            p[3] = new Point(x + 3 * a + a / 2, y + 5 * a + a / 4);
            //donji deo srednjeg desnog prsta 16

            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x - 3 * a - a / 2, y + 5 * a + a / 4);
            p[1] = new Point(x - 3 * a - a / 6, y + 5 * a + a / 8);
            p[2] = new Point(x - 3 * a - a / 3, y + 5 * a);
            p[3] = new Point(x - 4 * a + a / 4, y + 5 * a + a / 2 - a / 8);
            //gornji deo levog treceg prsta 17

            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x + 3 * a + a / 2, y + 5 * a + a / 4);
            p[1] = new Point(x + 3 * a + a / 6, y + 5 * a + a / 8);
            p[2] = new Point(x + 3 * a + a / 3, y + 5 * a);
            p[3] = new Point(x + 4 * a - a / 4, y + 5 * a + a / 2 - a / 8);
            //gornji deo desnog treceg prsta 18

            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x - 4 * a + a / 4, y + 5 * a + a / 2 - a / 8);
            p[1] = new Point(x - 4 * a + 3 * a / 4 - a / 8, y + 6 * a - a / 2 - a / 16);
            p[2] = new Point(x - 3 * a - a / 2, y + 5 * a + a / 2 - a / 16);
            p[3] = new Point(x - 3 * a - a / 32, y + 5 * a + a / 4);
            //donji deo levog treceg prsta 19

            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x + 4 * a - a / 4, y + 5 * a + a / 2 - a / 8);
            p[1] = new Point(x + 4 * a - 3 * a / 4 + a / 8, y + 6 * a - a / 2 - a / 16);
            p[2] = new Point(x + 3 * a + a / 2, y + 5 * a + a / 2 - a / 16);
            p[3] = new Point(x + 3 * a + a / 32, y + 5 * a + a / 4);
            //donji deo desnog treceg prsta 20

            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            //levi deo posle prstiju 21
            //g.DrawLine(olovka, x - 3 * a - a / 32, y + 5 * a + a / 4, x - 2 * a - a / 2, y + 6 * a - a / 4);

            //desni deo posle prstiju 22
            //g.DrawLine(olovka, x + 3 * a + a / 32, y + 5 * a + a / 4, x + 2 * a + a / 2, y + 6 * a - a / 4);

            //levi deo posle dela do prstiju 23
            //g.DrawLine(olovka, x - 2 * a - a / 2, y + 6 * a - a / 4, x - 2 * a, y + 5 * a + a / 2);
            //desni deo posle dela do prstiju 24
            //g.DrawLine(olovka, x + 2 * a + a / 2, y + 6 * a - a / 4, x + 2 * a, y + 5 * a + a / 2);

            p[0] = new Point(x - 2 * a, y + 5 * a + a / 2);
            p[1] = new Point(x - 2 * a, y + 6 * a);
            p[2] = new Point(x - a - 3 * a / 4, y + 7 * a);
            p[3] = new Point(x - a - a / 4, y + 8 * a - a / 2 - a / 4);
            //levi donji trup 27
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x + 2 * a, y + 5 * a + a / 2);
            p[1] = new Point(x + 2 * a, y + 6 * a);
            p[2] = new Point(x + a + 3 * a / 4, y + 7 * a);
            p[3] = new Point(x + a + a / 4, y + 8 * a - a / 2 - a / 4);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);

            p[0] = new Point(x - a - a / 4, y + 7 * a + a / 4);
            p[1] = new Point(x - a / 2 - a / 4 - a / 16, y + 8 * a - a / 2);
            p[2] = new Point(x - a / 2 - a / 4, y + 7 * a);
            p[3] = new Point(x - a / 2, y + 7 * a - a / 2);
            //levi deo pred kraj 29
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x + a + a / 4, y + 7 * a + a / 4);
            p[1] = new Point(x + a / 2 + a / 4 + a / 16, y + 8 * a - a / 2);
            p[2] = new Point(x + a / 2 + a / 4, y + 7 * a);
            p[3] = new Point(x + a / 2, y + 7 * a - a / 2);
            //desni deo pred kraj 30
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            //g.DrawLine(olovka, x - a / 2, y + 7 * a - a / 2, x + a / 2, y + 7 * a - a / 2);
            //g.FillPath(cetka, puteljak);

            //telo
            puteljak.AddBezier(x, y, x - a / 2 - a / 4, y, x - a - a / 2, y - a * 2 / 3, x - a - a / 2, y - a * 2 / 3);//2
            puteljak.AddBezier(x - 5 * a / 2, y, x - 5 * a / 2 + a / 16, y + a / 2, x - 5 * a / 2 + a / 16, y + a, x - 5 * a / 2 - a / 8, y + 2 * a);//4
            puteljak.AddBezier(x - 5 * a / 2 - a / 8, y + 2 * a, x - 2 * a + a / 2, y + 2 * a + a / 2 + a / 3, x - a - a / 2 + a, y + 3 * a - a / 3, x - a / 2 - a / 4, y + 3 * a - a / 8);//7
            puteljak.AddBezier(x - a / 2 - a / 4, y + 3 * a - a / 8 - a / 32, x - a - a / 2, y + 3 * a + a / 8, x - 3 * a / 2, y + 3 * a, x - 4 * a, y + 5 * a);//9
            puteljak.AddBezier(x - 4 * a, y + 5 * a, x - 3 * a - 3 * a / 4 - a / 16, y + 5 * a + a / 8, x - 3 * a - 13 * a / 16, y + 5 * a + a / 16, x - 3 * a - 2 * a / 3 + a / 8, y + 5 * a);
            puteljak.AddBezier(x - 3 * a - 2 * a / 3 + a / 8, y + 5 * a, x - 3 * a - 2 * a / 5, y + 5 * a, x - 3 * a - 3 * a / 3 - a / 16, y + 5 * a + a / 8 + a / 32, x - 4 * a + a / 8 + a / 16, y + 5 * a + a / 4 + a / 16);
            puteljak.AddBezier(x - 4 * a + a / 8 + a / 16, y + 5 * a + a / 4 + a / 16, x - 4 * a + a / 4, y + 5 * a + a / 4 + a / 32, x - 4 * a + a / 2, y + 5 * a + a / 4 - a / 16, x - 3 * a - a / 2, y + 5 * a + a / 4);
            puteljak.AddBezier(x - 3 * a - a / 2, y + 5 * a + a / 4, x - 3 * a - a / 6, y + 5 * a + a / 8, x - 3 * a - a / 3, y + 5 * a, x - 4 * a + a / 4, y + 5 * a + a / 2 - a / 8);
            puteljak.AddBezier(x - 4 * a + a / 4, y + 5 * a + a / 2 - a / 8, x - 4 * a + a / 2, y + 6 * a - a / 2, x - 3 * a - a / 2, y + 5 * a + a / 3, x - 3 * a - a / 32, y + 5 * a + a / 4);
            puteljak.AddLine(x - 3 * a - a / 32, y + 5 * a + a / 4, x - 2 * a - a / 2, y + 6 * a - a / 4);
            puteljak.AddLine(x - 2 * a - a / 2, y + 6 * a - a / 4, x - 2 * a, y + 5 * a + a / 2);
            puteljak.AddBezier(x - 2 * a, y + 5 * a + a / 2, x - 2 * a, y + 6 * a, x - a - 3 * a / 4, y + 7 * a, x - a - a / 4, y + 8 * a - a / 2 - a / 4);
            puteljak.AddBezier(x - a - a / 4, y + 7 * a + a / 4, x - a / 2 - a / 4 - a / 16, y + 8 * a - a / 2, x - a / 2 - a / 4, y + 7 * a, x - a / 2, y + 7 * a - a / 2);//29
            puteljak.AddLine(x - a / 2, y + 7 * a - a / 2, x + a / 2, y + 7 * a - a / 2);//31
            puteljak.AddBezier(x + a / 2, y + 7 * a - a / 2, x + a / 2 + a / 4, y + 7 * a, x + a / 2 + a / 4 + a / 16, y + 8 * a - a / 2, x + a + a / 4, y + 7 * a + a / 4);//30
            puteljak.AddBezier(x + a + a / 4, y + 8 * a - a / 2 - a / 4, x + a + 3 * a / 4, y + 7 * a, x + 2 * a, y + 6 * a, x + 2 * a, y + 5 * a + a / 2);
            puteljak.AddLine(x + 2 * a, y + 6 * a - a / 2, x + 2 * a + a / 8, y + 5 * a + a / 2 + a / 16);
            puteljak.AddLine(x + 2 * a + a / 2, y + 6 * a - a / 4, x + 3 * a + a / 32, y + 5 * a + a / 4);
            puteljak.AddBezier(x + 3 * a + a / 32, y + 5 * a + a / 4, x + 3 * a + a / 2 - a / 4, y + 5 * a + a / 3 - a / 8, x + 4 * a - 3 * a / 4, y + 6 * a - a / 2, x + 4 * a - a / 4, y + 5 * a + a / 2 - a / 8);
            puteljak.AddBezier(x + 4 * a - a / 4, y + 5 * a + a / 2 - a / 8, x + 3 * a + a / 3, y + 5 * a, x + 3 * a + a / 6, y + 5 * a + a / 8, x + 3 * a + a / 2, y + 5 * a + a / 4);
            puteljak.AddBezier(x + 3 * a + a / 2, y + 5 * a + a / 4, x + 4 * a - a / 2, y + 5 * a + a / 4 - a / 16, x + 4 * a - a / 4, y + 5 * a + a / 4 + a / 32, x + 4 * a - a / 8 - a / 16, y + 5 * a + a / 4 + a / 16);
            puteljak.AddBezier(x + 4 * a - a / 8 - a / 16, y + 5 * a + a / 4 + a / 16, x + 3 * a + 3 * a / 3 + a / 16, y + 5 * a + a / 8 + a / 32, x + 3 * a + 2 * a / 5, y + 5 * a, x + 3 * a + 2 * a / 3 - a / 8, y + 5 * a);
            puteljak.AddBezier(x + 3 * a + 2 * a / 3, y + 5 * a, x + 3 * a + 13 * a / 16, y + 5 * a + a / 16, x + 3 * a + 3 * a / 4 + a / 16, y + 5 * a + a / 8, x + 4 * a, y + 5 * a);
            puteljak.AddBezier(x + 4 * a, y + 5 * a, x + 3 * a / 2, y + 3 * a, x + a + a / 2, y + 3 * a + a / 8, x + a / 2 + a / 4, y + 3 * a - a / 8 - a / 32);//10
            puteljak.AddBezier(x + a / 2 + a / 4, y + 3 * a - a / 8, x + a + a / 2 - a, y + 3 * a - a / 3, x + 2 * a - a / 2, y + 2 * a + a / 2 + a / 3, x + 5 * a / 2 + a / 8, y + 2 * a);//8
            puteljak.AddBezier(x + 5 * a / 2 + a / 8, y + 2 * a, x + 5 * a / 2 - a / 16, y + a, x + 5 * a / 2 - a / 16, y + a / 2, x + 5 * a / 2, y);//6
            puteljak.AddLine(x + 5 * a / 2, y, x + 3 * a / 2, y - 2 * a / 3);//3
            puteljak.AddBezier(x + a + a / 2, y - 2 * a / 3, x + a + a / 2, y - 2 * a / 3, x + a / 2 + a / 4, y, x, y);//1

            //glava
            puteljak1.AddBezier(x - 5 * a / 2 - a / 8, y + 2 * a, x - 5 * a / 2 + a / 16, y + a, x - 5 * a / 2 + a / 16, y + a / 2, x - 5 * a / 2, y);
            puteljak1.AddLine(x - 5 * a / 2, y, x - 3 * a / 2, y - 2 * a / 3);
            puteljak1.AddBezier(x - a - a / 2, y - 2 * a / 3, x - a - a / 2, y - 2 * a / 3, x - a / 2 - a / 4, y, x, y);
            puteljak1.AddBezier(x, y, x + a / 2 + a / 4, y, x + a + a / 2, y - 2 * a / 3, x + a + a / 2, y - 2 * a / 3);
            puteljak1.AddLine(x + 3 * a / 2, y - 2 * a / 3, x + 5 * a / 2, y);
            puteljak1.AddBezier(x + 5 * a / 2, y, x + 5 * a / 2 - a / 16, y + a / 2, x + 5 * a / 2 - a / 16, y + a, x + 5 * a / 2 + a / 8, y + 2 * a);

            puteljak1.AddBezier(x + 5 * a / 2 + a / 8, y + a * 2, x + 5 * a / 2 + a / 4 + a / 8, y + 3 * a, x + 3 * a + a / 4, y + 3 * a + a / 2, x + 4 * a - a / 4, y + 3 * a + a / 4 + a / 16 + a / 32);
            puteljak1.AddBezier(x + 4 * a - a / 4, y + 3 * a + a / 4 + a / 16 + a / 32, x + 4 * a + a / 2, y + 3 * a, x + 5 * a - a / 2 - a / 4, y + a + a / 2 + a / 4, x + 4 * a - a / 4 - a / 8, y + 3 * a / 4);
            puteljak1.AddBezier(x + 4 * a - a / 4 - a / 8, y + 3 * a / 4, x + 4 * a - a / 4, y + a - a / 16, x + 4 * a - a / 4, y + a - a / 8, x + 4 * a + a / 32, y + 2 * a - a / 2);
            puteljak1.AddBezier(x + 4 * a + a / 32, y + 2 * a - a / 2, x + 5 * a, y + a + a / 4, x + 7 * a, y + a / 2, x + 7 * a + a / 2, y - a / 4);
            puteljak1.AddBezier(x + 7 * a + a / 2, y - a / 4, x + 7 * a, y - a - a / 2 + a / 4 + a / 8, x + 4 * a, y - 2 * a - a / 2 - a / 4, x + 2 * a + a / 2, y - 3 * a);
            puteljak1.AddBezier(x + 2 * a + a / 2, y - 3 * a, x + 2 * a, y - 5 * a + 2 * a / 3, x + a + a / 4, y - 6 * a + a / 3, x, y - 7 * a + a / 2);

            puteljak1.AddBezier(x, y - 7 * a + a / 2, x - a - a / 4, y - 6 * a + a / 3, x - 2 * a, y - 5 * a + 2 * a / 3, x - 2 * a - a / 2, y - 3 * a);
            puteljak1.AddBezier(x - 2 * a - a / 2, y - 3 * a, x - 4 * a, y - 2 * a - a / 2 - a / 4, x - 7 * a, y - a - a / 2 + a / 4 + a / 8, x - 7 * a - a / 2, y - a / 4);
            puteljak1.AddBezier(x - 7 * a - a / 2, y - a / 4, x - 7 * a, y + a / 2, x - 5 * a, y + a + a / 4, x - 4 * a - a / 32, y + 2 * a - a / 2);
            //puteljak1.AddBezier(x - 4 * a - a / 32, y + 2 * a - a / 2, x - 4 * a + a / 4, y + a - a / 8, x - 4 * a + a / 4, y + a - a / 16,x - 4 * a+a/32, y + 2 * a - a / 2);
            puteljak1.AddBezier(x - 4 * a + a / 4 + a / 8, y + 3 * a / 4, x - 5 * a + a / 2 + a / 4, y + a + a / 2 + a / 4, x - 4 * a - a / 2, y + 3 * a, x - 4 * a + a / 4, y + 3 * a + a / 4 + a / 16 + a / 32);
            puteljak1.AddBezier(x - 4 * a + a / 4, y + 3 * a + a / 4 + a / 16 + a / 32, x - 3 * a - a / 4, y + 3 * a + a / 2, x - 5 * a / 2 - a / 4 - a / 8, y + 3 * a, x - 5 * a / 2 - a / 8, y + a * 2);

            p[0] = new Point(x + 5 * a / 2 + a / 8, y + a * 2);
            p[1] = new Point(x + 5 * a / 2 + a / 4 + a / 8, y + 3 * a);
            p[2] = new Point(x + 3 * a + a / 4, y + 3 * a + a / 2);
            p[3] = new Point(x + 4 * a - a / 4, y + 3 * a + a / 4 + a / 16 + a / 32);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x + 4 * a - a / 4, y + 3 * a + a / 4 + a / 16 + a / 32);
            p[1] = new Point(x + 4 * a + a / 2, y + 3 * a);
            p[2] = new Point(x + 5 * a - a / 2 - a / 4, y + a + a / 2 + a / 4);
            p[3] = new Point(x + 4 * a - a / 4 - a / 8, y + 3 * a / 4);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x + 4 * a - a / 4 - a / 8, y + 3 * a / 4);
            p[1] = new Point(x + 4 * a - a / 4, y + a - a / 16);
            p[2] = new Point(x + 4 * a - a / 4, y + a - a / 8);
            p[3] = new Point(x + 4 * a + a / 32, y + 2 * a - a / 2);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x + 4 * a + a / 32, y + 2 * a - a / 2);
            p[1] = new Point(x + 5 * a, y + a + a / 4);
            p[2] = new Point(x + 7 * a, y + a / 2);
            p[3] = new Point(x + 7 * a + a / 2, y - a / 4);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x + 7 * a + a / 2, y - a / 4);
            p[1] = new Point(x + 7 * a, y - a - a / 2 + a / 4 + a / 8);
            p[2] = new Point(x + 4 * a, y - 2 * a - a / 2 - a / 4);
            p[3] = new Point(x + 3 * a, y - 3 * a);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x + 3 * a, y - 3 * a);
            p[1] = new Point(x + 2 * a + a / 4, y - 5 * a + 2 * a / 3);
            p[2] = new Point(x + a + a / 2, y - 6 * a + a / 3);
            p[3] = new Point(x, y - 7 * a);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);

            //levo krilo
            puteljak2.AddBezier(x, y + 3 * a - a / 2, x - 2 * a, y + 3 * a + a / 2 - a / 8, x - 4 * a, y + 4 * a + a / 2 - a / 4, x - 7 * a - a / 4, y + 4 * a + a / 2 - a / 8);
            puteljak2.AddBezier(x - 7 * a - a / 4, y + 4 * a + a / 2 - a / 8, x - 8 * a + a / 2 - a / 8, y + 4 * a + a / 2 - a / 8, x - 8 * a - 3 * a / 4, y + 5 * a + a / 8, x - 9 * a, y + 5 * a + a / 4);
            puteljak2.AddBezier(x - 9 * a, y + 5 * a + a / 4, x - 9 * a + a / 16, y + 5 * a + a / 2 - a / 8 - a / 16, x - 9 * a + a / 16, y + 5 * a + a / 2 - a / 8 - a / 16, x - 8 * a - a / 4, y + 5 * a + a / 4 + a / 16);
            puteljak2.AddBezier(x - 8 * a - a / 4, y + 5 * a + a / 4 + a / 16, x - 7 * a - a / 2, y + 6 * a + a / 2, x - 6 * a - a / 4, y + 6 * a, x - 6 * a + a / 4, y + 6 * a - a / 4 - a / 8);
            puteljak2.AddBezier(x - 6 * a + a / 4, y + 6 * a - a / 4 - a / 8, x - 5 * a - a / 4, y + 6 * a - a / 2, x - 5 * a + a / 4, y + 6 * a + a / 2, x - 4 * a + a / 2, y + 5 * a);
            puteljak2.AddLine(x - 4 * a + a / 2, y + 5 * a, x, y + 3 * a - a / 2);
            //desno krilo
            puteljak22.AddBezier(x, y + 3 * a - a / 2, x + 2 * a, y + 3 * a + a / 2 - a / 8, x + 4 * a, y + 4 * a + a / 2 - a / 4, x + 7 * a + a / 4, y + 4 * a + a / 2 - a / 8);
            puteljak22.AddBezier(x + 7 * a + a / 4, y + 4 * a + a / 2 - a / 8, x + 8 * a - a / 2 + a / 8, y + 4 * a + a / 2 - a / 8, x + 8 * a + 3 * a / 4, y + 5 * a + a / 8, x + 9 * a, y + 5 * a + a / 4);
            puteljak22.AddBezier(x + 9 * a, y + 5 * a + a / 4, x + 9 * a - a / 16, y + 5 * a + a / 2 - a / 8 - a / 16, x + 9 * a - a / 16, y + 5 * a + a / 2 - a / 8 - a / 16, x + 8 * a + a / 4, y + 5 * a + a / 4 + a / 16);
            puteljak22.AddBezier(x + 8 * a + a / 4, y + 5 * a + a / 4 + a / 16, x + 7 * a + a / 2, y + 6 * a + a / 2, x + 6 * a + a / 4, y + 6 * a, x + 6 * a - a / 4, y + 6 * a - a / 4 - a / 8);
            puteljak22.AddBezier(x + 6 * a - a / 4, y + 6 * a - a / 4 - a / 8, x + 5 * a + a / 4, y + 6 * a - a / 2, x + 5 * a - a / 4, y + 6 * a + a / 2, x + 4 * a - a / 2, y + 5 * a);
            puteljak22.AddLine(x + 4 * a - a / 2, y + 5 * a, x, y + 3 * a - a / 2);

            olovka.Width = a / 15;
            g.FillPath(cetka4, puteljak2);
            g.DrawPath(olovka, puteljak2);
            g.FillPath(cetka4, puteljak22);
            g.DrawPath(olovka, puteljak22);
            g.FillPath(cetka, puteljak);
            g.FillPath(cetka1, puteljak1);
            g.DrawPath(olovka, puteljak);
            g.DrawPath(olovka, puteljak1);

            p[0] = new Point(x - 2 * a, y + 5 * a + a / 2);
            p[1] = new Point(x - 2 * a, y + 5 * a);
            p[2] = new Point(x - a - 3 * a / 4, y + 4 * a);
            p[3] = new Point(x - a - a / 4, y + 4 * a - a / 2);
            //levi gornji trup 25
            g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x + 2 * a, y + 5 * a + a / 2);
            p[1] = new Point(x + 2 * a, y + 5 * a);
            p[2] = new Point(x + a + 3 * a / 4, y + 4 * a);
            p[3] = new Point(x + a + a / 4, y + 4 * a - a / 2);
            //desni gornji trup 26
            g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);

            cetka4.Color = Color.FromArgb(118, 211, 176);
            p[0] = new Point(x - a - a / 2, y + a + a / 2 + a / 4);
            p[1] = new Point(x - a - a / 4, y + a + a / 8);
            p[2] = new Point(x - a - 3 * a / 4, y + a + a / 8);
            p[3] = new Point(x - a - 3 * a / 4, y + a + a / 8);
            g.FillClosedCurve(cetka4, p);

            p[0] = new Point(x + a + a / 2, y + a + a / 2 + a / 4);
            p[1] = new Point(x + a + a / 4, y + a + a / 8);
            p[2] = new Point(x + a + 3 * a / 4, y + a + a / 8);
            p[3] = new Point(x + a + 3 * a / 4, y + a + a / 8);
            g.FillClosedCurve(cetka4, p);

            olovka.Width = a / 15;

            g.FillEllipse(cetka2, x - 2 * a, y - a / 16, a, 4 * a / 3);
            g.FillEllipse(cetka2, x + a, y - a / 16, a, 4 * a / 3);

            cetka2.Color = Color.FromArgb(80, Color.White);

            g.FillEllipse(cetka2, x - 2 * a + a / 4 - a / 32 - a / 64, y + a / 4, a / 2 + a / 16 + a / 32, 3 * a / 4);
            g.FillEllipse(cetka2, x + a + a / 4 - a / 32 - a / 64, y + a / 4, a / 2 + a / 16 + a / 32, 3 * a / 4);

            g.FillEllipse(cetka2, x - 2 * a + a / 4 + a / 8 - a / 32, y + a / 4 + a / 8, a / 3, a / 2);
            g.FillEllipse(cetka2, x + a + a / 4 + a / 8 - a / 32, y + a / 4 + a / 8, a / 3, a / 2);

            cetka2.Color = Color.White;

            olovka.Width = a / 25;
            g.FillEllipse(cetka2, x - 2 * a + a / 4 + a / 32, y, a / 2, a / 2);
            g.DrawEllipse(olovka, x - 2 * a + a / 4 + a / 32, y, a / 2, a / 2);

            g.FillEllipse(cetka2, x + a + a / 4 + a / 32, y, a / 2, a / 2);
            g.DrawEllipse(olovka, x + a + a / 4 + a / 32, y, a / 2, a / 2);



            //usta
            olovka.Width = a / 15;
            p[0] = new Point(x, y + 2 * a - a / 8);
            p[1] = new Point(x - a / 2 - a / 8, y + 2 * a - a / 8);
            p[2] = new Point(x - a / 2 - a / 8, y + 2 * a - a / 8);
            p[3] = new Point(x - 3 * a / 4, y + 2 * a - a / 8 - a / 8);
            g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x, y + 2 * a - a / 8);
            p[1] = new Point(x + a / 2 + a / 8, y + 2 * a - a / 8);
            p[2] = new Point(x + a / 2 + a / 8, y + 2 * a - a / 8);
            p[3] = new Point(x + 3 * a / 4, y + 2 * a - a / 8 - a / 8);
            g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);

            //polukrug na stomaku
            olovka.Width = a / 10;
            p[0] = new Point(x, y + 5 * a + a / 2);
            p[1] = new Point(x - a / 2, y + 5 * a + a / 2);
            p[2] = new Point(x - a, y + 5 * a + a / 4 + a / 8);
            p[3] = new Point(x - a - a / 4, y + 5 * a - a / 4);
            g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            p[0] = new Point(x, y + 5 * a + a / 2);
            p[1] = new Point(x + a / 2, y + 5 * a + a / 2);
            p[2] = new Point(x + a, y + 5 * a + a / 4 + a / 8);
            p[3] = new Point(x + a + a / 4, y + 5 * a - a / 4);
            g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);

            olovka.Width = a / 15;

            //gornji papir
            g.FillRectangle(cetka3, x - a / 2 - a / 16, y - 6 * a + a / 4 + a / 8, a + a / 8, 7 * a / 2);
            g.DrawRectangle(olovka, x - a / 2 - a / 16, y - 6 * a + a / 4 + a / 8, a + a / 8, 7 * a / 2);

            //desni papir
            p[0] = new Point(x + 7 * a - a / 4, y);
            p[1] = new Point(x + 8 * a - a / 4, y + a / 32);
            p[2] = new Point(x + 8 * a + a / 8 - a / 4, y + 3 * a + a / 2 + a / 32);
            p[3] = new Point(x + 7 * a + a / 8 - a / 4, y + 3 * a + a / 2 + a / 16);

            g.FillPolygon(cetka3, p);
            g.DrawPolygon(olovka, p);

            //levi papir
            p[0] = new Point(x - 7 * a + a / 4 + a / 8, y + a / 16);
            p[1] = new Point(x - 8 * a + a / 4 + a / 8, y + a / 32 + a / 16);
            p[2] = new Point(x - 8 * a + a / 4, y + 3 * a + a / 2 + a / 32 + a / 16);
            p[3] = new Point(x - 7 * a + a / 4, y + 3 * a + a / 2 + a / 8);

            g.FillPolygon(cetka3, p);
            g.DrawPolygon(olovka, p);

            //levo krilo
            p[0] = new Point(x, y + 3 * a - a / 2);
            p[1] = new Point(x - 2 * a, y + 3 * a + a / 2 - a / 8);
            p[2] = new Point(x - 4 * a, y + 4 * a + a / 2 - a / 4);
            p[3] = new Point(x - 7 * a - a / 4, y + 4 * a + a / 2 - a / 8);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);

            p[0] = new Point(x - 7 * a - a / 4, y + 4 * a + a / 2 - a / 8);
            p[1] = new Point(x - 8 * a + a / 2 - a / 8, y + 4 * a + a / 2 - a / 8);
            p[2] = new Point(x - 8 * a - 3 * a / 4, y + 5 * a + a / 8);
            p[3] = new Point(x - 9 * a, y + 5 * a + a / 4);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);

            p[0] = new Point(x - 9 * a, y + 5 * a + a / 4);
            p[1] = new Point(x - 9 * a + a / 16, y + 5 * a + a / 2 - a / 8 - a / 16);
            p[2] = new Point(x - 9 * a + a / 16, y + 5 * a + a / 2 - a / 8 - a / 16);
            p[3] = new Point(x - 8 * a - a / 4, y + 5 * a + a / 4 + a / 16);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);

            p[0] = new Point(x - 8 * a - a / 4, y + 5 * a + a / 4 + a / 16);
            p[1] = new Point(x - 7 * a - a / 2, y + 6 * a + a / 2);
            p[2] = new Point(x - 6 * a - a / 4, y + 6 * a);
            p[3] = new Point(x - 6 * a + a / 4, y + 6 * a - a / 4 - a / 8);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);

            p[0] = new Point(x - 6 * a + a / 4, y + 6 * a - a / 4 - a / 8);
            p[1] = new Point(x - 5 * a - a / 4, y + 6 * a - a / 2);
            p[2] = new Point(x - 5 * a + a / 4, y + 6 * a + a / 2);
            p[3] = new Point(x - 4 * a + a / 2, y + 5 * a);

            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            //g.DrawLine(olovka, x - 4 * a + a / 2, y + 5 * a, x, y + 3 * a - a / 2);

            //desno krilo
            p[0] = new Point(x, y + 3 * a - a / 2);
            p[1] = new Point(x + 2 * a, y + 3 * a + a / 2 - a / 8);
            p[2] = new Point(x + 4 * a, y + 4 * a + a / 2 - a / 4);
            p[3] = new Point(x + 7 * a + a / 4, y + 4 * a + a / 2 - a / 8);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);

            p[0] = new Point(x + 7 * a + a / 4, y + 4 * a + a / 2 - a / 8);
            p[1] = new Point(x + 8 * a - a / 2 + a / 8, y + 4 * a + a / 2 - a / 8);
            p[2] = new Point(x + 8 * a + 3 * a / 4, y + 5 * a + a / 8);
            p[3] = new Point(x + 9 * a, y + 5 * a + a / 4);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);

            p[0] = new Point(x + 9 * a, y + 5 * a + a / 4);
            p[1] = new Point(x + 9 * a - a / 16, y + 5 * a + a / 2 - a / 8 - a / 16);
            p[2] = new Point(x + 9 * a - a / 16, y + 5 * a + a / 2 - a / 8 - a / 16);
            p[3] = new Point(x + 8 * a + a / 4, y + 5 * a + a / 4 + a / 16);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);

            p[0] = new Point(x + 8 * a + a / 4, y + 5 * a + a / 4 + a / 16);
            p[1] = new Point(x + 7 * a + a / 2, y + 6 * a + a / 2);
            p[2] = new Point(x + 6 * a + a / 4, y + 6 * a);
            p[3] = new Point(x + 6 * a - a / 4, y + 6 * a - a / 4 - a / 8);
            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);

            p[0] = new Point(x + 6 * a - a / 4, y + 6 * a - a / 4 - a / 8);
            p[1] = new Point(x + 5 * a + a / 4, y + 6 * a - a / 2);
            p[2] = new Point(x + 5 * a - a / 4, y + 6 * a + a / 2);
            p[3] = new Point(x + 4 * a - a / 2, y + 5 * a);

            //g.DrawBezier(olovka, p[0], p[1], p[2], p[3]);
            //g.DrawLine(olovka, x + 4 * a - a / 2, y + 5 * a, x, y + 3 * a - a / 2);
        }
    }
}
