
namespace PhBuy
{
    partial class DataAnalytics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataAnalytics));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.datePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.generalChart = new LiveCharts.WinForms.CartesianChart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sales = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuShapes1 = new Bunifu.UI.WinForms.BunifuShapes();
            this.label3 = new System.Windows.Forms.Label();
            this.orders = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuShapes2 = new Bunifu.UI.WinForms.BunifuShapes();
            this.label4 = new System.Windows.Forms.Label();
            this.viewDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sales.SuspendLayout();
            this.orders.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 63);
            this.panel1.TabIndex = 1;
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.Color.Transparent;
            this.datePicker.BorderRadius = 1;
            this.datePicker.Color = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.datePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.datePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.datePicker.DisabledColor = System.Drawing.Color.Gray;
            this.datePicker.DisplayWeekNumbers = false;
            this.datePicker.DPHeight = 0;
            this.datePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePicker.FillDatePicker = false;
            this.datePicker.Font = new System.Drawing.Font("Mulish", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.datePicker.Icon = ((System.Drawing.Image)(resources.GetObject("datePicker.Icon")));
            this.datePicker.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.datePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.datePicker.LeftTextMargin = 5;
            this.datePicker.Location = new System.Drawing.Point(616, 15);
            this.datePicker.MinimumSize = new System.Drawing.Size(4, 32);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(260, 32);
            this.datePicker.TabIndex = 2;
            this.datePicker.Value = new System.DateTime(2020, 12, 12, 16, 7, 0, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.bunifuDatePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mulish", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(83, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Analytics";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PhBuy.Properties.Resources.line_chart_480px;
            this.pictureBox1.Location = new System.Drawing.Point(15, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // generalChart
            // 
            this.generalChart.BackColor = System.Drawing.Color.White;
            this.generalChart.Location = new System.Drawing.Point(28, 127);
            this.generalChart.Name = "generalChart";
            this.generalChart.Size = new System.Drawing.Size(847, 348);
            this.generalChart.TabIndex = 0;
            this.generalChart.Text = "cartesianChart1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(28, 540);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 432);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mulish", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(22, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "TOP 10 PRODUCTS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(459, 540);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 432);
            this.panel3.TabIndex = 2;
            // 
            // sales
            // 
            this.sales.BackgroundColor = System.Drawing.Color.White;
            this.sales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sales.BackgroundImage")));
            this.sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sales.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.sales.BorderRadius = 3;
            this.sales.BorderThickness = 1;
            this.sales.Controls.Add(this.bunifuShapes1);
            this.sales.Controls.Add(this.label3);
            this.sales.Location = new System.Drawing.Point(28, 84);
            this.sales.Name = "sales";
            this.sales.ShowBorders = true;
            this.sales.Size = new System.Drawing.Size(200, 37);
            this.sales.TabIndex = 3;
            this.sales.Click += new System.EventHandler(this.filter_Click);
            // 
            // bunifuShapes1
            // 
            this.bunifuShapes1.Angle = 0F;
            this.bunifuShapes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(68)))));
            this.bunifuShapes1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(68)))));
            this.bunifuShapes1.BorderThickness = 2;
            this.bunifuShapes1.FillColor = System.Drawing.Color.Transparent;
            this.bunifuShapes1.FillShape = true;
            this.bunifuShapes1.Location = new System.Drawing.Point(7, 8);
            this.bunifuShapes1.Name = "bunifuShapes1";
            this.bunifuShapes1.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Square;
            this.bunifuShapes1.Sides = 5;
            this.bunifuShapes1.Size = new System.Drawing.Size(22, 22);
            this.bunifuShapes1.TabIndex = 4;
            this.bunifuShapes1.Text = "bunifuShapes1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mulish", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(35, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sales";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orders
            // 
            this.orders.BackgroundColor = System.Drawing.Color.White;
            this.orders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orders.BackgroundImage")));
            this.orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orders.BorderColor = System.Drawing.Color.Transparent;
            this.orders.BorderRadius = 3;
            this.orders.BorderThickness = 1;
            this.orders.Controls.Add(this.bunifuShapes2);
            this.orders.Controls.Add(this.label4);
            this.orders.Location = new System.Drawing.Point(262, 84);
            this.orders.Name = "orders";
            this.orders.ShowBorders = true;
            this.orders.Size = new System.Drawing.Size(200, 37);
            this.orders.TabIndex = 3;
            this.orders.Click += new System.EventHandler(this.filter_Click);
            // 
            // bunifuShapes2
            // 
            this.bunifuShapes2.Angle = 0F;
            this.bunifuShapes2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.bunifuShapes2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.bunifuShapes2.BorderThickness = 2;
            this.bunifuShapes2.FillColor = System.Drawing.Color.Transparent;
            this.bunifuShapes2.FillShape = true;
            this.bunifuShapes2.Location = new System.Drawing.Point(8, 8);
            this.bunifuShapes2.Name = "bunifuShapes2";
            this.bunifuShapes2.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Square;
            this.bunifuShapes2.Sides = 5;
            this.bunifuShapes2.Size = new System.Drawing.Size(22, 22);
            this.bunifuShapes2.TabIndex = 4;
            this.bunifuShapes2.Text = "bunifuShapes1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mulish", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(36, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Orders";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewDropDown
            // 
            this.viewDropDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.viewDropDown.BackgroundColor = System.Drawing.Color.White;
            this.viewDropDown.BorderColor = System.Drawing.Color.Silver;
            this.viewDropDown.BorderRadius = 1;
            this.viewDropDown.Color = System.Drawing.Color.Silver;
            this.viewDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.viewDropDown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.viewDropDown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.viewDropDown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.viewDropDown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.viewDropDown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.viewDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.viewDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.viewDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.viewDropDown.FillDropDown = true;
            this.viewDropDown.FillIndicator = false;
            this.viewDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewDropDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewDropDown.ForeColor = System.Drawing.Color.Black;
            this.viewDropDown.FormattingEnabled = true;
            this.viewDropDown.Icon = null;
            this.viewDropDown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.viewDropDown.IndicatorColor = System.Drawing.Color.Gray;
            this.viewDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.viewDropDown.ItemBackColor = System.Drawing.Color.White;
            this.viewDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.viewDropDown.ItemForeColor = System.Drawing.Color.Black;
            this.viewDropDown.ItemHeight = 26;
            this.viewDropDown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.viewDropDown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.viewDropDown.ItemTopMargin = 3;
            this.viewDropDown.Location = new System.Drawing.Point(615, 89);
            this.viewDropDown.Name = "viewDropDown";
            this.viewDropDown.Size = new System.Drawing.Size(260, 32);
            this.viewDropDown.TabIndex = 3;
            this.viewDropDown.Text = null;
            this.viewDropDown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.viewDropDown.TextLeftMargin = 5;
            this.viewDropDown.SelectedIndexChanged += new System.EventHandler(this.viewDropDown_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mulish", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(544, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "View";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(909, 999);
            this.Controls.Add(this.viewDropDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.generalChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataAnalytics";
            this.Text = "DataAnalytics";
            this.Load += new System.EventHandler(this.DataAnalytics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sales.ResumeLayout(false);
            this.sales.PerformLayout();
            this.orders.ResumeLayout(false);
            this.orders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDatePicker datePicker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.CartesianChart generalChart;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuPanel orders;
        private Bunifu.UI.WinForms.BunifuPanel sales;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes1;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes2;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuDropdown viewDropDown;
        private System.Windows.Forms.Label label5;
    }
}