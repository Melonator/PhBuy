
namespace PhBuy
{
    partial class MyOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyOrders));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ConfirmedSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.DeliveredSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.ProcessingSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.AllSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.Delivered = new System.Windows.Forms.Label();
            this.Confirmed = new System.Windows.Forms.Label();
            this.Processing = new System.Windows.Forms.Label();
            this.All = new System.Windows.Forms.Label();
            this.ordersFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sortDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datePickerStart = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.datePickerEnd = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.orderPanel1 = new PhBuy.OrderPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.ordersFlowLayoutPanel.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 68);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhBuy.Properties.Resources.shopping_basket_208px;
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Mulish", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.userNameLabel.Location = new System.Drawing.Point(71, 16);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(160, 40);
            this.userNameLabel.TabIndex = 9;
            this.userNameLabel.Text = "My Orders";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ConfirmedSeparator);
            this.panel2.Controls.Add(this.DeliveredSeparator);
            this.panel2.Controls.Add(this.ProcessingSeparator);
            this.panel2.Controls.Add(this.AllSeparator);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.Delivered);
            this.panel2.Controls.Add(this.Confirmed);
            this.panel2.Controls.Add(this.Processing);
            this.panel2.Controls.Add(this.All);
            this.panel2.Location = new System.Drawing.Point(1, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 54);
            this.panel2.TabIndex = 0;
            // 
            // ConfirmedSeparator
            // 
            this.ConfirmedSeparator.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmedSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConfirmedSeparator.BackgroundImage")));
            this.ConfirmedSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfirmedSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.ConfirmedSeparator.LineColor = System.Drawing.Color.DarkGray;
            this.ConfirmedSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.ConfirmedSeparator.LineThickness = 1;
            this.ConfirmedSeparator.Location = new System.Drawing.Point(472, 46);
            this.ConfirmedSeparator.Name = "ConfirmedSeparator";
            this.ConfirmedSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.ConfirmedSeparator.Size = new System.Drawing.Size(151, 14);
            this.ConfirmedSeparator.TabIndex = 0;
            // 
            // DeliveredSeparator
            // 
            this.DeliveredSeparator.BackColor = System.Drawing.Color.Transparent;
            this.DeliveredSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeliveredSeparator.BackgroundImage")));
            this.DeliveredSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeliveredSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.DeliveredSeparator.LineColor = System.Drawing.Color.DarkGray;
            this.DeliveredSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.DeliveredSeparator.LineThickness = 1;
            this.DeliveredSeparator.Location = new System.Drawing.Point(731, 46);
            this.DeliveredSeparator.Name = "DeliveredSeparator";
            this.DeliveredSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.DeliveredSeparator.Size = new System.Drawing.Size(151, 14);
            this.DeliveredSeparator.TabIndex = 0;
            // 
            // ProcessingSeparator
            // 
            this.ProcessingSeparator.BackColor = System.Drawing.Color.Transparent;
            this.ProcessingSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProcessingSeparator.BackgroundImage")));
            this.ProcessingSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProcessingSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.ProcessingSeparator.LineColor = System.Drawing.Color.DarkGray;
            this.ProcessingSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.ProcessingSeparator.LineThickness = 1;
            this.ProcessingSeparator.Location = new System.Drawing.Point(195, 46);
            this.ProcessingSeparator.Name = "ProcessingSeparator";
            this.ProcessingSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.ProcessingSeparator.Size = new System.Drawing.Size(163, 14);
            this.ProcessingSeparator.TabIndex = 0;
            // 
            // AllSeparator
            // 
            this.AllSeparator.BackColor = System.Drawing.Color.Transparent;
            this.AllSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AllSeparator.BackgroundImage")));
            this.AllSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AllSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.AllSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.AllSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.AllSeparator.LineThickness = 2;
            this.AllSeparator.Location = new System.Drawing.Point(62, 46);
            this.AllSeparator.Name = "AllSeparator";
            this.AllSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.AllSeparator.Size = new System.Drawing.Size(52, 14);
            this.AllSeparator.TabIndex = 0;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DarkGray;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 46);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(922, 14);
            this.bunifuSeparator1.TabIndex = 1;
            // 
            // Delivered
            // 
            this.Delivered.AutoSize = true;
            this.Delivered.BackColor = System.Drawing.Color.Transparent;
            this.Delivered.Font = new System.Drawing.Font("Mulish SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delivered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.Delivered.Location = new System.Drawing.Point(749, 12);
            this.Delivered.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Delivered.Name = "Delivered";
            this.Delivered.Size = new System.Drawing.Size(121, 33);
            this.Delivered.TabIndex = 9;
            this.Delivered.Text = "Delivered";
            this.Delivered.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delivered.Click += new System.EventHandler(this.category_Click);
            // 
            // Confirmed
            // 
            this.Confirmed.AutoSize = true;
            this.Confirmed.BackColor = System.Drawing.Color.Transparent;
            this.Confirmed.Font = new System.Drawing.Font("Mulish SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.Confirmed.Location = new System.Drawing.Point(477, 12);
            this.Confirmed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Confirmed.Name = "Confirmed";
            this.Confirmed.Size = new System.Drawing.Size(131, 33);
            this.Confirmed.TabIndex = 9;
            this.Confirmed.Text = "Confirmed";
            this.Confirmed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Confirmed.Click += new System.EventHandler(this.category_Click);
            // 
            // Processing
            // 
            this.Processing.AutoSize = true;
            this.Processing.BackColor = System.Drawing.Color.Transparent;
            this.Processing.Font = new System.Drawing.Font("Mulish SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Processing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.Processing.Location = new System.Drawing.Point(208, 12);
            this.Processing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Processing.Name = "Processing";
            this.Processing.Size = new System.Drawing.Size(138, 33);
            this.Processing.TabIndex = 9;
            this.Processing.Text = "Processing";
            this.Processing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Processing.Click += new System.EventHandler(this.category_Click);
            // 
            // All
            // 
            this.All.AutoSize = true;
            this.All.BackColor = System.Drawing.Color.Transparent;
            this.All.Font = new System.Drawing.Font("Mulish SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.All.Location = new System.Drawing.Point(66, 12);
            this.All.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(45, 33);
            this.All.TabIndex = 9;
            this.All.Text = "All";
            this.All.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.All.Click += new System.EventHandler(this.category_Click);
            // 
            // ordersFlowLayoutPanel
            // 
            this.ordersFlowLayoutPanel.Controls.Add(this.orderPanel1);
            this.ordersFlowLayoutPanel.Location = new System.Drawing.Point(1, 241);
            this.ordersFlowLayoutPanel.Name = "ordersFlowLayoutPanel";
            this.ordersFlowLayoutPanel.Size = new System.Drawing.Size(928, 342);
            this.ordersFlowLayoutPanel.TabIndex = 1;
            // 
            // sortDropDown
            // 
            this.sortDropDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sortDropDown.BackgroundColor = System.Drawing.Color.White;
            this.sortDropDown.BorderColor = System.Drawing.Color.Silver;
            this.sortDropDown.BorderRadius = 1;
            this.sortDropDown.Color = System.Drawing.Color.Silver;
            this.sortDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.sortDropDown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sortDropDown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sortDropDown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sortDropDown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sortDropDown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.sortDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sortDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.sortDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.sortDropDown.FillDropDown = true;
            this.sortDropDown.FillIndicator = false;
            this.sortDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortDropDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sortDropDown.ForeColor = System.Drawing.Color.Black;
            this.sortDropDown.FormattingEnabled = true;
            this.sortDropDown.Icon = null;
            this.sortDropDown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.sortDropDown.IndicatorColor = System.Drawing.Color.Gray;
            this.sortDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.sortDropDown.ItemBackColor = System.Drawing.Color.White;
            this.sortDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.sortDropDown.ItemForeColor = System.Drawing.Color.Black;
            this.sortDropDown.ItemHeight = 26;
            this.sortDropDown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.sortDropDown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.sortDropDown.Items.AddRange(new object[] {
            "Date: New to Old",
            "Date: Old to New",
            "Total: High to Low",
            "Total: Low to High"});
            this.sortDropDown.ItemTopMargin = 3;
            this.sortDropDown.Location = new System.Drawing.Point(66, 160);
            this.sortDropDown.Name = "sortDropDown";
            this.sortDropDown.Size = new System.Drawing.Size(234, 32);
            this.sortDropDown.TabIndex = 2;
            this.sortDropDown.Text = "Date: New to Old";
            this.sortDropDown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.sortDropDown.TextLeftMargin = 5;
            this.sortDropDown.SelectedIndexChanged += new System.EventHandler(this.sortDropDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(11, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sort";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(342, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Order Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(-27, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 36);
            this.panel3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Mulish", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(636, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mulish", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(495, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mulish", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(252, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Customer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mulish", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(44, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datePickerStart
            // 
            this.datePickerStart.BackColor = System.Drawing.Color.Transparent;
            this.datePickerStart.BorderRadius = 1;
            this.datePickerStart.CalendarFont = new System.Drawing.Font("Mulish", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.datePickerStart.CalendarMonthBackground = System.Drawing.Color.White;
            this.datePickerStart.Color = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.datePickerStart.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.datePickerStart.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.datePickerStart.DisabledColor = System.Drawing.Color.Gray;
            this.datePickerStart.DisplayWeekNumbers = false;
            this.datePickerStart.DPHeight = 0;
            this.datePickerStart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePickerStart.FillDatePicker = false;
            this.datePickerStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePickerStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.datePickerStart.Icon = ((System.Drawing.Image)(resources.GetObject("datePickerStart.Icon")));
            this.datePickerStart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.datePickerStart.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.datePickerStart.LeftTextMargin = 5;
            this.datePickerStart.Location = new System.Drawing.Point(437, 161);
            this.datePickerStart.MinimumSize = new System.Drawing.Size(4, 32);
            this.datePickerStart.Name = "datePickerStart";
            this.datePickerStart.Size = new System.Drawing.Size(204, 32);
            this.datePickerStart.TabIndex = 10;
            this.datePickerStart.Value = new System.DateTime(2020, 12, 11, 10, 57, 0, 0);
            this.datePickerStart.ValueChanged += new System.EventHandler(this.datePickerStart_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label19.Location = new System.Drawing.Point(664, 165);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 21);
            this.label19.TabIndex = 9;
            this.label19.Text = "to";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.BackColor = System.Drawing.Color.Transparent;
            this.datePickerEnd.BorderRadius = 1;
            this.datePickerEnd.CalendarFont = new System.Drawing.Font("Mulish", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.datePickerEnd.CalendarMonthBackground = System.Drawing.Color.White;
            this.datePickerEnd.Color = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.datePickerEnd.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.datePickerEnd.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.datePickerEnd.DisabledColor = System.Drawing.Color.Gray;
            this.datePickerEnd.DisplayWeekNumbers = false;
            this.datePickerEnd.DPHeight = 0;
            this.datePickerEnd.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePickerEnd.FillDatePicker = false;
            this.datePickerEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePickerEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.datePickerEnd.Icon = ((System.Drawing.Image)(resources.GetObject("datePickerEnd.Icon")));
            this.datePickerEnd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.datePickerEnd.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.datePickerEnd.LeftTextMargin = 5;
            this.datePickerEnd.Location = new System.Drawing.Point(709, 161);
            this.datePickerEnd.MinimumSize = new System.Drawing.Size(4, 32);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Size = new System.Drawing.Size(204, 32);
            this.datePickerEnd.TabIndex = 10;
            this.datePickerEnd.Value = new System.DateTime(2020, 12, 11, 10, 57, 0, 0);
            this.datePickerEnd.ValueChanged += new System.EventHandler(this.datePickerEnd_ValueChanged);
            // 
            // orderPanel1
            // 
            this.orderPanel1.BackColor = System.Drawing.Color.White;
            this.orderPanel1.Location = new System.Drawing.Point(3, 3);
            this.orderPanel1.Name = "orderPanel1";
            this.orderPanel1.Size = new System.Drawing.Size(919, 63);
            this.orderPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Mulish", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(778, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Status";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(925, 584);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.datePickerEnd);
            this.Controls.Add(this.datePickerStart);
            this.Controls.Add(this.sortDropDown);
            this.Controls.Add(this.ordersFlowLayoutPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyOrders";
            this.Text = "MyOrders";
            this.Load += new System.EventHandler(this.MyOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ordersFlowLayoutPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuSeparator DeliveredSeparator;
        private Bunifu.UI.WinForms.BunifuSeparator ProcessingSeparator;
        private Bunifu.UI.WinForms.BunifuSeparator AllSeparator;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label Delivered;
        private System.Windows.Forms.Label Confirmed;
        private System.Windows.Forms.Label Processing;
        private System.Windows.Forms.Label All;
        private System.Windows.Forms.FlowLayoutPanel ordersFlowLayoutPanel;
        private Bunifu.UI.WinForms.BunifuDropdown sortDropDown;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDatePicker datePickerStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuSeparator ConfirmedSeparator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDatePicker datePickerEnd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label7;
        private OrderPanel orderPanel1;
    }
}