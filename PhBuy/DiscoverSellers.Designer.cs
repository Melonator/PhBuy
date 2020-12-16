
namespace PhBuy
{
    partial class DiscoverSellers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscoverSellers));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sellerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.typeDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label8 = new System.Windows.Forms.Label();
            this.sortDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.startFilterButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sellerFlowLayoutPanel
            // 
            this.sellerFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sellerFlowLayoutPanel.Location = new System.Drawing.Point(160, 0);
            this.sellerFlowLayoutPanel.Name = "sellerFlowLayoutPanel";
            this.sellerFlowLayoutPanel.Size = new System.Drawing.Size(730, 593);
            this.sellerFlowLayoutPanel.TabIndex = 0;
            // 
            // typeDropDown
            // 
            this.typeDropDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.typeDropDown.BackgroundColor = System.Drawing.Color.White;
            this.typeDropDown.BorderColor = System.Drawing.Color.Silver;
            this.typeDropDown.BorderRadius = 1;
            this.typeDropDown.Color = System.Drawing.Color.Silver;
            this.typeDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.typeDropDown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.typeDropDown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.typeDropDown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.typeDropDown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.typeDropDown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.typeDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typeDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.typeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.typeDropDown.FillDropDown = true;
            this.typeDropDown.FillIndicator = false;
            this.typeDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeDropDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.typeDropDown.ForeColor = System.Drawing.Color.Black;
            this.typeDropDown.FormattingEnabled = true;
            this.typeDropDown.Icon = null;
            this.typeDropDown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.typeDropDown.IndicatorColor = System.Drawing.Color.Gray;
            this.typeDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.typeDropDown.ItemBackColor = System.Drawing.Color.White;
            this.typeDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.typeDropDown.ItemForeColor = System.Drawing.Color.Black;
            this.typeDropDown.ItemHeight = 26;
            this.typeDropDown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.typeDropDown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.typeDropDown.Items.AddRange(new object[] {
            "Fashion",
            "Food",
            "Tech",
            "Books",
            "Health & Beauty",
            "Others"});
            this.typeDropDown.ItemTopMargin = 3;
            this.typeDropDown.Location = new System.Drawing.Point(7, 87);
            this.typeDropDown.Name = "typeDropDown";
            this.typeDropDown.Size = new System.Drawing.Size(147, 32);
            this.typeDropDown.TabIndex = 1;
            this.typeDropDown.Text = null;
            this.typeDropDown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.typeDropDown.TextLeftMargin = 5;
            this.typeDropDown.SelectedIndexChanged += new System.EventHandler(this.typeDropDown_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(3, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 34;
            this.label8.Text = "Select Type";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sortDropDown
            // 
            this.sortDropDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sortDropDown.BackgroundColor = System.Drawing.Color.White;
            this.sortDropDown.BorderColor = System.Drawing.Color.Silver;
            this.sortDropDown.BorderRadius = 1;
            this.sortDropDown.Color = System.Drawing.Color.Silver;
            this.sortDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.sortDropDown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sortDropDown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sortDropDown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sortDropDown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sortDropDown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.sortDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sortDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.sortDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.sortDropDown.FillDropDown = true;
            this.sortDropDown.FillIndicator = false;
            this.sortDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortDropDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sortDropDown.ForeColor = System.Drawing.Color.Black;
            this.sortDropDown.FormattingEnabled = true;
            this.sortDropDown.Icon = null;
            this.sortDropDown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.sortDropDown.IndicatorColor = System.Drawing.Color.Gray;
            this.sortDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.sortDropDown.ItemBackColor = System.Drawing.Color.White;
            this.sortDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.sortDropDown.ItemForeColor = System.Drawing.Color.Black;
            this.sortDropDown.ItemHeight = 26;
            this.sortDropDown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.sortDropDown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.sortDropDown.ItemTopMargin = 3;
            this.sortDropDown.Location = new System.Drawing.Point(7, 288);
            this.sortDropDown.Name = "sortDropDown";
            this.sortDropDown.Size = new System.Drawing.Size(147, 32);
            this.sortDropDown.TabIndex = 1;
            this.sortDropDown.Text = null;
            this.sortDropDown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.sortDropDown.TextLeftMargin = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(3, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sort";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Filter";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // typeFlowLayoutPanel
            // 
            this.typeFlowLayoutPanel.Location = new System.Drawing.Point(7, 122);
            this.typeFlowLayoutPanel.Name = "typeFlowLayoutPanel";
            this.typeFlowLayoutPanel.Size = new System.Drawing.Size(147, 119);
            this.typeFlowLayoutPanel.TabIndex = 0;
            // 
            // startFilterButton
            // 
            this.startFilterButton.AllowAnimations = true;
            this.startFilterButton.AllowMouseEffects = true;
            this.startFilterButton.AllowToggling = false;
            this.startFilterButton.AnimationSpeed = 200;
            this.startFilterButton.AutoGenerateColors = false;
            this.startFilterButton.AutoRoundBorders = false;
            this.startFilterButton.AutoSizeLeftIcon = true;
            this.startFilterButton.AutoSizeRightIcon = true;
            this.startFilterButton.BackColor = System.Drawing.Color.Transparent;
            this.startFilterButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.startFilterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startFilterButton.BackgroundImage")));
            this.startFilterButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startFilterButton.ButtonText = "Start Filter";
            this.startFilterButton.ButtonTextMarginLeft = 0;
            this.startFilterButton.ColorContrastOnClick = 45;
            this.startFilterButton.ColorContrastOnHover = 45;
            this.startFilterButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.startFilterButton.CustomizableEdges = borderEdges1;
            this.startFilterButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startFilterButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.startFilterButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.startFilterButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.startFilterButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.startFilterButton.Font = new System.Drawing.Font("Mulish SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startFilterButton.ForeColor = System.Drawing.Color.White;
            this.startFilterButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startFilterButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.startFilterButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.startFilterButton.IconMarginLeft = 11;
            this.startFilterButton.IconPadding = 10;
            this.startFilterButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startFilterButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.startFilterButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.startFilterButton.IconSize = 25;
            this.startFilterButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.startFilterButton.IdleBorderRadius = 1;
            this.startFilterButton.IdleBorderThickness = 1;
            this.startFilterButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.startFilterButton.IdleIconLeftImage = null;
            this.startFilterButton.IdleIconRightImage = null;
            this.startFilterButton.IndicateFocus = false;
            this.startFilterButton.Location = new System.Drawing.Point(7, 341);
            this.startFilterButton.Name = "startFilterButton";
            this.startFilterButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.startFilterButton.OnDisabledState.BorderRadius = 1;
            this.startFilterButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startFilterButton.OnDisabledState.BorderThickness = 1;
            this.startFilterButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.startFilterButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.startFilterButton.OnDisabledState.IconLeftImage = null;
            this.startFilterButton.OnDisabledState.IconRightImage = null;
            this.startFilterButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
            this.startFilterButton.onHoverState.BorderRadius = 1;
            this.startFilterButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startFilterButton.onHoverState.BorderThickness = 1;
            this.startFilterButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
            this.startFilterButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.startFilterButton.onHoverState.IconLeftImage = null;
            this.startFilterButton.onHoverState.IconRightImage = null;
            this.startFilterButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.startFilterButton.OnIdleState.BorderRadius = 1;
            this.startFilterButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startFilterButton.OnIdleState.BorderThickness = 1;
            this.startFilterButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.startFilterButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.startFilterButton.OnIdleState.IconLeftImage = null;
            this.startFilterButton.OnIdleState.IconRightImage = null;
            this.startFilterButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(150)))), ((int)(((byte)(94)))));
            this.startFilterButton.OnPressedState.BorderRadius = 1;
            this.startFilterButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startFilterButton.OnPressedState.BorderThickness = 1;
            this.startFilterButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(150)))), ((int)(((byte)(94)))));
            this.startFilterButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.startFilterButton.OnPressedState.IconLeftImage = null;
            this.startFilterButton.OnPressedState.IconRightImage = null;
            this.startFilterButton.Size = new System.Drawing.Size(104, 30);
            this.startFilterButton.TabIndex = 37;
            this.startFilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startFilterButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.startFilterButton.TextMarginLeft = 0;
            this.startFilterButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.startFilterButton.UseDefaultRadiusAndThickness = true;
            this.startFilterButton.Click += new System.EventHandler(this.deleteAllButton_Click);
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 247);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(154, 14);
            this.bunifuSeparator1.TabIndex = 35;
            // 
            // DiscoverSellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(890, 593);
            this.Controls.Add(this.typeFlowLayoutPanel);
            this.Controls.Add(this.startFilterButton);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sortDropDown);
            this.Controls.Add(this.typeDropDown);
            this.Controls.Add(this.sellerFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiscoverSellers";
            this.Text = "DiscoverSellers";
            this.Load += new System.EventHandler(this.DiscoverSellers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuDropdown typeDropDown;
        private System.Windows.Forms.FlowLayoutPanel sellerFlowLayoutPanel;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuDropdown sortDropDown;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton startFilterButton;
        private System.Windows.Forms.FlowLayoutPanel typeFlowLayoutPanel;
    }
}