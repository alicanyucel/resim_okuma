using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronOcr;
using System.Windows.Forms;

namespace ıronoct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          /*  var Result = new IronTesseract().Read(@"C:\ab.jpg");
            MessageBox.Show(Result.Text);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var Result = new IronTesseract().Read(@"C:\ab.png");
            richTextBox1.Text = Result.Text;
        }
    }
}
