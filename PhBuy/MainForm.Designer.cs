namespace PhBuy
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sidePanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.gridButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.userPhoto = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.userPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).BeginInit();
            this.userPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidePanel.Location = new System.Drawing.Point(0, 51);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(118, 583);
            this.sidePanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(122, 50);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(925, 584);
            this.mainPanel.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.mainPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.topPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topPanel.Controls.Add(this.userPanel);
            this.topPanel.Controls.Add(this.gridButton);
            this.topPanel.Controls.Add(this.bunifuSeparator1);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.bunifuImageButton1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1056, 46);
            this.topPanel.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Mulish SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(39, 12);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(25, 20);
            this.userNameLabel.TabIndex = 8;
            this.userNameLabel.Text = "JD";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.topPanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // gridButton
            // 
            this.gridButton.ActiveImage = null;
            this.gridButton.AllowAnimations = true;
            this.gridButton.AllowBuffering = false;
            this.gridButton.AllowToggling = false;
            this.gridButton.AllowZooming = true;
            this.gridButton.AllowZoomingOnFocus = false;
            this.gridButton.BackColor = System.Drawing.Color.Transparent;
            this.gridButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gridButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("gridButton.ErrorImage")));
            this.gridButton.FadeWhenInactive = false;
            this.gridButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.gridButton.Image = global::PhBuy.Properties.Resources.grid_view_208px;
            this.gridButton.ImageActive = null;
            this.gridButton.ImageLocation = null;
            this.gridButton.ImageMargin = 0;
            this.gridButton.ImageSize = new System.Drawing.Size(29, 29);
            this.gridButton.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.gridButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("gridButton.InitialImage")));
            this.gridButton.Location = new System.Drawing.Point(928, 8);
            this.gridButton.Margin = new System.Windows.Forms.Padding(0);
            this.gridButton.Name = "gridButton";
            this.gridButton.Rotation = 0;
            this.gridButton.ShowActiveImage = true;
            this.gridButton.ShowCursorChanges = true;
            this.gridButton.ShowImageBorders = true;
            this.gridButton.ShowSizeMarkers = false;
            this.gridButton.Size = new System.Drawing.Size(30, 30);
            this.gridButton.TabIndex = 9;
            this.gridButton.ToolTipText = "";
            this.gridButton.WaitOnLoad = false;
            this.gridButton.Zoom = 0;
            this.gridButton.ZoomSpeed = 10;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(908, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator1.Size = new System.Drawing.Size(14, 38);
            this.bunifuSeparator1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PhBuy.Properties.Resources.Logo_WHITE;
            this.pictureBox1.Location = new System.Drawing.Point(20, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = false;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::PhBuy.Properties.Resources.exit_208pxw;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 0;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(1019, 10);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 0;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // userPhoto
            // 
            this.userPhoto.AllowFocused = false;
            this.userPhoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userPhoto.AutoSizeHeight = true;
            this.userPhoto.BorderRadius = 16;
            this.userPhoto.Image = ((System.Drawing.Image)(resources.GetObject("userPhoto.Image")));
            this.userPhoto.IsCircle = true;
            this.userPhoto.Location = new System.Drawing.Point(2, 6);
            this.userPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.userPhoto.Name = "userPhoto";
            this.userPhoto.Size = new System.Drawing.Size(33, 33);
            this.userPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPhoto.TabIndex = 2;
            this.userPhoto.TabStop = false;
            this.userPhoto.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // userPanel
            // 
            this.userPanel.AutoSize = true;
            this.userPanel.Controls.Add(this.userPhoto);
            this.userPanel.Controls.Add(this.userNameLabel);
            this.userPanel.Location = new System.Drawing.Point(753, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(69, 45);
            this.userPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1056, 644);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).EndInit();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel sidePanel;
        private Bunifu.UI.WinForms.BunifuPictureBox userPhoto;
        private System.Windows.Forms.Label userNameLabel;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel mainPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.UI.WinForms.BunifuImageButton gridButton;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel userPanel;
    }
}

