
namespace MegaDeskAngeles
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.ButtonMainMenu = new System.Windows.Forms.Button();
            this.TextBoxWidth = new System.Windows.Forms.TextBox();
            this.LabelCustomerName = new System.Windows.Forms.Label();
            this.TextBoxCustomerName = new System.Windows.Forms.TextBox();
            this.LabelWidth = new System.Windows.Forms.Label();
            this.LabelDeskSpecifications = new System.Windows.Forms.Label();
            this.LabelDepth = new System.Windows.Forms.Label();
            this.TextBoxDepth = new System.Windows.Forms.TextBox();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelMaterial = new System.Windows.Forms.Label();
            this.LabelDrawers = new System.Windows.Forms.Label();
            this.ComboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.ButtonGetQuote = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.UpDownDrawers = new System.Windows.Forms.NumericUpDown();
            this.RushBox = new System.Windows.Forms.ComboBox();
            this.RushLabel = new System.Windows.Forms.Label();
            this.deskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonMainMenu
            // 
            this.ButtonMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonMainMenu.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMainMenu.Location = new System.Drawing.Point(15, 477);
            this.ButtonMainMenu.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.ButtonMainMenu.Name = "ButtonMainMenu";
            this.ButtonMainMenu.Padding = new System.Windows.Forms.Padding(10, 14, 10, 14);
            this.ButtonMainMenu.Size = new System.Drawing.Size(221, 63);
            this.ButtonMainMenu.TabIndex = 8;
            this.ButtonMainMenu.Text = "Main Menu";
            this.ButtonMainMenu.UseVisualStyleBackColor = true;
            this.ButtonMainMenu.Click += new System.EventHandler(this.ButtonMainMenu_Click);
            // 
            // TextBoxWidth
            // 
            this.TextBoxWidth.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxWidth.Location = new System.Drawing.Point(187, 175);
            this.TextBoxWidth.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.TextBoxWidth.Name = "TextBoxWidth";
            this.TextBoxWidth.Size = new System.Drawing.Size(274, 37);
            this.TextBoxWidth.TabIndex = 2;
            this.TextBoxWidth.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxWidth_Validating);
            // 
            // LabelCustomerName
            // 
            this.LabelCustomerName.AutoSize = true;
            this.LabelCustomerName.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomerName.Location = new System.Drawing.Point(15, 116);
            this.LabelCustomerName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelCustomerName.Name = "LabelCustomerName";
            this.LabelCustomerName.Size = new System.Drawing.Size(130, 29);
            this.LabelCustomerName.TabIndex = 9;
            this.LabelCustomerName.Text = "Customer Name:";
            // 
            // TextBoxCustomerName
            // 
            this.TextBoxCustomerName.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCustomerName.Location = new System.Drawing.Point(187, 113);
            this.TextBoxCustomerName.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.TextBoxCustomerName.Name = "TextBoxCustomerName";
            this.TextBoxCustomerName.Size = new System.Drawing.Size(274, 37);
            this.TextBoxCustomerName.TabIndex = 1;
            this.TextBoxCustomerName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxCustomerName_Validating);
            // 
            // LabelWidth
            // 
            this.LabelWidth.AutoSize = true;
            this.LabelWidth.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWidth.Location = new System.Drawing.Point(15, 178);
            this.LabelWidth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelWidth.Name = "LabelWidth";
            this.LabelWidth.Size = new System.Drawing.Size(114, 29);
            this.LabelWidth.TabIndex = 10;
            this.LabelWidth.Text = "Width (24-96):";
            // 
            // LabelDeskSpecifications
            // 
            this.LabelDeskSpecifications.AutoSize = true;
            this.LabelDeskSpecifications.Font = new System.Drawing.Font("Myanmar Text", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeskSpecifications.Location = new System.Drawing.Point(205, 9);
            this.LabelDeskSpecifications.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDeskSpecifications.Name = "LabelDeskSpecifications";
            this.LabelDeskSpecifications.Size = new System.Drawing.Size(312, 56);
            this.LabelDeskSpecifications.TabIndex = 5;
            this.LabelDeskSpecifications.Text = "Desk Specifications";
            // 
            // LabelDepth
            // 
            this.LabelDepth.AutoSize = true;
            this.LabelDepth.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDepth.Location = new System.Drawing.Point(15, 241);
            this.LabelDepth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDepth.Name = "LabelDepth";
            this.LabelDepth.Size = new System.Drawing.Size(114, 29);
            this.LabelDepth.TabIndex = 11;
            this.LabelDepth.Text = "Depth (12-48):";
            // 
            // TextBoxDepth
            // 
            this.TextBoxDepth.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDepth.Location = new System.Drawing.Point(187, 238);
            this.TextBoxDepth.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.TextBoxDepth.Name = "TextBoxDepth";
            this.TextBoxDepth.Size = new System.Drawing.Size(274, 37);
            this.TextBoxDepth.TabIndex = 3;
            this.TextBoxDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDepth_KeyPress);
            this.TextBoxDepth.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxDepth_Validating);
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(15, 64);
            this.LabelDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(45, 29);
            this.LabelDate.TabIndex = 8;
            this.LabelDate.Text = "Date";
            // 
            // LabelMaterial
            // 
            this.LabelMaterial.AutoSize = true;
            this.LabelMaterial.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMaterial.Location = new System.Drawing.Point(15, 366);
            this.LabelMaterial.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelMaterial.Name = "LabelMaterial";
            this.LabelMaterial.Size = new System.Drawing.Size(73, 29);
            this.LabelMaterial.TabIndex = 13;
            this.LabelMaterial.Text = "Material:";
            // 
            // LabelDrawers
            // 
            this.LabelDrawers.AutoSize = true;
            this.LabelDrawers.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDrawers.Location = new System.Drawing.Point(15, 304);
            this.LabelDrawers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDrawers.Name = "LabelDrawers";
            this.LabelDrawers.Size = new System.Drawing.Size(112, 29);
            this.LabelDrawers.TabIndex = 12;
            this.LabelDrawers.Text = "Drawers (0-7):";
            // 
            // ComboBoxMaterial
            // 
            this.ComboBoxMaterial.DataSource = this.deskBindingSource;
            this.ComboBoxMaterial.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMaterial.FormattingEnabled = true;
            this.ComboBoxMaterial.Location = new System.Drawing.Point(187, 363);
            this.ComboBoxMaterial.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.ComboBoxMaterial.Name = "ComboBoxMaterial";
            this.ComboBoxMaterial.Size = new System.Drawing.Size(274, 37);
            this.ComboBoxMaterial.TabIndex = 5;
            this.ComboBoxMaterial.Text = "Choose a Material";
            // 
            // ButtonGetQuote
            // 
            this.ButtonGetQuote.BackColor = System.Drawing.Color.LightSalmon;
            this.ButtonGetQuote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonGetQuote.FlatAppearance.BorderSize = 3;
            this.ButtonGetQuote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonGetQuote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonGetQuote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonGetQuote.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGetQuote.Location = new System.Drawing.Point(581, 477);
            this.ButtonGetQuote.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.ButtonGetQuote.Name = "ButtonGetQuote";
            this.ButtonGetQuote.Padding = new System.Windows.Forms.Padding(10, 14, 10, 14);
            this.ButtonGetQuote.Size = new System.Drawing.Size(220, 63);
            this.ButtonGetQuote.TabIndex = 7;
            this.ButtonGetQuote.Text = "Get Quote";
            this.ButtonGetQuote.UseVisualStyleBackColor = false;
            this.ButtonGetQuote.Click += new System.EventHandler(this.ButtonGetQuote_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            this.errorProvider3.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider3.Icon")));
            // 
            // UpDownDrawers
            // 
            this.UpDownDrawers.Location = new System.Drawing.Point(187, 298);
            this.UpDownDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.UpDownDrawers.Name = "UpDownDrawers";
            this.UpDownDrawers.Size = new System.Drawing.Size(274, 37);
            this.UpDownDrawers.TabIndex = 16;
            // 
            // RushBox
            // 
            this.RushBox.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushBox.FormattingEnabled = true;
            this.RushBox.Items.AddRange(new object[] {
            "None",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.RushBox.Location = new System.Drawing.Point(187, 424);
            this.RushBox.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.RushBox.Name = "RushBox";
            this.RushBox.Size = new System.Drawing.Size(274, 37);
            this.RushBox.TabIndex = 17;
            // 
            // RushLabel
            // 
            this.RushLabel.AutoSize = true;
            this.RushLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushLabel.Location = new System.Drawing.Point(15, 427);
            this.RushLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RushLabel.Name = "RushLabel";
            this.RushLabel.Size = new System.Drawing.Size(103, 29);
            this.RushLabel.TabIndex = 18;
            this.RushLabel.Text = "Rush Option:";
            // 
            // deskBindingSource
            // 
            this.deskBindingSource.DataSource = typeof(MegaDeskAngeles.Desk);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CancelButton = this.ButtonMainMenu;
            this.ClientSize = new System.Drawing.Size(816, 558);
            this.Controls.Add(this.RushBox);
            this.Controls.Add(this.RushLabel);
            this.Controls.Add(this.UpDownDrawers);
            this.Controls.Add(this.ButtonGetQuote);
            this.Controls.Add(this.ComboBoxMaterial);
            this.Controls.Add(this.LabelMaterial);
            this.Controls.Add(this.LabelDrawers);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.TextBoxDepth);
            this.Controls.Add(this.LabelDepth);
            this.Controls.Add(this.LabelDeskSpecifications);
            this.Controls.Add(this.LabelWidth);
            this.Controls.Add(this.TextBoxCustomerName);
            this.Controls.Add(this.LabelCustomerName);
            this.Controls.Add(this.TextBoxWidth);
            this.Controls.Add(this.ButtonMainMenu);
            this.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDrawers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonMainMenu;
        private System.Windows.Forms.TextBox TextBoxWidth;
        private System.Windows.Forms.Label LabelCustomerName;
        private System.Windows.Forms.TextBox TextBoxCustomerName;
        private System.Windows.Forms.Label LabelWidth;
        private System.Windows.Forms.Label LabelDeskSpecifications;
        private System.Windows.Forms.Label LabelDepth;
        private System.Windows.Forms.TextBox TextBoxDepth;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelMaterial;
        private System.Windows.Forms.Label LabelDrawers;
        private System.Windows.Forms.ComboBox ComboBoxMaterial;
        private System.Windows.Forms.Button ButtonGetQuote;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.NumericUpDown UpDownDrawers;
        private System.Windows.Forms.ComboBox RushBox;
        private System.Windows.Forms.Label RushLabel;
        private System.Windows.Forms.BindingSource deskBindingSource;
    }
}