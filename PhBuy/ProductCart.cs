﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhBuy
{
    public partial class ProductCart : UserControl
    {
        public string Seller { get; set; }
        public int Stock;
        public ProductCart()
        {
            InitializeComponent();
        }
    }
}
