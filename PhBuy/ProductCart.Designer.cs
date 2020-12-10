
namespace PhBuy
{
    partial class ProductCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCart));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.priceLabel = new System.Windows.Forms.Label();
            this.subtractButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.deleteButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.addButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.quantityTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.White;
            this.priceLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceLabel.Font = new System.Drawing.Font("Mulish SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.priceLabel.Location = new System.Drawing.Point(418, 55);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(64, 21);
            this.priceLabel.TabIndex = 69;
            this.priceLabel.Text = "₱ 1240";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subtractButton
            // 
            this.subtractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.subtractButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.subtractButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
            this.subtractButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subtractButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.subtractButton.ForeColor = System.Drawing.Color.White;
            this.subtractButton.Image = global::PhBuy.Properties.Resources.subtract_208px;
            this.subtractButton.ImagePosition = 9;
            this.subtractButton.ImageZoom = 50;
            this.subtractButton.LabelPosition = 0;
            this.subtractButton.LabelText = "";
            this.subtractButton.Location = new System.Drawing.Point(536, 47);
            this.subtractButton.Margin = new System.Windows.Forms.Padding(6);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(38, 39);
            this.subtractButton.TabIndex = 71;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.color = System.Drawing.Color.Transparent;
            this.deleteButton.colorActive = System.Drawing.Color.Gray;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Image = global::PhBuy.Properties.Resources.Trash;
            this.deleteButton.ImagePosition = 5;
            this.deleteButton.ImageZoom = 70;
            this.deleteButton.LabelPosition = 0;
            this.deleteButton.LabelText = "";
            this.deleteButton.Location = new System.Drawing.Point(733, 46);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(38, 39);
            this.deleteButton.TabIndex = 72;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.addButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.addButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Image = global::PhBuy.Properties.Resources.plus_math_208px;
            this.addButton.ImagePosition = 9;
            this.addButton.ImageZoom = 50;
            this.addButton.LabelPosition = 0;
            this.addButton.LabelText = "";
            this.addButton.Location = new System.Drawing.Point(638, 47);
            this.addButton.Margin = new System.Windows.Forms.Padding(6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(38, 39);
            this.addButton.TabIndex = 73;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.AcceptsReturn = false;
            this.quantityTextBox.AcceptsTab = false;
            this.quantityTextBox.AnimationSpeed = 200;
            this.quantityTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.quantityTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.quantityTextBox.BackColor = System.Drawing.Color.Transparent;
            this.quantityTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quantityTextBox.BackgroundImage")));
            this.quantityTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.quantityTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.quantityTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.quantityTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.quantityTextBox.BorderRadius = 1;
            this.quantityTextBox.BorderThickness = 1;
            this.quantityTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.quantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityTextBox.DefaultFont = new System.Drawing.Font("Mulish SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.DefaultText = "1";
            this.quantityTextBox.FillColor = System.Drawing.Color.White;
            this.quantityTextBox.HideSelection = true;
            this.quantityTextBox.IconLeft = null;
            this.quantityTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityTextBox.IconPadding = 10;
            this.quantityTextBox.IconRight = null;
            this.quantityTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityTextBox.Lines = new string[] {
        "1"};
            this.quantityTextBox.Location = new System.Drawing.Point(573, 46);
            this.quantityTextBox.MaxLength = 32767;
            this.quantityTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.quantityTextBox.Modified = false;
            this.quantityTextBox.Multiline = false;
            this.quantityTextBox.Name = "quantityTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.quantityTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.quantityTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.quantityTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.quantityTextBox.OnIdleState = stateProperties4;
            this.quantityTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.quantityTextBox.PasswordChar = '\0';
            this.quantityTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.quantityTextBox.PlaceholderText = "";
            this.quantityTextBox.ReadOnly = false;
            this.quantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.quantityTextBox.SelectedText = "";
            this.quantityTextBox.SelectionLength = 0;
            this.quantityTextBox.SelectionStart = 1;
            this.quantityTextBox.ShortcutsEnabled = true;
            this.quantityTextBox.Size = new System.Drawing.Size(67, 41);
            this.quantityTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.quantityTextBox.TabIndex = 70;
            this.quantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityTextBox.TextMarginBottom = 0;
            this.quantityTextBox.TextMarginLeft = 3;
            this.quantityTextBox.TextMarginTop = 0;
            this.quantityTextBox.TextPlaceholder = "";
            this.quantityTextBox.UseSystemPasswordChar = false;
            this.quantityTextBox.WordWrap = true;
            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new System.Drawing.Point(42, 13);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(110, 110);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPictureBox.TabIndex = 68;
            this.productPictureBox.TabStop = false;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.BackColor = System.Drawing.Color.White;
            this.productNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productNameLabel.Font = new System.Drawing.Font("Mulish SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.productNameLabel.Location = new System.Drawing.Point(157, 13);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productNameLabel.MaximumSize = new System.Drawing.Size(210, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(189, 84);
            this.productNameLabel.TabIndex = 69;
            this.productNameLabel.Text = "PRODUCT NAME HERE!PRODUCT NAME HERE!PRODUCT NAME HERE!";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(7, 61);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 74;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // ProductCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.productPictureBox);
            this.Name = "ProductCart";
            this.Size = new System.Drawing.Size(879, 137);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton subtractButton;
        private Bunifu.Framework.UI.BunifuTileButton addButton;
        public Bunifu.Framework.UI.BunifuTileButton deleteButton;
        public Bunifu.UI.WinForms.BunifuTextBox quantityTextBox;
        public System.Windows.Forms.Label priceLabel;
        public System.Windows.Forms.PictureBox productPictureBox;
        public System.Windows.Forms.Label productNameLabel;
        public System.Windows.Forms.CheckBox checkBox;
    }
}
