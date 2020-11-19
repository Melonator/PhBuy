
namespace PhBuy
{
    partial class DatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Seller = new System.Windows.Forms.DataGridView();
            this.tableDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label9 = new System.Windows.Forms.Label();
            this.exitButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Products = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.DataGridView();
            this.Orders = new System.Windows.Forms.DataGridView();
            this.Profiles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Seller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profiles)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Seller
            // 
            this.Seller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Seller.Location = new System.Drawing.Point(9, 92);
            this.Seller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Seller.Name = "Seller";
            this.Seller.RowHeadersWidth = 51;
            this.Seller.RowTemplate.Height = 24;
            this.Seller.Size = new System.Drawing.Size(688, 308);
            this.Seller.TabIndex = 0;
            // 
            // tableDropDown
            // 
            this.tableDropDown.BackColor = System.Drawing.SystemColors.Control;
            this.tableDropDown.BackgroundColor = System.Drawing.Color.White;
            this.tableDropDown.BorderColor = System.Drawing.Color.Silver;
            this.tableDropDown.BorderRadius = 1;
            this.tableDropDown.Color = System.Drawing.Color.Silver;
            this.tableDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.tableDropDown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tableDropDown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tableDropDown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tableDropDown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tableDropDown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.tableDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tableDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.tableDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.tableDropDown.FillDropDown = true;
            this.tableDropDown.FillIndicator = false;
            this.tableDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableDropDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tableDropDown.ForeColor = System.Drawing.Color.Black;
            this.tableDropDown.FormattingEnabled = true;
            this.tableDropDown.Icon = null;
            this.tableDropDown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.tableDropDown.IndicatorColor = System.Drawing.Color.Gray;
            this.tableDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.tableDropDown.ItemBackColor = System.Drawing.Color.White;
            this.tableDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.tableDropDown.ItemForeColor = System.Drawing.Color.Black;
            this.tableDropDown.ItemHeight = 26;
            this.tableDropDown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.tableDropDown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.tableDropDown.Items.AddRange(new object[] {
            "Seller",
            "Products",
            "Customer",
            "Orders",
            "Profiles"});
            this.tableDropDown.ItemTopMargin = 3;
            this.tableDropDown.Location = new System.Drawing.Point(9, 47);
            this.tableDropDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableDropDown.Name = "tableDropDown";
            this.tableDropDown.Size = new System.Drawing.Size(196, 32);
            this.tableDropDown.TabIndex = 1;
            this.tableDropDown.Text = null;
            this.tableDropDown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.tableDropDown.TextLeftMargin = 5;
            this.tableDropDown.SelectedIndexChanged += new System.EventHandler(this.tableDropDown_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(9, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 37);
            this.label9.TabIndex = 49;
            this.label9.Text = "Table";
            // 
            // exitButton
            // 
            this.exitButton.ActiveImage = null;
            this.exitButton.AllowAnimations = true;
            this.exitButton.AllowBuffering = false;
            this.exitButton.AllowToggling = false;
            this.exitButton.AllowZooming = true;
            this.exitButton.AllowZoomingOnFocus = false;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exitButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("exitButton.ErrorImage")));
            this.exitButton.FadeWhenInactive = false;
            this.exitButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.exitButton.Image = global::PhBuy.Properties.Resources.exit_208px;
            this.exitButton.ImageActive = null;
            this.exitButton.ImageLocation = null;
            this.exitButton.ImageMargin = 40;
            this.exitButton.ImageSize = new System.Drawing.Size(12, 17);
            this.exitButton.ImageZoomSize = new System.Drawing.Size(52, 57);
            this.exitButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("exitButton.InitialImage")));
            this.exitButton.Location = new System.Drawing.Point(653, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Rotation = 0;
            this.exitButton.ShowActiveImage = true;
            this.exitButton.ShowCursorChanges = true;
            this.exitButton.ShowImageBorders = true;
            this.exitButton.ShowSizeMarkers = false;
            this.exitButton.Size = new System.Drawing.Size(52, 57);
            this.exitButton.TabIndex = 50;
            this.exitButton.ToolTipText = "";
            this.exitButton.WaitOnLoad = false;
            this.exitButton.Zoom = 40;
            this.exitButton.ZoomSpeed = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Products
            // 
            this.Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Products.Location = new System.Drawing.Point(9, 92);
            this.Products.Margin = new System.Windows.Forms.Padding(2);
            this.Products.Name = "Products";
            this.Products.RowHeadersWidth = 51;
            this.Products.RowTemplate.Height = 24;
            this.Products.Size = new System.Drawing.Size(688, 308);
            this.Products.TabIndex = 51;
            // 
            // Customer
            // 
            this.Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customer.Location = new System.Drawing.Point(9, 92);
            this.Customer.Margin = new System.Windows.Forms.Padding(2);
            this.Customer.Name = "Customer";
            this.Customer.RowHeadersWidth = 51;
            this.Customer.RowTemplate.Height = 24;
            this.Customer.Size = new System.Drawing.Size(688, 308);
            this.Customer.TabIndex = 52;
            // 
            // Orders
            // 
            this.Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Orders.Location = new System.Drawing.Point(9, 92);
            this.Orders.Margin = new System.Windows.Forms.Padding(2);
            this.Orders.Name = "Orders";
            this.Orders.RowHeadersWidth = 51;
            this.Orders.RowTemplate.Height = 24;
            this.Orders.Size = new System.Drawing.Size(688, 308);
            this.Orders.TabIndex = 53;
            // 
            // Profiles
            // 
            this.Profiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Profiles.Location = new System.Drawing.Point(9, 92);
            this.Profiles.Margin = new System.Windows.Forms.Padding(2);
            this.Profiles.Name = "Profiles";
            this.Profiles.RowHeadersWidth = 51;
            this.Profiles.RowTemplate.Height = 24;
            this.Profiles.Size = new System.Drawing.Size(688, 308);
            this.Profiles.TabIndex = 54;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 410);
            this.Controls.Add(this.Profiles);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tableDropDown);
            this.Controls.Add(this.Seller);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DatabaseForm";
            this.Text = "DatabaseForm";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Seller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView Seller;
        private Bunifu.UI.WinForms.BunifuDropdown tableDropDown;
        private System.Windows.Forms.Label label9;
        private Bunifu.UI.WinForms.BunifuImageButton exitButton;
        private System.Windows.Forms.DataGridView Profiles;
        private System.Windows.Forms.DataGridView Orders;
        private System.Windows.Forms.DataGridView Customer;
        private System.Windows.Forms.DataGridView Products;
    }
}