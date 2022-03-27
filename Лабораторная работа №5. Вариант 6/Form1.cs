using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__5.Вариант_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            a++;
            int x = e.X;
            int y = e.Y;
            if (a % 2 == 0)
            {
                Button b = new Button();
                b.Parent = this;
                b.Location = new Point(x, y);
            }
            else
            {
                TextBox tb=new TextBox();
                tb.Parent = this;
                tb.Location = new Point(x-tb.Width, y-tb.Height);
            }
        }
    }
}
