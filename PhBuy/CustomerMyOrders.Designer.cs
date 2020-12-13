
namespace PhBuy
{
    partial class CustomerMyOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMyOrders));
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
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 68);
            this.panel1.TabIndex = 1;
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
            this.userNameLabel.Location = new System.Drawing.Point(69, 17);
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
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 54);
            this.panel2.TabIndex = 2;
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
            this.ConfirmedSeparator.Location = new System.Drawing.Point(446, 46);
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
            this.DeliveredSeparator.Location = new System.Drawing.Point(705, 46);
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
            this.ProcessingSeparator.Location = new System.Drawing.Point(169, 46);
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
            this.AllSeparator.Location = new System.Drawing.Point(36, 46);
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
            this.Delivered.Location = new System.Drawing.Point(723, 12);
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
            this.Confirmed.Location = new System.Drawing.Point(451, 12);
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
            this.Processing.Location = new System.Drawing.Point(182, 12);
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
            this.All.Location = new System.Drawing.Point(40, 12);
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
            this.ordersFlowLayoutPanel.Location = new System.Drawing.Point(0, 150);
            this.ordersFlowLayoutPanel.Name = "ordersFlowLayoutPanel";
            this.ordersFlowLayoutPanel.Size = new System.Drawing.Size(876, 436);
            this.ordersFlowLayoutPanel.TabIndex = 3;
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 100;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = false;
            this.bunifuSnackbar1.ShowCloseIcon = false;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // CustomerMyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 586);
            this.Controls.Add(this.ordersFlowLayoutPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerMyOrders";
            this.Text = "CustomerMyOrders";
            this.Load += new System.EventHandler(this.CustomerMyOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuSeparator ConfirmedSeparator;
        private Bunifu.UI.WinForms.BunifuSeparator DeliveredSeparator;
        private Bunifu.UI.WinForms.BunifuSeparator ProcessingSeparator;
        private Bunifu.UI.WinForms.BunifuSeparator AllSeparator;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label Delivered;
        private System.Windows.Forms.Label Confirmed;
        private System.Windows.Forms.Label Processing;
        private System.Windows.Forms.Label All;
        public System.Windows.Forms.FlowLayoutPanel ordersFlowLayoutPanel;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
    }
}