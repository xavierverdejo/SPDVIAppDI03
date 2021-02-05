﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPDVILibDI03.Helpers;
using SPDVILibDI03.Classes;
using System.IO;

namespace SPDVILibDI03
{
    public partial class UserControl1 : UserControl
    {
        ProductModel pm;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            loadProduct(ConnectionHelper.getRandomId());
        } 
        private void imageBox_Click(object sender, EventArgs e)
        {
            loadProduct(ConnectionHelper.getRandomId());
        }

        private void loadProduct(int id)
        {
            pm = ConnectionHelper.getProductModel(id);
            nameTextBox.Text = pm.Name;
            showImage(pm);
            showSizes(pm);
        }

        private void showSizes(ProductModel pm)
        {
            //EXEC uspGetProductSizes 11
        }

        private void showImage(ProductModel pm)
        {
            byte[] productPhoto = pm.LargePhoto;
            MemoryStream ms = new MemoryStream(productPhoto);
            Image productImage = Image.FromStream(ms);
            
            imageBox.Image = productImage;
        }


    }
}