using SPDVILibDI03.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDVIAppDI03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControl11.sizeClicked += sizeButtonClicked;
        }

        private void sizeButtonClicked(object sender, SizeClickedEventArgs e)
        {
            textBox1.Text = e.getId;
        }
    }
}
