
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerSellerForm));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.mainPanel = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.sellTileButton = new Bunifu.Framework.UI.BunifuTileButton();
			this.buyTileButton = new Bunifu.Framework.UI.BunifuTileButton();
			this.registerButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
			this.mainPanel.Controls.Add(this.registerButton);
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(156, 30);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(447, 55);
			this.label4.TabIndex = 12;
			this.label4.Text = "Would you like to...";
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
			// registerButton
			// 
			this.registerButton.AllowAnimations = true;
			this.registerButton.AllowMouseEffects = true;
			this.registerButton.AllowToggling = false;
			this.registerButton.AnimationSpeed = 200;
			this.registerButton.AutoGenerateColors = false;
			this.registerButton.AutoRoundBorders = false;
			this.registerButton.AutoSizeLeftIcon = true;
			this.registerButton.AutoSizeRightIcon = true;
			this.registerButton.BackColor = System.Drawing.Color.Transparent;
			this.registerButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(130)))), ((int)(((byte)(55)))));
			this.registerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registerButton.BackgroundImage")));
			this.registerButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.registerButton.ButtonText = "Register";
			this.registerButton.ButtonTextMarginLeft = 0;
			this.registerButton.ColorContrastOnClick = 45;
			this.registerButton.ColorContrastOnHover = 45;
			this.registerButton.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges1.BottomLeft = true;
			borderEdges1.BottomRight = true;
			borderEdges1.TopLeft = true;
			borderEdges1.TopRight = true;
			this.registerButton.CustomizableEdges = borderEdges1;
			this.registerButton.DialogResult = System.Windows.Forms.DialogResult.None;
			this.registerButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.registerButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.registerButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.registerButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.registerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.registerButton.ForeColor = System.Drawing.Color.White;
			this.registerButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.registerButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.registerButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.registerButton.IconMarginLeft = 11;
			this.registerButton.IconPadding = 10;
			this.registerButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.registerButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.registerButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.registerButton.IconSize = 25;
			this.registerButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(130)))), ((int)(((byte)(55)))));
			this.registerButton.IdleBorderRadius = 1;
			this.registerButton.IdleBorderThickness = 1;
			this.registerButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(130)))), ((int)(((byte)(55)))));
			this.registerButton.IdleIconLeftImage = null;
			this.registerButton.IdleIconRightImage = null;
			this.registerButton.IndicateFocus = false;
			this.registerButton.Location = new System.Drawing.Point(166, 449);
			this.registerButton.Name = "registerButton";
			this.registerButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.registerButton.OnDisabledState.BorderRadius = 1;
			this.registerButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.registerButton.OnDisabledState.BorderThickness = 1;
			this.registerButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.registerButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.registerButton.OnDisabledState.IconLeftImage = null;
			this.registerButton.OnDisabledState.IconRightImage = null;
			this.registerButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.registerButton.onHoverState.BorderRadius = 1;
			this.registerButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.registerButton.onHoverState.BorderThickness = 1;
			this.registerButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.registerButton.onHoverState.ForeColor = System.Drawing.Color.White;
			this.registerButton.onHoverState.IconLeftImage = null;
			this.registerButton.onHoverState.IconRightImage = null;
			this.registerButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(130)))), ((int)(((byte)(55)))));
			this.registerButton.OnIdleState.BorderRadius = 1;
			this.registerButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.registerButton.OnIdleState.BorderThickness = 1;
			this.registerButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(130)))), ((int)(((byte)(55)))));
			this.registerButton.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.registerButton.OnIdleState.IconLeftImage = null;
			this.registerButton.OnIdleState.IconRightImage = null;
			this.registerButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.registerButton.OnPressedState.BorderRadius = 1;
			this.registerButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.registerButton.OnPressedState.BorderThickness = 1;
			this.registerButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.registerButton.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.registerButton.OnPressedState.IconLeftImage = null;
			this.registerButton.OnPressedState.IconRightImage = null;
			this.registerButton.Size = new System.Drawing.Size(199, 39);
			this.registerButton.TabIndex = 16;
			this.registerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.registerButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.registerButton.TextMarginLeft = 0;
			this.registerButton.TextPadding = new System.Windows.Forms.Padding(0);
			this.registerButton.UseDefaultRadiusAndThickness = true;
			this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
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
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton registerButton;
	}
}