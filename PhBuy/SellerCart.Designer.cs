
namespace PhBuy
{
    partial class SellerCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerCart));
            this.sellerNameLabel = new System.Windows.Forms.Label();
            this.sellerPictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.sellerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sellerNameLabel
            // 
            this.sellerNameLabel.AutoSize = true;
            this.sellerNameLabel.BackColor = System.Drawing.Color.White;
            this.sellerNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellerNameLabel.Font = new System.Drawing.Font("Mulish SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.sellerNameLabel.Location = new System.Drawing.Point(93, 12);
            this.sellerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sellerNameLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.sellerNameLabel.Name = "sellerNameLabel";
            this.sellerNameLabel.Size = new System.Drawing.Size(143, 21);
            this.sellerNameLabel.TabIndex = 62;
            this.sellerNameLabel.Text = "Seller Shop Name";
            this.sellerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sellerPictureBox
            // 
            this.sellerPictureBox.AllowFocused = false;
            this.sellerPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sellerPictureBox.AutoSizeHeight = true;
            this.sellerPictureBox.BorderRadius = 20;
            this.sellerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("sellerPictureBox.Image")));
            this.sellerPictureBox.IsCircle = true;
            this.sellerPictureBox.Location = new System.Drawing.Point(48, 3);
            this.sellerPictureBox.Name = "sellerPictureBox";
            this.sellerPictureBox.Size = new System.Drawing.Size(40, 40);
            this.sellerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sellerPictureBox.TabIndex = 61;
            this.sellerPictureBox.TabStop = false;
            this.sellerPictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(13, 17);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 63;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // SellerCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.sellerPictureBox);
            this.Controls.Add(this.sellerNameLabel);
            this.Name = "SellerCart";
            this.Size = new System.Drawing.Size(879, 47);
            ((System.ComponentModel.ISupportInitialize)(this.sellerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuPictureBox sellerPictureBox;
        public System.Windows.Forms.Label sellerNameLabel;
        public System.Windows.Forms.CheckBox checkBox;
    }
}
