
namespace PhBuy
{
    partial class DatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label9 = new System.Windows.Forms.Label();
            this.exitButton = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 113);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(917, 379);
            this.dataGridView.TabIndex = 0;
            // 
            // tableDropDown
            // 
            this.tableDropDown.BackColor = System.Drawing.SystemColors.Control;
            this.tableDropDown.BackgroundColor = System.Drawing.Color.White;
            this.tableDropDown.BorderColor = System.Drawing.Color.Silver;
            this.tableDropDown.BorderRadius = 1;
            this.tableDropDown.Color = System.Drawing.Color.Silver;
            this.tableDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.tableDropDown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tableDropDown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tableDropDown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tableDropDown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tableDropDown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.tableDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tableDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.tableDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.tableDropDown.FillDropDown = true;
            this.tableDropDown.FillIndicator = false;
            this.tableDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableDropDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tableDropDown.ForeColor = System.Drawing.Color.Black;
            this.tableDropDown.FormattingEnabled = true;
            this.tableDropDown.Icon = null;
            this.tableDropDown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.tableDropDown.IndicatorColor = System.Drawing.Color.Gray;
            this.tableDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.tableDropDown.ItemBackColor = System.Drawing.Color.White;
            this.tableDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.tableDropDown.ItemForeColor = System.Drawing.Color.Black;
            this.tableDropDown.ItemHeight = 26;
            this.tableDropDown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.tableDropDown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.tableDropDown.ItemTopMargin = 3;
            this.tableDropDown.Location = new System.Drawing.Point(12, 58);
            this.tableDropDown.Name = "tableDropDown";
            this.tableDropDown.Size = new System.Drawing.Size(260, 32);
            this.tableDropDown.TabIndex = 1;
            this.tableDropDown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.tableDropDown.TextLeftMargin = 5;
            this.tableDropDown.SelectedIndexChanged += new System.EventHandler(this.tableDropDown_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mulish SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(12, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 55);
            this.label9.TabIndex = 49;
            this.label9.Text = "Table";
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
            this.exitButton.Location = new System.Drawing.Point(871, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Rotation = 0;
            this.exitButton.ShowActiveImage = true;
            this.exitButton.ShowCursorChanges = true;
            this.exitButton.ShowImageBorders = true;
            this.exitButton.ShowSizeMarkers = false;
            this.exitButton.Size = new System.Drawing.Size(70, 70);
            this.exitButton.TabIndex = 50;
            this.exitButton.ToolTipText = "";
            this.exitButton.WaitOnLoad = false;
            this.exitButton.Zoom = 40;
            this.exitButton.ZoomSpeed = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 504);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tableDropDown);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatabaseForm";
            this.Text = "DatabaseForm";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dataGridView;
        private Bunifu.UI.WinForms.BunifuDropdown tableDropDown;
        private System.Windows.Forms.Label label9;
        private Bunifu.UI.WinForms.BunifuImageButton exitButton;
    }
}