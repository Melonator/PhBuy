
namespace PhBuy
{
    partial class MyProducts
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProducts));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.all = new System.Windows.Forms.Label();
            this.soldOut = new System.Windows.Forms.Label();
            this.listed = new System.Windows.Forms.Label();
            this.unlisted = new System.Windows.Forms.Label();
            this.productsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.clearButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.searchButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.stockMaxTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.stockMinTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.nameTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.unlistedSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.listedSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.soldOutSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.allSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.deleteAllButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // all
            // 
            this.all.AutoSize = true;
            this.all.Font = new System.Drawing.Font("Mulish SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.all.Location = new System.Drawing.Point(28, 34);
            this.all.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(87, 19);
            this.all.TabIndex = 20;
            this.all.Text = "All Products";
            this.all.Click += new System.EventHandler(this.label_Click);
            // 
            // soldOut
            // 
            this.soldOut.AutoSize = true;
            this.soldOut.Font = new System.Drawing.Font("Mulish SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.soldOut.Location = new System.Drawing.Point(150, 34);
            this.soldOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.soldOut.Name = "soldOut";
            this.soldOut.Size = new System.Drawing.Size(66, 19);
            this.soldOut.TabIndex = 20;
            this.soldOut.Text = "Sold Out";
            this.soldOut.Click += new System.EventHandler(this.label_Click);
            // 
            // listed
            // 
            this.listed.AutoSize = true;
            this.listed.Font = new System.Drawing.Font("Mulish SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.listed.Location = new System.Drawing.Point(268, 34);
            this.listed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.listed.Name = "listed";
            this.listed.Size = new System.Drawing.Size(49, 19);
            this.listed.TabIndex = 20;
            this.listed.Text = "Listed";
            this.listed.Click += new System.EventHandler(this.label_Click);
            // 
            // unlisted
            // 
            this.unlisted.AutoSize = true;
            this.unlisted.Font = new System.Drawing.Font("Mulish SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlisted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.unlisted.Location = new System.Drawing.Point(377, 34);
            this.unlisted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unlisted.Name = "unlisted";
            this.unlisted.Size = new System.Drawing.Size(62, 19);
            this.unlisted.TabIndex = 20;
            this.unlisted.Text = "Unlisted";
            this.unlisted.Click += new System.EventHandler(this.label_Click);
            // 
            // productsFlowLayoutPanel
            // 
            this.productsFlowLayoutPanel.AutoScroll = true;
            this.productsFlowLayoutPanel.Location = new System.Drawing.Point(12, 158);
            this.productsFlowLayoutPanel.Name = "productsFlowLayoutPanel";
            this.productsFlowLayoutPanel.Size = new System.Drawing.Size(901, 414);
            this.productsFlowLayoutPanel.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(11, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Product Name";
            this.label1.Click += new System.EventHandler(this.label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(11, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Stock";
            this.label2.Click += new System.EventHandler(this.label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(519, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Category";
            this.label3.Click += new System.EventHandler(this.label_Click);
            // 
            // categoryDropDown
            // 
            this.categoryDropDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoryDropDown.BackgroundColor = System.Drawing.Color.White;
            this.categoryDropDown.BorderColor = System.Drawing.Color.Silver;
            this.categoryDropDown.BorderRadius = 1;
            this.categoryDropDown.Color = System.Drawing.Color.Silver;
            this.categoryDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.categoryDropDown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.categoryDropDown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.categoryDropDown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.categoryDropDown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.categoryDropDown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.categoryDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.categoryDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.categoryDropDown.FillDropDown = true;
            this.categoryDropDown.FillIndicator = false;
            this.categoryDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryDropDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryDropDown.ForeColor = System.Drawing.Color.Black;
            this.categoryDropDown.FormattingEnabled = true;
            this.categoryDropDown.Icon = null;
            this.categoryDropDown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.categoryDropDown.IndicatorColor = System.Drawing.Color.Gray;
            this.categoryDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.categoryDropDown.ItemBackColor = System.Drawing.Color.White;
            this.categoryDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.categoryDropDown.ItemForeColor = System.Drawing.Color.Black;
            this.categoryDropDown.ItemHeight = 26;
            this.categoryDropDown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.categoryDropDown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.categoryDropDown.Items.AddRange(new object[] {
            "Food",
            "Books",
            "Health & Beauty",
            "Tech",
            "Fashion",
            "Others",
            "All"});
            this.categoryDropDown.ItemTopMargin = 3;
            this.categoryDropDown.Location = new System.Drawing.Point(596, 76);
            this.categoryDropDown.Name = "categoryDropDown";
            this.categoryDropDown.Size = new System.Drawing.Size(260, 32);
            this.categoryDropDown.TabIndex = 24;
            this.categoryDropDown.Text = "All";
            this.categoryDropDown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.categoryDropDown.TextLeftMargin = 5;
            // 
            // clearButton
            // 
            this.clearButton.ActiveBorderThickness = 1;
            this.clearButton.ActiveCornerRadius = 20;
            this.clearButton.ActiveFillColor = System.Drawing.Color.White;
            this.clearButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.clearButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.clearButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearButton.BackgroundImage")));
            this.clearButton.ButtonText = "Clear";
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Font = new System.Drawing.Font("Mulish", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.clearButton.IdleBorderThickness = 1;
            this.clearButton.IdleCornerRadius = 20;
            this.clearButton.IdleFillColor = System.Drawing.Color.White;
            this.clearButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.clearButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.clearButton.Location = new System.Drawing.Point(305, 117);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(83, 30);
            this.clearButton.TabIndex = 28;
            this.clearButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.ActiveBorderThickness = 1;
            this.searchButton.ActiveCornerRadius = 20;
            this.searchButton.ActiveFillColor = System.Drawing.Color.White;
            this.searchButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.searchButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            this.searchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.ButtonText = "Search";
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Mulish", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.searchButton.IdleBorderThickness = 1;
            this.searchButton.IdleCornerRadius = 20;
            this.searchButton.IdleFillColor = System.Drawing.Color.White;
            this.searchButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.searchButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.searchButton.Location = new System.Drawing.Point(403, 117);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 30);
            this.searchButton.TabIndex = 27;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // stockMaxTextBox
            // 
            this.stockMaxTextBox.AcceptsReturn = false;
            this.stockMaxTextBox.AcceptsTab = false;
            this.stockMaxTextBox.AnimationSpeed = 200;
            this.stockMaxTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.stockMaxTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.stockMaxTextBox.BackColor = System.Drawing.Color.Transparent;
            this.stockMaxTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stockMaxTextBox.BackgroundImage")));
            this.stockMaxTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.stockMaxTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.stockMaxTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.stockMaxTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.stockMaxTextBox.BorderRadius = 1;
            this.stockMaxTextBox.BorderThickness = 1;
            this.stockMaxTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.stockMaxTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stockMaxTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.stockMaxTextBox.DefaultText = "";
            this.stockMaxTextBox.FillColor = System.Drawing.Color.White;
            this.stockMaxTextBox.HideSelection = true;
            this.stockMaxTextBox.IconLeft = null;
            this.stockMaxTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.stockMaxTextBox.IconPadding = 10;
            this.stockMaxTextBox.IconRight = null;
            this.stockMaxTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.stockMaxTextBox.Lines = new string[0];
            this.stockMaxTextBox.Location = new System.Drawing.Point(190, 115);
            this.stockMaxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.stockMaxTextBox.MaxLength = 32767;
            this.stockMaxTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.stockMaxTextBox.Modified = false;
            this.stockMaxTextBox.Multiline = false;
            this.stockMaxTextBox.Name = "stockMaxTextBox";
            stateProperties13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.stockMaxTextBox.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.stockMaxTextBox.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.stockMaxTextBox.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.stockMaxTextBox.OnIdleState = stateProperties16;
            this.stockMaxTextBox.Padding = new System.Windows.Forms.Padding(2);
            this.stockMaxTextBox.PasswordChar = '\0';
            this.stockMaxTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.stockMaxTextBox.PlaceholderText = "Maximum";
            this.stockMaxTextBox.ReadOnly = false;
            this.stockMaxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stockMaxTextBox.SelectedText = "";
            this.stockMaxTextBox.SelectionLength = 0;
            this.stockMaxTextBox.SelectionStart = 0;
            this.stockMaxTextBox.ShortcutsEnabled = true;
            this.stockMaxTextBox.Size = new System.Drawing.Size(107, 33);
            this.stockMaxTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.stockMaxTextBox.TabIndex = 23;
            this.stockMaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stockMaxTextBox.TextMarginBottom = 0;
            this.stockMaxTextBox.TextMarginLeft = 3;
            this.stockMaxTextBox.TextMarginTop = 0;
            this.stockMaxTextBox.TextPlaceholder = "Maximum";
            this.stockMaxTextBox.UseSystemPasswordChar = false;
            this.stockMaxTextBox.WordWrap = true;
            // 
            // stockMinTextBox
            // 
            this.stockMinTextBox.AcceptsReturn = false;
            this.stockMinTextBox.AcceptsTab = false;
            this.stockMinTextBox.AnimationSpeed = 200;
            this.stockMinTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.stockMinTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.stockMinTextBox.BackColor = System.Drawing.Color.Transparent;
            this.stockMinTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stockMinTextBox.BackgroundImage")));
            this.stockMinTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.stockMinTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.stockMinTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.stockMinTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.stockMinTextBox.BorderRadius = 1;
            this.stockMinTextBox.BorderThickness = 1;
            this.stockMinTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.stockMinTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stockMinTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.stockMinTextBox.DefaultText = "";
            this.stockMinTextBox.FillColor = System.Drawing.Color.White;
            this.stockMinTextBox.HideSelection = true;
            this.stockMinTextBox.IconLeft = null;
            this.stockMinTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.stockMinTextBox.IconPadding = 10;
            this.stockMinTextBox.IconRight = null;
            this.stockMinTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.stockMinTextBox.Lines = new string[0];
            this.stockMinTextBox.Location = new System.Drawing.Point(62, 115);
            this.stockMinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.stockMinTextBox.MaxLength = 32767;
            this.stockMinTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.stockMinTextBox.Modified = false;
            this.stockMinTextBox.Multiline = false;
            this.stockMinTextBox.Name = "stockMinTextBox";
            stateProperties17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.stockMinTextBox.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.stockMinTextBox.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.stockMinTextBox.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.stockMinTextBox.OnIdleState = stateProperties20;
            this.stockMinTextBox.Padding = new System.Windows.Forms.Padding(2);
            this.stockMinTextBox.PasswordChar = '\0';
            this.stockMinTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.stockMinTextBox.PlaceholderText = "Minimum";
            this.stockMinTextBox.ReadOnly = false;
            this.stockMinTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stockMinTextBox.SelectedText = "";
            this.stockMinTextBox.SelectionLength = 0;
            this.stockMinTextBox.SelectionStart = 0;
            this.stockMinTextBox.ShortcutsEnabled = true;
            this.stockMinTextBox.Size = new System.Drawing.Size(107, 33);
            this.stockMinTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.stockMinTextBox.TabIndex = 23;
            this.stockMinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stockMinTextBox.TextMarginBottom = 0;
            this.stockMinTextBox.TextMarginLeft = 3;
            this.stockMinTextBox.TextMarginTop = 0;
            this.stockMinTextBox.TextPlaceholder = "Minimum";
            this.stockMinTextBox.UseSystemPasswordChar = false;
            this.stockMinTextBox.WordWrap = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AcceptsReturn = false;
            this.nameTextBox.AcceptsTab = false;
            this.nameTextBox.AnimationSpeed = 200;
            this.nameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.nameTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nameTextBox.BackgroundImage")));
            this.nameTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.nameTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.nameTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.nameTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.nameTextBox.BorderRadius = 1;
            this.nameTextBox.BorderThickness = 1;
            this.nameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.FillColor = System.Drawing.Color.White;
            this.nameTextBox.HideSelection = true;
            this.nameTextBox.IconLeft = null;
            this.nameTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.IconPadding = 10;
            this.nameTextBox.IconRight = null;
            this.nameTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(120, 75);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.nameTextBox.Modified = false;
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            stateProperties21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.nameTextBox.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.nameTextBox.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(58)))), ((int)(((byte)(39)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.nameTextBox.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.nameTextBox.OnIdleState = stateProperties24;
            this.nameTextBox.Padding = new System.Windows.Forms.Padding(2);
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.nameTextBox.PlaceholderText = "Enter Product Name";
            this.nameTextBox.ReadOnly = false;
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.ShortcutsEnabled = true;
            this.nameTextBox.Size = new System.Drawing.Size(364, 33);
            this.nameTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.nameTextBox.TabIndex = 23;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTextBox.TextMarginBottom = 0;
            this.nameTextBox.TextMarginLeft = 3;
            this.nameTextBox.TextMarginTop = 0;
            this.nameTextBox.TextPlaceholder = "Enter Product Name";
            this.nameTextBox.UseSystemPasswordChar = false;
            this.nameTextBox.WordWrap = true;
            // 
            // unlistedSeparator
            // 
            this.unlistedSeparator.BackColor = System.Drawing.Color.Transparent;
            this.unlistedSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("unlistedSeparator.BackgroundImage")));
            this.unlistedSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.unlistedSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.unlistedSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.unlistedSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.unlistedSeparator.LineThickness = 1;
            this.unlistedSeparator.Location = new System.Drawing.Point(381, 56);
            this.unlistedSeparator.Name = "unlistedSeparator";
            this.unlistedSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.unlistedSeparator.Size = new System.Drawing.Size(51, 14);
            this.unlistedSeparator.TabIndex = 21;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(171, 124);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(17, 14);
            this.bunifuSeparator2.TabIndex = 21;
            // 
            // listedSeparator
            // 
            this.listedSeparator.BackColor = System.Drawing.Color.Transparent;
            this.listedSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listedSeparator.BackgroundImage")));
            this.listedSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listedSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.listedSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.listedSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.listedSeparator.LineThickness = 1;
            this.listedSeparator.Location = new System.Drawing.Point(272, 56);
            this.listedSeparator.Name = "listedSeparator";
            this.listedSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.listedSeparator.Size = new System.Drawing.Size(45, 14);
            this.listedSeparator.TabIndex = 21;
            // 
            // soldOutSeparator
            // 
            this.soldOutSeparator.BackColor = System.Drawing.Color.Transparent;
            this.soldOutSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soldOutSeparator.BackgroundImage")));
            this.soldOutSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soldOutSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.soldOutSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.soldOutSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.soldOutSeparator.LineThickness = 1;
            this.soldOutSeparator.Location = new System.Drawing.Point(154, 56);
            this.soldOutSeparator.Name = "soldOutSeparator";
            this.soldOutSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.soldOutSeparator.Size = new System.Drawing.Size(62, 14);
            this.soldOutSeparator.TabIndex = 21;
            // 
            // allSeparator
            // 
            this.allSeparator.BackColor = System.Drawing.Color.Transparent;
            this.allSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allSeparator.BackgroundImage")));
            this.allSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.allSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.allSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.allSeparator.LineThickness = 1;
            this.allSeparator.Location = new System.Drawing.Point(32, 56);
            this.allSeparator.Name = "allSeparator";
            this.allSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.allSeparator.Size = new System.Drawing.Size(83, 14);
            this.allSeparator.TabIndex = 21;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 56);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(901, 14);
            this.bunifuSeparator1.TabIndex = 0;
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.AllowAnimations = true;
            this.deleteAllButton.AllowMouseEffects = true;
            this.deleteAllButton.AllowToggling = false;
            this.deleteAllButton.AnimationSpeed = 200;
            this.deleteAllButton.AutoGenerateColors = false;
            this.deleteAllButton.AutoRoundBorders = false;
            this.deleteAllButton.AutoSizeLeftIcon = true;
            this.deleteAllButton.AutoSizeRightIcon = true;
            this.deleteAllButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteAllButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.deleteAllButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteAllButton.BackgroundImage")));
            this.deleteAllButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteAllButton.ButtonText = "Delete Selected";
            this.deleteAllButton.ButtonTextMarginLeft = 0;
            this.deleteAllButton.ColorContrastOnClick = 45;
            this.deleteAllButton.ColorContrastOnHover = 45;
            this.deleteAllButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.deleteAllButton.CustomizableEdges = borderEdges2;
            this.deleteAllButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteAllButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.deleteAllButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.deleteAllButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.deleteAllButton.Enabled = false;
            this.deleteAllButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.deleteAllButton.Font = new System.Drawing.Font("Mulish", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAllButton.ForeColor = System.Drawing.Color.White;
            this.deleteAllButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteAllButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.deleteAllButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.deleteAllButton.IconMarginLeft = 11;
            this.deleteAllButton.IconPadding = 10;
            this.deleteAllButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteAllButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.deleteAllButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.deleteAllButton.IconSize = 25;
            this.deleteAllButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.deleteAllButton.IdleBorderRadius = 1;
            this.deleteAllButton.IdleBorderThickness = 1;
            this.deleteAllButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.deleteAllButton.IdleIconLeftImage = null;
            this.deleteAllButton.IdleIconRightImage = null;
            this.deleteAllButton.IndicateFocus = false;
            this.deleteAllButton.Location = new System.Drawing.Point(727, 121);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.deleteAllButton.OnDisabledState.BorderRadius = 1;
            this.deleteAllButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteAllButton.OnDisabledState.BorderThickness = 1;
            this.deleteAllButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.deleteAllButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.deleteAllButton.OnDisabledState.IconLeftImage = null;
            this.deleteAllButton.OnDisabledState.IconRightImage = null;
            this.deleteAllButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
            this.deleteAllButton.onHoverState.BorderRadius = 1;
            this.deleteAllButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteAllButton.onHoverState.BorderThickness = 1;
            this.deleteAllButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
            this.deleteAllButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.deleteAllButton.onHoverState.IconLeftImage = null;
            this.deleteAllButton.onHoverState.IconRightImage = null;
            this.deleteAllButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.deleteAllButton.OnIdleState.BorderRadius = 1;
            this.deleteAllButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteAllButton.OnIdleState.BorderThickness = 1;
            this.deleteAllButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.deleteAllButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.deleteAllButton.OnIdleState.IconLeftImage = null;
            this.deleteAllButton.OnIdleState.IconRightImage = null;
            this.deleteAllButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(150)))), ((int)(((byte)(94)))));
            this.deleteAllButton.OnPressedState.BorderRadius = 1;
            this.deleteAllButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteAllButton.OnPressedState.BorderThickness = 1;
            this.deleteAllButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(150)))), ((int)(((byte)(94)))));
            this.deleteAllButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.deleteAllButton.OnPressedState.IconLeftImage = null;
            this.deleteAllButton.OnPressedState.IconRightImage = null;
            this.deleteAllButton.Size = new System.Drawing.Size(129, 30);
            this.deleteAllButton.TabIndex = 29;
            this.deleteAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteAllButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteAllButton.TextMarginLeft = 0;
            this.deleteAllButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.deleteAllButton.UseDefaultRadiusAndThickness = true;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click);
            // 
            // MyProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(925, 584);
            this.Controls.Add(this.deleteAllButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.categoryDropDown);
            this.Controls.Add(this.stockMaxTextBox);
            this.Controls.Add(this.stockMinTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.productsFlowLayoutPanel);
            this.Controls.Add(this.unlistedSeparator);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.listedSeparator);
            this.Controls.Add(this.soldOutSeparator);
            this.Controls.Add(this.allSeparator);
            this.Controls.Add(this.unlisted);
            this.Controls.Add(this.listed);
            this.Controls.Add(this.soldOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.all);
            this.Controls.Add(this.bunifuSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyProducts";
            this.Text = "MyProducts";
            this.Load += new System.EventHandler(this.MyProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuSeparator unlistedSeparator;
        private Bunifu.UI.WinForms.BunifuSeparator listedSeparator;
        private Bunifu.UI.WinForms.BunifuSeparator soldOutSeparator;
        private Bunifu.UI.WinForms.BunifuSeparator allSeparator;
        private System.Windows.Forms.Label unlisted;
        private System.Windows.Forms.Label listed;
        private System.Windows.Forms.Label soldOut;
        private System.Windows.Forms.Label all;
        private System.Windows.Forms.FlowLayoutPanel productsFlowLayoutPanel;
        private Bunifu.UI.WinForms.BunifuTextBox stockMaxTextBox;
        private Bunifu.UI.WinForms.BunifuTextBox stockMinTextBox;
        private Bunifu.UI.WinForms.BunifuTextBox nameTextBox;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 clearButton;
        private Bunifu.Framework.UI.BunifuThinButton2 searchButton;
        private Bunifu.UI.WinForms.BunifuDropdown categoryDropDown;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton deleteAllButton;
    }
}