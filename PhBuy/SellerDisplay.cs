using System;
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
    public partial class SellerDisplay : UserControl
    {
        public SellerDisplay()
        {
            InitializeComponent();
        }

        public void SetTypes(string[] types)
        {
            foreach(var t in types)
            {
                if (t == "Health & Beauty") typesPanel.Controls["Health"].Visible = true;
                else typesPanel.Controls[t].Visible = true;
            }
        }
    }
}
