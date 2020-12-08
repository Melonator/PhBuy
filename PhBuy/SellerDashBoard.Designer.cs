
namespace PhBuy
{
    partial class SellerDashBoard
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
            this.sellerTabControl = new System.Windows.Forms.TabControl();
            this.profile = new System.Windows.Forms.TabPage();
            this.rating = new System.Windows.Forms.TabPage();
            this.report = new System.Windows.Forms.TabPage();
            this.myProducts = new System.Windows.Forms.TabPage();
            this.addProduct = new System.Windows.Forms.TabPage();
            this.orders = new System.Windows.Forms.TabPage();
            this.income = new System.Windows.Forms.TabPage();
            this.insight = new System.Windows.Forms.TabPage();
            this.inventory = new System.Windows.Forms.TabPage();
            this.sellerTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sellerTabControl
            // 
            this.sellerTabControl.Controls.Add(this.profile);
            this.sellerTabControl.Controls.Add(this.rating);
            this.sellerTabControl.Controls.Add(this.report);
            this.sellerTabControl.Controls.Add(this.myProducts);
            this.sellerTabControl.Controls.Add(this.addProduct);
            this.sellerTabControl.Controls.Add(this.orders);
            this.sellerTabControl.Controls.Add(this.income);
            this.sellerTabControl.Controls.Add(this.insight);
            this.sellerTabControl.Controls.Add(this.inventory);
            this.sellerTabControl.Location = new System.Drawing.Point(-4, -22);
            this.sellerTabControl.Name = "sellerTabControl";
            this.sellerTabControl.SelectedIndex = 0;
            this.sellerTabControl.Size = new System.Drawing.Size(931, 605);
            this.sellerTabControl.TabIndex = 0;
            // 
            // profile
            // 
            this.profile.Location = new System.Drawing.Point(4, 22);
            this.profile.Name = "profile";
            this.profile.Padding = new System.Windows.Forms.Padding(3);
            this.profile.Size = new System.Drawing.Size(923, 579);
            this.profile.TabIndex = 0;
            this.profile.Text = "profile";
            this.profile.UseVisualStyleBackColor = true;
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(4, 22);
            this.rating.Name = "rating";
            this.rating.Padding = new System.Windows.Forms.Padding(3);
            this.rating.Size = new System.Drawing.Size(917, 558);
            this.rating.TabIndex = 1;
            this.rating.Text = "rating";
            this.rating.UseVisualStyleBackColor = true;
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(4, 22);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(917, 558);
            this.report.TabIndex = 2;
            this.report.Text = "report";
            this.report.UseVisualStyleBackColor = true;
            // 
            // myProducts
            // 
            this.myProducts.Location = new System.Drawing.Point(4, 22);
            this.myProducts.Name = "myProducts";
            this.myProducts.Size = new System.Drawing.Size(917, 558);
            this.myProducts.TabIndex = 3;
            this.myProducts.Text = "myProducts";
            this.myProducts.UseVisualStyleBackColor = true;
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(4, 22);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(917, 558);
            this.addProduct.TabIndex = 4;
            this.addProduct.Text = "addProduct";
            this.addProduct.UseVisualStyleBackColor = true;
            // 
            // orders
            // 
            this.orders.Location = new System.Drawing.Point(4, 22);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(917, 558);
            this.orders.TabIndex = 5;
            this.orders.Text = "orders";
            this.orders.UseVisualStyleBackColor = true;
            // 
            // income
            // 
            this.income.Location = new System.Drawing.Point(4, 22);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(917, 558);
            this.income.TabIndex = 6;
            this.income.Text = "income";
            this.income.UseVisualStyleBackColor = true;
            // 
            // insight
            // 
            this.insight.Location = new System.Drawing.Point(4, 22);
            this.insight.Name = "insight";
            this.insight.Size = new System.Drawing.Size(917, 558);
            this.insight.TabIndex = 7;
            this.insight.Text = "insight";
            this.insight.UseVisualStyleBackColor = true;
            // 
            // inventory
            // 
            this.inventory.Location = new System.Drawing.Point(4, 22);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(917, 558);
            this.inventory.TabIndex = 8;
            this.inventory.Text = "inventory";
            this.inventory.UseVisualStyleBackColor = true;
            // 
            // SellerDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 584);
            this.Controls.Add(this.sellerTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerDashBoard";
            this.Text = "SellerDashBoard";
            this.sellerTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TabPage profile;
        private System.Windows.Forms.TabPage rating;
        private System.Windows.Forms.TabPage report;
        private System.Windows.Forms.TabPage myProducts;
        private System.Windows.Forms.TabPage addProduct;
        private System.Windows.Forms.TabPage orders;
        private System.Windows.Forms.TabPage income;
        private System.Windows.Forms.TabPage insight;
        private System.Windows.Forms.TabPage inventory;
        public System.Windows.Forms.TabControl sellerTabControl;
    }
}