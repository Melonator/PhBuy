using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace PhBuy
{
    public partial class CustomerBrowser : Form
    {
        public CustomerBrowser()
        {
            InitializeComponent();
        }

        public void LoadElementIo(string sellerName)
        {
            var browser = new ChromiumWebBrowser($"https://app.element.io/#/room/#{sellerName}:matrix.org");
            Controls.Add(browser);
        }
    }
}
