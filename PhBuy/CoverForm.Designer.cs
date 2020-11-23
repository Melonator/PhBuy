
namespace PhBuy
{
    partial class CoverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoverForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.coverFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cover1 = new System.Windows.Forms.PictureBox();
            this.cover2 = new System.Windows.Forms.PictureBox();
            this.cover3 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.coverScroll = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.uploadButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.exitButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.coverFlowPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cover1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // coverFlowPanel
            // 
            this.coverFlowPanel.Controls.Add(this.titlePanel);
            this.coverFlowPanel.Controls.Add(this.cover1);
            this.coverFlowPanel.Controls.Add(this.cover2);
            this.coverFlowPanel.Controls.Add(this.cover3);
            this.coverFlowPanel.Location = new System.Drawing.Point(13, 77);
            this.coverFlowPanel.Name = "coverFlowPanel";
            this.coverFlowPanel.Size = new System.Drawing.Size(793, 361);
            this.coverFlowPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Backgrounds";
            // 
            // cover1
            // 
            this.cover1.Image = global::PhBuy.Properties.Resources.Stars;
            this.cover1.Location = new System.Drawing.Point(3, 47);
            this.cover1.Name = "cover1";
            this.cover1.Size = new System.Drawing.Size(192, 108);
            this.cover1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cover1.TabIndex = 3;
            this.cover1.TabStop = false;
            this.cover1.Click += new System.EventHandler(this.cover_Click);
            // 
            // cover2
            // 
            this.cover2.Image = global::PhBuy.Properties.Resources.Sky;
            this.cover2.Location = new System.Drawing.Point(201, 47);
            this.cover2.Name = "cover2";
            this.cover2.Size = new System.Drawing.Size(192, 108);
            this.cover2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cover2.TabIndex = 4;
            this.cover2.TabStop = false;
            this.cover2.Click += new System.EventHandler(this.cover_Click);
            // 
            // cover3
            // 
            this.cover3.Image = global::PhBuy.Properties.Resources.Trees;
            this.cover3.Location = new System.Drawing.Point(399, 47);
            this.cover3.Name = "cover3";
            this.cover3.Size = new System.Drawing.Size(192, 108);
            this.cover3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cover3.TabIndex = 5;
            this.cover3.TabStop = false;
            this.cover3.Click += new System.EventHandler(this.cover_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(13, 52);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(789, 17);
            this.bunifuSeparator1.TabIndex = 1;
            // 
            // coverScroll
            // 
            this.coverScroll.AllowCursorChanges = true;
            this.coverScroll.AllowHomeEndKeysDetection = false;
            this.coverScroll.AllowIncrementalClickMoves = true;
            this.coverScroll.AllowMouseDownEffects = true;
            this.coverScroll.AllowMouseHoverEffects = true;
            this.coverScroll.AllowScrollingAnimations = true;
            this.coverScroll.AllowScrollKeysDetection = true;
            this.coverScroll.AllowScrollOptionsMenu = true;
            this.coverScroll.AllowShrinkingOnFocusLost = false;
            this.coverScroll.BackgroundColor = System.Drawing.Color.Silver;
            this.coverScroll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coverScroll.BackgroundImage")));
            this.coverScroll.BindingContainer = this.coverFlowPanel;
            this.coverScroll.BorderColor = System.Drawing.Color.Silver;
            this.coverScroll.BorderRadius = 14;
            this.coverScroll.BorderThickness = 1;
            this.coverScroll.DurationBeforeShrink = 2000;
            this.coverScroll.LargeChange = 10;
            this.coverScroll.Location = new System.Drawing.Point(813, 76);
            this.coverScroll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coverScroll.Maximum = 100;
            this.coverScroll.Minimum = 0;
            this.coverScroll.MinimumThumbLength = 18;
            this.coverScroll.Name = "coverScroll";
            this.coverScroll.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.coverScroll.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.coverScroll.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.coverScroll.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.coverScroll.ScrollBarColor = System.Drawing.Color.Silver;
            this.coverScroll.ShrinkSizeLimit = 3;
            this.coverScroll.Size = new System.Drawing.Size(17, 361);
            this.coverScroll.SmallChange = 1;
            this.coverScroll.TabIndex = 0;
            this.coverScroll.ThumbColor = System.Drawing.Color.Gray;
            this.coverScroll.ThumbLength = 35;
            this.coverScroll.ThumbMargin = 1;
            this.coverScroll.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.coverScroll.Value = 0;
            // 
            // uploadButton
            // 
            this.uploadButton.ActiveBorderThickness = 1;
            this.uploadButton.ActiveCornerRadius = 20;
            this.uploadButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.uploadButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.uploadButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.uploadButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uploadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uploadButton.BackgroundImage")));
            this.uploadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadButton.ButtonText = "Upload";
            this.uploadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadButton.Font = new System.Drawing.Font("Mulish", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.uploadButton.IdleBorderThickness = 1;
            this.uploadButton.IdleCornerRadius = 20;
            this.uploadButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.uploadButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.uploadButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.uploadButton.Location = new System.Drawing.Point(588, 14);
            this.uploadButton.Margin = new System.Windows.Forms.Padding(5);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(95, 37);
            this.uploadButton.TabIndex = 53;
            this.uploadButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.ActiveImage = null;
            this.exitButton.AllowAnimations = true;
            this.exitButton.AllowBuffering = false;
            this.exitButton.AllowToggling = false;
            this.exitButton.AllowZooming = false;
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
            this.exitButton.ImageSize = new System.Drawing.Size(25, 25);
            this.exitButton.ImageZoomSize = new System.Drawing.Size(65, 65);
            this.exitButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("exitButton.InitialImage")));
            this.exitButton.Location = new System.Drawing.Point(782, -14);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Rotation = 0;
            this.exitButton.ShowActiveImage = true;
            this.exitButton.ShowCursorChanges = true;
            this.exitButton.ShowImageBorders = true;
            this.exitButton.ShowSizeMarkers = false;
            this.exitButton.Size = new System.Drawing.Size(65, 65);
            this.exitButton.TabIndex = 54;
            this.exitButton.ToolTipText = "";
            this.exitButton.WaitOnLoad = false;
            this.exitButton.Zoom = 40;
            this.exitButton.ZoomSpeed = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.coverFlowPanel);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.coverScroll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CoverForm";
            this.coverFlowPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cover1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuVScrollBar coverScroll;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.FlowLayoutPanel coverFlowPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox cover1;
        private System.Windows.Forms.PictureBox cover2;
        private System.Windows.Forms.PictureBox cover3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 uploadButton;
        private Bunifu.UI.WinForms.BunifuImageButton exitButton;
    }
}