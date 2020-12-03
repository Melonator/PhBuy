
namespace PhBuy
{
    partial class CustomerSellerForm
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buyTileButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.sellTileButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.label4 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.buyTileButton);
            this.mainPanel.Controls.Add(this.sellTileButton);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(754, 500);
            this.mainPanel.TabIndex = 1;
            // 
            // buyTileButton
            // 
            this.buyTileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
            this.buyTileButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
            this.buyTileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(150)))), ((int)(((byte)(94)))));
            this.buyTileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyTileButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.buyTileButton.ForeColor = System.Drawing.Color.White;
            this.buyTileButton.Image = global::PhBuy.Properties.Resources.buy_512px1;
            this.buyTileButton.ImagePosition = 50;
            this.buyTileButton.ImageZoom = 50;
            this.buyTileButton.LabelPosition = 41;
            this.buyTileButton.LabelText = "Buy";
            this.buyTileButton.Location = new System.Drawing.Point(404, 222);
            this.buyTileButton.Margin = new System.Windows.Forms.Padding(6);
            this.buyTileButton.Name = "buyTileButton";
            this.buyTileButton.Size = new System.Drawing.Size(199, 216);
            this.buyTileButton.TabIndex = 15;
            // 
            // sellTileButton
            // 
            this.sellTileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
            this.sellTileButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
            this.sellTileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(150)))), ((int)(((byte)(94)))));
            this.sellTileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellTileButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.sellTileButton.ForeColor = System.Drawing.Color.White;
            this.sellTileButton.Image = global::PhBuy.Properties.Resources.online_store_480px2;
            this.sellTileButton.ImagePosition = 50;
            this.sellTileButton.ImageZoom = 50;
            this.sellTileButton.LabelPosition = 41;
            this.sellTileButton.LabelText = "Sell";
            this.sellTileButton.Location = new System.Drawing.Point(166, 222);
            this.sellTileButton.Margin = new System.Windows.Forms.Padding(6);
            this.sellTileButton.Name = "sellTileButton";
            this.sellTileButton.Size = new System.Drawing.Size(199, 216);
            this.sellTileButton.TabIndex = 14;
            this.sellTileButton.Click += new System.EventHandler(this.sellTileButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mulish", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(152, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(458, 65);
            this.label4.TabIndex = 12;
            this.label4.Text = "Would you like to...";
            // 
            // CustomerSellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::PhBuy.Properties.Resources.CustomerSellerForm3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 500);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerSellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel mainPanel;
		private Bunifu.Framework.UI.BunifuTileButton buyTileButton;
		private Bunifu.Framework.UI.BunifuTileButton sellTileButton;
	}
}