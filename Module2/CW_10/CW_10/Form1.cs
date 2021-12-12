using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void initbutton1_click(object sender, EventArgs e)
        {
            button1.Text = "Уменьшить форму";
        }

        Rate rate = new Rate();
        int mode = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Anchor = AnchorStyles.None;
            this.Size = new Size(200, 30);
            if (mode == 1)
            {
                if (this.Size.Width * 2 < this.MaximumSize.Width && this.Size.Height * 2 < this.MaximumSize.Height)
                {
                    this.Size = new Size(this.Size.Width * 2, this.Size.Height * 2);
                }
                else
                {
                    mode = 2;
                    button1.Text = "уменьшить";
                }
            }
            else
            {
                if (this.Size.Width / 2 > this.MaximumSize.Width && this.Size.Height / 2 > this.MaximumSize.Height)
                {
                    this.Size = new Size(this.Size.Width / 2, this.Size.Height / 2);
                }
                else
                {
                    mode = 1;
                    button1.Text = "увеличить";
                }
            }
            */
            rate.Hits += 1;
            label2.Text = rate.Hits.ToString();
        }

        private void form1_MouseClick(object sender, EventArgs e)
        {
            rate.Fails += 1;
            label1.Text = rate.Fails.ToString();
        }
    }

    class Rate
    {
        public uint Hits { get; set; }
        public uint Fails { get; set; }
    }
}
