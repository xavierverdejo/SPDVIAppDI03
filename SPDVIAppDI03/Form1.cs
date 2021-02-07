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
        bool darkMode;
        public Form1()
        {
            InitializeComponent();
            userControl11.sizeClicked += sizeButtonClicked;
            userControl11.darkModeChanged += darkModeChanged;
            darkMode = false;
        }

        private void sizeButtonClicked(object sender, SizeClickedEventArgs e)
        {
            textBox1.Text = e.getId;
        }

        private void darkModeChanged(object sender, DarkModeChangedEventArgs e)
        {
            if (e.getDarkMode)
            {
                this.BackColor = Color.FromArgb(64, 64, 64);
                this.ForeColor = Color.FromArgb(0, 120, 212);
                groupBox1.ForeColor = Color.FromArgb(0, 120, 212);
            }
            else
            {
                this.BackColor = SystemColors.Menu;
                this.ForeColor = Color.Black;
                groupBox1.ForeColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
