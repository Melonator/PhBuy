
namespace PhBuy
{
    partial class ProductDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDisplay));
            this.ratingLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.sellerNameLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sellerProfilePicture = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ratingLabel.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.ratingLabel.Location = new System.Drawing.Point(41, 345);
            this.ratingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(34, 21);
            this.ratingLabel.TabIndex = 51;
            this.ratingLabel.Text = "5.0";
            this.ratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.PriceLabel.Font = new System.Drawing.Font("Mulish Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.PriceLabel.Location = new System.Drawing.Point(12, 262);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(91, 20);
            this.PriceLabel.TabIndex = 46;
            this.PriceLabel.Text = "₱ Price Here";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PriceLabel.UseMnemonic = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Mulish Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.statusLabel.Location = new System.Drawing.Point(12, 283);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(41, 20);
            this.statusLabel.TabIndex = 47;
            this.statusLabel.Text = "New";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusLabel.UseMnemonic = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Mulish Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.NameLabel.Location = new System.Drawing.Point(12, 239);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(143, 20);
            this.NameLabel.TabIndex = 48;
            this.NameLabel.Text = "Product Name Here";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NameLabel.UseMnemonic = false;
            // 
            // sellerNameLabel
            // 
            this.sellerNameLabel.AutoSize = true;
            this.sellerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.sellerNameLabel.Font = new System.Drawing.Font("Mulish Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.sellerNameLabel.Location = new System.Drawing.Point(45, 16);
            this.sellerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sellerNameLabel.Name = "sellerNameLabel";
            this.sellerNameLabel.Size = new System.Drawing.Size(126, 20);
            this.sellerNameLabel.TabIndex = 49;
            this.sellerNameLabel.Text = "Seller Name Here";
            this.sellerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sellerNameLabel.UseMnemonic = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PhBuy.Properties.Resources.star_208px;
            this.pictureBox2.Location = new System.Drawing.Point(16, 345);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // sellerProfilePicture
            // 
            this.sellerProfilePicture.AllowFocused = false;
            this.sellerProfilePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellerProfilePicture.AutoSizeHeight = true;
            this.sellerProfilePicture.BorderRadius = 15;
            this.sellerProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("sellerProfilePicture.Image")));
            this.sellerProfilePicture.IsCircle = true;
            this.sellerProfilePicture.Location = new System.Drawing.Point(8, 12);
            this.sellerProfilePicture.Name = "sellerProfilePicture";
            this.sellerProfilePicture.Size = new System.Drawing.Size(30, 30);
            this.sellerProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sellerProfilePicture.TabIndex = 45;
            this.sellerProfilePicture.TabStop = false;
            this.sellerProfilePicture.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // productPictureBox
            // 
            this.productPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.productPictureBox.Location = new System.Drawing.Point(3, 48);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(188, 188);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 44;
            this.productPictureBox.TabStop = false;
            // 
            // ProductDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.sellerNameLabel);
            this.Controls.Add(this.sellerProfilePicture);
            this.Controls.Add(this.productPictureBox);
            this.Name = "ProductDisplay";
            this.Size = new System.Drawing.Size(195, 378);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label PriceLabel;
        public System.Windows.Forms.Label statusLabel;
        public System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.Label sellerNameLabel;
        public Bunifu.UI.WinForms.BunifuPictureBox sellerProfilePicture;
        public System.Windows.Forms.PictureBox productPictureBox;
    }
}
