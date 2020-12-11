
namespace PhBuy
{
    partial class OrderPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPanel));
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.customerProfilePicture = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.statusDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.customerProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.priceLabel.Location = new System.Drawing.Point(602, 23);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.MaximumSize = new System.Drawing.Size(180, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(61, 21);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "₱ Price";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.quantityLabel.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.quantityLabel.Location = new System.Drawing.Point(480, 23);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityLabel.MaximumSize = new System.Drawing.Size(180, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(29, 21);
            this.quantityLabel.TabIndex = 12;
            this.quantityLabel.Text = "x2";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.customerNameLabel.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.customerNameLabel.Location = new System.Drawing.Point(261, 23);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameLabel.MaximumSize = new System.Drawing.Size(180, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(131, 21);
            this.customerNameLabel.TabIndex = 13;
            this.customerNameLabel.Text = "Customer Name";
            this.customerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.productNameLabel.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.productNameLabel.Location = new System.Drawing.Point(11, 12);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productNameLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(199, 40);
            this.productNameLabel.TabIndex = 14;
            this.productNameLabel.Text = "ASDCHSAJKOCHJSKAHCJSABCSA";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customerProfilePicture
            // 
            this.customerProfilePicture.AllowFocused = false;
            this.customerProfilePicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.customerProfilePicture.AutoSizeHeight = true;
            this.customerProfilePicture.BorderRadius = 20;
            this.customerProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("customerProfilePicture.Image")));
            this.customerProfilePicture.IsCircle = true;
            this.customerProfilePicture.Location = new System.Drawing.Point(216, 14);
            this.customerProfilePicture.Name = "customerProfilePicture";
            this.customerProfilePicture.Size = new System.Drawing.Size(40, 40);
            this.customerProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerProfilePicture.TabIndex = 10;
            this.customerProfilePicture.TabStop = false;
            this.customerProfilePicture.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // statusDropDown
            // 
            this.statusDropDown.BackColor = System.Drawing.Color.White;
            this.statusDropDown.BackgroundColor = System.Drawing.Color.White;
            this.statusDropDown.BorderColor = System.Drawing.Color.Silver;
            this.statusDropDown.BorderRadius = 1;
            this.statusDropDown.Color = System.Drawing.Color.Silver;
            this.statusDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.statusDropDown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.statusDropDown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.statusDropDown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.statusDropDown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.statusDropDown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.statusDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.statusDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.statusDropDown.FillDropDown = true;
            this.statusDropDown.FillIndicator = false;
            this.statusDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusDropDown.Font = new System.Drawing.Font("Mulish", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDropDown.ForeColor = System.Drawing.Color.Black;
            this.statusDropDown.FormattingEnabled = true;
            this.statusDropDown.Icon = null;
            this.statusDropDown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.statusDropDown.IndicatorColor = System.Drawing.Color.Gray;
            this.statusDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.statusDropDown.ItemBackColor = System.Drawing.Color.White;
            this.statusDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.statusDropDown.ItemForeColor = System.Drawing.Color.Black;
            this.statusDropDown.ItemHeight = 26;
            this.statusDropDown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.statusDropDown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.statusDropDown.Items.AddRange(new object[] {
            "Processing",
            "Confirmed"});
            this.statusDropDown.ItemTopMargin = 3;
            this.statusDropDown.Location = new System.Drawing.Point(726, 16);
            this.statusDropDown.Name = "statusDropDown";
            this.statusDropDown.Size = new System.Drawing.Size(115, 32);
            this.statusDropDown.TabIndex = 15;
            this.statusDropDown.Text = "Processing";
            this.statusDropDown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.statusDropDown.TextLeftMargin = 5;
            // 
            // OrderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.statusDropDown);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.customerProfilePicture);
            this.Name = "OrderPanel";
            this.Size = new System.Drawing.Size(919, 63);
            ((System.ComponentModel.ISupportInitialize)(this.customerProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label productNameLabel;
        public System.Windows.Forms.Label priceLabel;
        public System.Windows.Forms.Label quantityLabel;
        public System.Windows.Forms.Label customerNameLabel;
        public Bunifu.UI.WinForms.BunifuPictureBox customerProfilePicture;
        public Bunifu.UI.WinForms.BunifuDropdown statusDropDown;
    }
}
