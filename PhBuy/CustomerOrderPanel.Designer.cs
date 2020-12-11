
namespace PhBuy
{
    partial class CustomerOrderPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrderPanel));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.sellerPictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.sellerNameLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.Processing = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.rateButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.deliveredButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.sellerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sellerPictureBox
            // 
            this.sellerPictureBox.AllowFocused = false;
            this.sellerPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellerPictureBox.AutoSizeHeight = true;
            this.sellerPictureBox.BorderRadius = 20;
            this.sellerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("sellerPictureBox.Image")));
            this.sellerPictureBox.IsCircle = true;
            this.sellerPictureBox.Location = new System.Drawing.Point(144, 67);
            this.sellerPictureBox.Name = "sellerPictureBox";
            this.sellerPictureBox.Size = new System.Drawing.Size(40, 40);
            this.sellerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sellerPictureBox.TabIndex = 0;
            this.sellerPictureBox.TabStop = false;
            this.sellerPictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new System.Drawing.Point(14, 13);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(120, 120);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPictureBox.TabIndex = 1;
            this.productPictureBox.TabStop = false;
            // 
            // sellerNameLabel
            // 
            this.sellerNameLabel.AutoSize = true;
            this.sellerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.sellerNameLabel.Font = new System.Drawing.Font("Mulish SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.sellerNameLabel.Location = new System.Drawing.Point(189, 76);
            this.sellerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sellerNameLabel.Name = "sellerNameLabel";
            this.sellerNameLabel.Size = new System.Drawing.Size(137, 21);
            this.sellerNameLabel.TabIndex = 10;
            this.sellerNameLabel.Text = "InfoPh Furnitures";
            this.sellerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.productNameLabel.Font = new System.Drawing.Font("Mulish", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.productNameLabel.Location = new System.Drawing.Point(139, 15);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productNameLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(289, 24);
            this.productNameLabel.TabIndex = 10;
            this.productNameLabel.Text = "Spicy Ramen | 10,000k Spice Level";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.quantityLabel.Font = new System.Drawing.Font("Mulish SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.quantityLabel.Location = new System.Drawing.Point(140, 114);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(102, 21);
            this.quantityLabel.TabIndex = 10;
            this.quantityLabel.Text = "Quantity: x1";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Processing
            // 
            this.Processing.AutoSize = true;
            this.Processing.BackColor = System.Drawing.Color.Transparent;
            this.Processing.Font = new System.Drawing.Font("Mulish", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Processing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.Processing.Location = new System.Drawing.Point(799, 27);
            this.Processing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Processing.Name = "Processing";
            this.Processing.Size = new System.Drawing.Size(58, 26);
            this.Processing.TabIndex = 11;
            this.Processing.Text = "Total";
            this.Processing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceLabel
            // 
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel.Font = new System.Drawing.Font("Mulish", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.priceLabel.Location = new System.Drawing.Point(569, 57);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(288, 33);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "₱ Price";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Mulish SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.statusLabel.Location = new System.Drawing.Point(288, 116);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(92, 21);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Processing";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(258, 114);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator1.Size = new System.Drawing.Size(14, 23);
            this.bunifuSeparator1.TabIndex = 85;
            // 
            // rateButton
            // 
            this.rateButton.AllowAnimations = true;
            this.rateButton.AllowMouseEffects = true;
            this.rateButton.AllowToggling = false;
            this.rateButton.AnimationSpeed = 200;
            this.rateButton.AutoGenerateColors = false;
            this.rateButton.AutoRoundBorders = false;
            this.rateButton.AutoSizeLeftIcon = true;
            this.rateButton.AutoSizeRightIcon = true;
            this.rateButton.BackColor = System.Drawing.Color.Transparent;
            this.rateButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.rateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rateButton.BackgroundImage")));
            this.rateButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.rateButton.ButtonText = "Rate";
            this.rateButton.ButtonTextMarginLeft = 0;
            this.rateButton.ColorContrastOnClick = 45;
            this.rateButton.ColorContrastOnHover = 45;
            this.rateButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.rateButton.CustomizableEdges = borderEdges1;
            this.rateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rateButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.rateButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.rateButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.rateButton.Enabled = false;
            this.rateButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.rateButton.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateButton.ForeColor = System.Drawing.Color.White;
            this.rateButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rateButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.rateButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.rateButton.IconMarginLeft = 11;
            this.rateButton.IconPadding = 10;
            this.rateButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rateButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.rateButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.rateButton.IconSize = 25;
            this.rateButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.rateButton.IdleBorderRadius = 1;
            this.rateButton.IdleBorderThickness = 1;
            this.rateButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.rateButton.IdleIconLeftImage = null;
            this.rateButton.IdleIconRightImage = null;
            this.rateButton.IndicateFocus = false;
            this.rateButton.Location = new System.Drawing.Point(549, 93);
            this.rateButton.Name = "rateButton";
            this.rateButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.rateButton.OnDisabledState.BorderRadius = 1;
            this.rateButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.rateButton.OnDisabledState.BorderThickness = 1;
            this.rateButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.rateButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.rateButton.OnDisabledState.IconLeftImage = null;
            this.rateButton.OnDisabledState.IconRightImage = null;
            this.rateButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
            this.rateButton.onHoverState.BorderRadius = 1;
            this.rateButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.rateButton.onHoverState.BorderThickness = 1;
            this.rateButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
            this.rateButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.rateButton.onHoverState.IconLeftImage = null;
            this.rateButton.onHoverState.IconRightImage = null;
            this.rateButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.rateButton.OnIdleState.BorderRadius = 1;
            this.rateButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.rateButton.OnIdleState.BorderThickness = 1;
            this.rateButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.rateButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.rateButton.OnIdleState.IconLeftImage = null;
            this.rateButton.OnIdleState.IconRightImage = null;
            this.rateButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(150)))), ((int)(((byte)(94)))));
            this.rateButton.OnPressedState.BorderRadius = 1;
            this.rateButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.rateButton.OnPressedState.BorderThickness = 1;
            this.rateButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(150)))), ((int)(((byte)(94)))));
            this.rateButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.rateButton.OnPressedState.IconLeftImage = null;
            this.rateButton.OnPressedState.IconRightImage = null;
            this.rateButton.Size = new System.Drawing.Size(151, 42);
            this.rateButton.TabIndex = 84;
            this.rateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rateButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.rateButton.TextMarginLeft = 0;
            this.rateButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.rateButton.UseDefaultRadiusAndThickness = true;
            // 
            // deliveredButton
            // 
            this.deliveredButton.AllowAnimations = true;
            this.deliveredButton.AllowMouseEffects = true;
            this.deliveredButton.AllowToggling = false;
            this.deliveredButton.AnimationSpeed = 200;
            this.deliveredButton.AutoGenerateColors = false;
            this.deliveredButton.AutoRoundBorders = false;
            this.deliveredButton.AutoSizeLeftIcon = true;
            this.deliveredButton.AutoSizeRightIcon = true;
            this.deliveredButton.BackColor = System.Drawing.Color.Transparent;
            this.deliveredButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.deliveredButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deliveredButton.BackgroundImage")));
            this.deliveredButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deliveredButton.ButtonText = "Order Received";
            this.deliveredButton.ButtonTextMarginLeft = 0;
            this.deliveredButton.ColorContrastOnClick = 45;
            this.deliveredButton.ColorContrastOnHover = 45;
            this.deliveredButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.deliveredButton.CustomizableEdges = borderEdges2;
            this.deliveredButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deliveredButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.deliveredButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.deliveredButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.deliveredButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.deliveredButton.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveredButton.ForeColor = System.Drawing.Color.White;
            this.deliveredButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deliveredButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.deliveredButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.deliveredButton.IconMarginLeft = 11;
            this.deliveredButton.IconPadding = 10;
            this.deliveredButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deliveredButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.deliveredButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.deliveredButton.IconSize = 25;
            this.deliveredButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.deliveredButton.IdleBorderRadius = 1;
            this.deliveredButton.IdleBorderThickness = 1;
            this.deliveredButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.deliveredButton.IdleIconLeftImage = null;
            this.deliveredButton.IdleIconRightImage = null;
            this.deliveredButton.IndicateFocus = false;
            this.deliveredButton.Location = new System.Drawing.Point(706, 93);
            this.deliveredButton.Name = "deliveredButton";
            this.deliveredButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.deliveredButton.OnDisabledState.BorderRadius = 1;
            this.deliveredButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deliveredButton.OnDisabledState.BorderThickness = 1;
            this.deliveredButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.deliveredButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.deliveredButton.OnDisabledState.IconLeftImage = null;
            this.deliveredButton.OnDisabledState.IconRightImage = null;
            this.deliveredButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
            this.deliveredButton.onHoverState.BorderRadius = 1;
            this.deliveredButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deliveredButton.onHoverState.BorderThickness = 1;
            this.deliveredButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
            this.deliveredButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.deliveredButton.onHoverState.IconLeftImage = null;
            this.deliveredButton.onHoverState.IconRightImage = null;
            this.deliveredButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.deliveredButton.OnIdleState.BorderRadius = 1;
            this.deliveredButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deliveredButton.OnIdleState.BorderThickness = 1;
            this.deliveredButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.deliveredButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.deliveredButton.OnIdleState.IconLeftImage = null;
            this.deliveredButton.OnIdleState.IconRightImage = null;
            this.deliveredButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(150)))), ((int)(((byte)(94)))));
            this.deliveredButton.OnPressedState.BorderRadius = 1;
            this.deliveredButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deliveredButton.OnPressedState.BorderThickness = 1;
            this.deliveredButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(150)))), ((int)(((byte)(94)))));
            this.deliveredButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.deliveredButton.OnPressedState.IconLeftImage = null;
            this.deliveredButton.OnPressedState.IconRightImage = null;
            this.deliveredButton.Size = new System.Drawing.Size(151, 42);
            this.deliveredButton.TabIndex = 84;
            this.deliveredButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deliveredButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.deliveredButton.TextMarginLeft = 0;
            this.deliveredButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.deliveredButton.UseDefaultRadiusAndThickness = true;
            // 
            // CustomerOrderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.deliveredButton);
            this.Controls.Add(this.rateButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.Processing);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.sellerNameLabel);
            this.Controls.Add(this.productPictureBox);
            this.Controls.Add(this.sellerPictureBox);
            this.Enabled = false;
            this.Name = "CustomerOrderPanel";
            this.Size = new System.Drawing.Size(870, 146);
            ((System.ComponentModel.ISupportInitialize)(this.sellerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Processing;
        public Bunifu.UI.WinForms.BunifuPictureBox sellerPictureBox;
        public System.Windows.Forms.PictureBox productPictureBox;
        public System.Windows.Forms.Label sellerNameLabel;
        public System.Windows.Forms.Label productNameLabel;
        public System.Windows.Forms.Label quantityLabel;
        public System.Windows.Forms.Label priceLabel;
        public System.Windows.Forms.Label statusLabel;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton rateButton;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton deliveredButton;
    }
}
