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
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            //Load the dropdown contents based on the tables on the database
            /*tableDropDown.Items.Add("TableName")*/
        }

        private void tableDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load the table here once the user selects something in the dropdown
        }
    }
}
