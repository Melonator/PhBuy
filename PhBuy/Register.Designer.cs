
namespace PhBuy
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.registerButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.confirmTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.passTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.nameTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mulish SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(65, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mulish SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(68, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mulish SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(65, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Confirm Password";
            // 
            // exitButton
            // 
            this.exitButton.ActiveImage = null;
            this.exitButton.AllowAnimations = true;
            this.exitButton.AllowBuffering = false;
            this.exitButton.AllowToggling = false;
            this.exitButton.AllowZooming = true;
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
            this.exitButton.ImageSize = new System.Drawing.Size(30, 30);
            this.exitButton.ImageZoomSize = new System.Drawing.Size(70, 70);
            this.exitButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("exitButton.InitialImage")));
            this.exitButton.Location = new System.Drawing.Point(434, -2);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Rotation = 0;
            this.exitButton.ShowActiveImage = true;
            this.exitButton.ShowCursorChanges = true;
            this.exitButton.ShowImageBorders = true;
            this.exitButton.ShowSizeMarkers = false;
            this.exitButton.Size = new System.Drawing.Size(70, 70);
            this.exitButton.TabIndex = 15;
            this.exitButton.ToolTipText = "";
            this.exitButton.WaitOnLoad = false;
            this.exitButton.Zoom = 40;
            this.exitButton.ZoomSpeed = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.ActiveBorderThickness = 1;
            this.registerButton.ActiveCornerRadius = 20;
            this.registerButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.registerButton.ActiveForecolor = System.Drawing.Color.White;
            this.registerButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.registerButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.registerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registerButton.BackgroundImage")));
            this.registerButton.ButtonText = "Register";
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Font = new System.Drawing.Font("Mulish", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.registerButton.IdleBorderThickness = 1;
            this.registerButton.IdleCornerRadius = 20;
            this.registerButton.IdleFillColor = System.Drawing.Color.White;
            this.registerButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.registerButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.registerButton.Location = new System.Drawing.Point(65, 511);
            this.registerButton.Margin = new System.Windows.Forms.Padding(5);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(352, 46);
            this.registerButton.TabIndex = 14;
            this.registerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // confirmTextBox
            // 
            this.confirmTextBox.AcceptsReturn = false;
            this.confirmTextBox.AcceptsTab = false;
            this.confirmTextBox.AnimationSpeed = 200;
            this.confirmTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.confirmTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.confirmTextBox.BackColor = System.Drawing.Color.White;
            this.confirmTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmTextBox.BackgroundImage")));
            this.confirmTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.confirmTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.confirmTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.confirmTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.confirmTextBox.BorderRadius = 1;
            this.confirmTextBox.BorderThickness = 2;
            this.confirmTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.confirmTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.confirmTextBox.DefaultText = "";
            this.confirmTextBox.FillColor = System.Drawing.Color.White;
            this.confirmTextBox.HideSelection = true;
            this.confirmTextBox.IconLeft = global::PhBuy.Properties.Resources.password_208px;
            this.confirmTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmTextBox.IconPadding = 10;
            this.confirmTextBox.IconRight = null;
            this.confirmTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmTextBox.Lines = new string[0];
            this.confirmTextBox.Location = new System.Drawing.Point(69, 415);
            this.confirmTextBox.MaxLength = 32767;
            this.confirmTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.confirmTextBox.Modified = false;
            this.confirmTextBox.Multiline = false;
            this.confirmTextBox.Name = "confirmTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.confirmTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.confirmTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.confirmTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.confirmTextBox.OnIdleState = stateProperties4;
            this.confirmTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.confirmTextBox.PasswordChar = '\0';
            this.confirmTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.confirmTextBox.PlaceholderText = "Enter your password";
            this.confirmTextBox.ReadOnly = false;
            this.confirmTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmTextBox.SelectedText = "";
            this.confirmTextBox.SelectionLength = 0;
            this.confirmTextBox.SelectionStart = 0;
            this.confirmTextBox.ShortcutsEnabled = true;
            this.confirmTextBox.Size = new System.Drawing.Size(348, 41);
            this.confirmTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.confirmTextBox.TabIndex = 12;
            this.confirmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.confirmTextBox.TextMarginBottom = 0;
            this.confirmTextBox.TextMarginLeft = 3;
            this.confirmTextBox.TextMarginTop = 0;
            this.confirmTextBox.TextPlaceholder = "Enter your password";
            this.confirmTextBox.UseSystemPasswordChar = false;
            this.confirmTextBox.WordWrap = true;
            // 
            // passTextBox
            // 
            this.passTextBox.AcceptsReturn = false;
            this.passTextBox.AcceptsTab = false;
            this.passTextBox.AnimationSpeed = 200;
            this.passTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passTextBox.BackColor = System.Drawing.Color.White;
            this.passTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passTextBox.BackgroundImage")));
            this.passTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.passTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.passTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.passTextBox.BorderRadius = 1;
            this.passTextBox.BorderThickness = 2;
            this.passTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.passTextBox.DefaultText = "";
            this.passTextBox.FillColor = System.Drawing.Color.White;
            this.passTextBox.HideSelection = true;
            this.passTextBox.IconLeft = global::PhBuy.Properties.Resources.password_208px;
            this.passTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.passTextBox.IconPadding = 10;
            this.passTextBox.IconRight = null;
            this.passTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.passTextBox.Lines = new string[0];
            this.passTextBox.Location = new System.Drawing.Point(69, 321);
            this.passTextBox.MaxLength = 32767;
            this.passTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.passTextBox.Modified = false;
            this.passTextBox.Multiline = false;
            this.passTextBox.Name = "passTextBox";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passTextBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.passTextBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passTextBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passTextBox.OnIdleState = stateProperties8;
            this.passTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.passTextBox.PasswordChar = '\0';
            this.passTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passTextBox.PlaceholderText = "Enter your password";
            this.passTextBox.ReadOnly = false;
            this.passTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passTextBox.SelectedText = "";
            this.passTextBox.SelectionLength = 0;
            this.passTextBox.SelectionStart = 0;
            this.passTextBox.ShortcutsEnabled = true;
            this.passTextBox.Size = new System.Drawing.Size(348, 41);
            this.passTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.passTextBox.TabIndex = 12;
            this.passTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.passTextBox.TextMarginBottom = 0;
            this.passTextBox.TextMarginLeft = 3;
            this.passTextBox.TextMarginTop = 0;
            this.passTextBox.TextPlaceholder = "Enter your password";
            this.passTextBox.UseSystemPasswordChar = false;
            this.passTextBox.WordWrap = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AcceptsReturn = false;
            this.nameTextBox.AcceptsTab = false;
            this.nameTextBox.AnimationSpeed = 200;
            this.nameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nameTextBox.BackgroundImage")));
            this.nameTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.nameTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.nameTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.nameTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.nameTextBox.BorderRadius = 1;
            this.nameTextBox.BorderThickness = 2;
            this.nameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.FillColor = System.Drawing.Color.White;
            this.nameTextBox.HideSelection = true;
            this.nameTextBox.IconLeft = global::PhBuy.Properties.Resources.user_account_208px;
            this.nameTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.IconPadding = 10;
            this.nameTextBox.IconRight = null;
            this.nameTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(69, 233);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.nameTextBox.Modified = false;
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.nameTextBox.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.nameTextBox.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.nameTextBox.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.nameTextBox.OnIdleState = stateProperties12;
            this.nameTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.nameTextBox.PlaceholderText = "Enter your name";
            this.nameTextBox.ReadOnly = false;
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.ShortcutsEnabled = true;
            this.nameTextBox.Size = new System.Drawing.Size(348, 41);
            this.nameTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.nameTextBox.TabIndex = 10;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nameTextBox.TextMarginBottom = 0;
            this.nameTextBox.TextMarginLeft = 3;
            this.nameTextBox.TextMarginTop = 0;
            this.nameTextBox.TextPlaceholder = "Enter your name";
            this.nameTextBox.UseSystemPasswordChar = false;
            this.nameTextBox.WordWrap = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mulish SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(45, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 55);
            this.label4.TabIndex = 11;
            this.label4.Text = "Welcome to ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mulish SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(282, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 55);
            this.label5.TabIndex = 11;
            this.label5.Text = "PhBuy!";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(504, 638);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmTextBox);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox passTextBox;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox nameTextBox;
        private Bunifu.UI.WinForms.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuThinButton2 registerButton;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextBox confirmTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}