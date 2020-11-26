
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
            this.label4 = new System.Windows.Forms.Label();
            this.sellerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.sellerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.sellerPanel);
            this.mainPanel.Controls.Add(this.customerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(754, 500);
            this.mainPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mulish SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(229, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 44);
            this.label4.TabIndex = 12;
            this.label4.Text = "Would you like to...";
            // 
            // sellerPanel
            // 
            this.sellerPanel.BackColor = System.Drawing.Color.White;
            this.sellerPanel.Controls.Add(this.pictureBox1);
            this.sellerPanel.Controls.Add(this.label1);
            this.sellerPanel.Location = new System.Drawing.Point(9, 119);
            this.sellerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sellerPanel.Name = "sellerPanel";
            this.sellerPanel.Size = new System.Drawing.Size(364, 370);
            this.sellerPanel.TabIndex = 0;
            this.sellerPanel.Click += new System.EventHandler(this.sellerPanel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhBuy.Properties.Resources.shop_208px;
            this.pictureBox1.Location = new System.Drawing.Point(116, 135);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mulish SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(148, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 44);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sell";
            // 
            // customerPanel
            // 
            this.customerPanel.BackColor = System.Drawing.Color.White;
            this.customerPanel.Controls.Add(this.pictureBox2);
            this.customerPanel.Controls.Add(this.label2);
            this.customerPanel.Location = new System.Drawing.Point(382, 119);
            this.customerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(364, 370);
            this.customerPanel.TabIndex = 0;
            this.customerPanel.Click += new System.EventHandler(this.customerPanel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PhBuy.Properties.Resources.cardboard_box_480px;
            this.pictureBox2.Location = new System.Drawing.Point(116, 135);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mulish SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(148, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 44);
            this.label2.TabIndex = 12;
            this.label2.Text = "Buy";
            // 
            // CustomerSellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(754, 500);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerSellerForm";
            this.Text = "s";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.sellerPanel.ResumeLayout(false);
            this.sellerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customerPanel.ResumeLayout(false);
            this.customerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel sellerPanel;
        private System.Windows.Forms.Panel customerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}