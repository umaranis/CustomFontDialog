using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form1 : Form
    {
        CustomFontDialog.FontDialog f;

        public Form1()
        {
            InitializeComponent();
            
            f = new CustomFontDialog.FontDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.AddFontToRecentList(FontFamily.GenericSansSerif);
            f.AddFontToRecentList(FontFamily.GenericSerif);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f.Font = this.Font;
        }
    }
}
