
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
            this.LabelDeskSpecifications = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.ButtonGetQuote = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.RushBox = new System.Windows.Forms.ComboBox();
            this.RushLabel = new System.Windows.Forms.Label();
            this.UpDownDrawers = new System.Windows.Forms.NumericUpDown();
            this.ComboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.LabelMaterial = new System.Windows.Forms.Label();
            this.LabelDrawers = new System.Windows.Forms.Label();
            this.TextBoxDepth = new System.Windows.Forms.TextBox();
            this.LabelDepth = new System.Windows.Forms.Label();
            this.LabelWidth = new System.Windows.Forms.Label();
            this.TextBoxCustomerName = new System.Windows.Forms.TextBox();
            this.LabelCustomerName = new System.Windows.Forms.Label();
            this.TextBoxWidth = new System.Windows.Forms.TextBox();
            this.deskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonMainMenu
            // 
            this.ButtonMainMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonMainMenu.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMainMenu.Location = new System.Drawing.Point(14, 13);
            this.ButtonMainMenu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonMainMenu.Name = "ButtonMainMenu";
            this.ButtonMainMenu.Padding = new System.Windows.Forms.Padding(3);
            this.ButtonMainMenu.Size = new System.Drawing.Size(71, 34);
            this.ButtonMainMenu.TabIndex = 7;
            this.ButtonMainMenu.Text = "&Back";
            this.ButtonMainMenu.UseVisualStyleBackColor = false;
            this.ButtonMainMenu.Click += new System.EventHandler(this.ButtonMainMenu_Click);
            // 
            // LabelDeskSpecifications
            // 
            this.LabelDeskSpecifications.AutoSize = true;
            this.LabelDeskSpecifications.Font = new System.Drawing.Font("Myanmar Text", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeskSpecifications.Location = new System.Drawing.Point(344, 30);
            this.LabelDeskSpecifications.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDeskSpecifications.Name = "LabelDeskSpecifications";
            this.LabelDeskSpecifications.Size = new System.Drawing.Size(490, 89);
            this.LabelDeskSpecifications.TabIndex = 5;
            this.LabelDeskSpecifications.Text = "Desk Specifications";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(498, 97);
            this.LabelDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(56, 36);
            this.LabelDate.TabIndex = 8;
            this.LabelDate.Text = "Date";
            // 
            // ButtonGetQuote
            // 
            this.ButtonGetQuote.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonGetQuote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonGetQuote.FlatAppearance.BorderSize = 3;
            this.ButtonGetQuote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonGetQuote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonGetQuote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonGetQuote.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGetQuote.ForeColor = System.Drawing.Color.White;
            this.ButtonGetQuote.Location = new System.Drawing.Point(910, 627);
            this.ButtonGetQuote.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonGetQuote.Name = "ButtonGetQuote";
            this.ButtonGetQuote.Padding = new System.Windows.Forms.Padding(6);
            this.ButtonGetQuote.Size = new System.Drawing.Size(128, 46);
            this.ButtonGetQuote.TabIndex = 6;
            this.ButtonGetQuote.Text = "&Get Quote";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.RushBox);
            this.panel1.Controls.Add(this.RushLabel);
            this.panel1.Controls.Add(this.UpDownDrawers);
            this.panel1.Controls.Add(this.ComboBoxMaterial);
            this.panel1.Controls.Add(this.LabelMaterial);
            this.panel1.Controls.Add(this.LabelDrawers);
            this.panel1.Controls.Add(this.TextBoxDepth);
            this.panel1.Controls.Add(this.LabelDepth);
            this.panel1.Controls.Add(this.LabelWidth);
            this.panel1.Controls.Add(this.TextBoxCustomerName);
            this.panel1.Controls.Add(this.LabelCustomerName);
            this.panel1.Controls.Add(this.TextBoxWidth);
            this.panel1.Location = new System.Drawing.Point(61, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 464);
            this.panel1.TabIndex = 19;
            // 
            // RushBox
            // 
            this.RushBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RushBox.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushBox.FormattingEnabled = true;
            this.RushBox.Items.AddRange(new object[] {
            "None",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.RushBox.Location = new System.Drawing.Point(417, 366);
            this.RushBox.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.RushBox.Name = "RushBox";
            this.RushBox.Size = new System.Drawing.Size(274, 44);
            this.RushBox.TabIndex = 5;
            // 
            // RushLabel
            // 
            this.RushLabel.AutoSize = true;
            this.RushLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushLabel.Location = new System.Drawing.Point(245, 369);
            this.RushLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RushLabel.Name = "RushLabel";
            this.RushLabel.Size = new System.Drawing.Size(137, 36);
            this.RushLabel.TabIndex = 30;
            this.RushLabel.Text = "Rush Option:";
            // 
            // UpDownDrawers
            // 
            this.UpDownDrawers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UpDownDrawers.Location = new System.Drawing.Point(417, 240);
            this.UpDownDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.UpDownDrawers.Name = "UpDownDrawers";
            this.UpDownDrawers.Size = new System.Drawing.Size(274, 45);
            this.UpDownDrawers.TabIndex = 3;
            this.UpDownDrawers.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxDrawers_Validating);
            // 
            // ComboBoxMaterial
            // 
            this.ComboBoxMaterial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ComboBoxMaterial.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMaterial.FormattingEnabled = true;
            this.ComboBoxMaterial.Location = new System.Drawing.Point(417, 305);
            this.ComboBoxMaterial.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.ComboBoxMaterial.Name = "ComboBoxMaterial";
            this.ComboBoxMaterial.Size = new System.Drawing.Size(274, 44);
            this.ComboBoxMaterial.TabIndex = 4;
            this.ComboBoxMaterial.Click += new System.EventHandler(this.ComboBoxMaterial_Click);
            // 
            // LabelMaterial
            // 
            this.LabelMaterial.AutoSize = true;
            this.LabelMaterial.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMaterial.Location = new System.Drawing.Point(245, 308);
            this.LabelMaterial.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelMaterial.Name = "LabelMaterial";
            this.LabelMaterial.Size = new System.Drawing.Size(100, 36);
            this.LabelMaterial.TabIndex = 27;
            this.LabelMaterial.Text = "Material:";
            // 
            // LabelDrawers
            // 
            this.LabelDrawers.AutoSize = true;
            this.LabelDrawers.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDrawers.Location = new System.Drawing.Point(245, 246);
            this.LabelDrawers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDrawers.Name = "LabelDrawers";
            this.LabelDrawers.Size = new System.Drawing.Size(150, 36);
            this.LabelDrawers.TabIndex = 26;
            this.LabelDrawers.Text = "Drawers (0-7):";
            // 
            // TextBoxDepth
            // 
            this.TextBoxDepth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextBoxDepth.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDepth.Location = new System.Drawing.Point(417, 180);
            this.TextBoxDepth.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.TextBoxDepth.Name = "TextBoxDepth";
            this.TextBoxDepth.Size = new System.Drawing.Size(274, 45);
            this.TextBoxDepth.TabIndex = 2;
            this.TextBoxDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDepth_KeyPress);
            this.TextBoxDepth.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxDepth_Validating);
            // 
            // LabelDepth
            // 
            this.LabelDepth.AutoSize = true;
            this.LabelDepth.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDepth.Location = new System.Drawing.Point(245, 183);
            this.LabelDepth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDepth.Name = "LabelDepth";
            this.LabelDepth.Size = new System.Drawing.Size(154, 36);
            this.LabelDepth.TabIndex = 25;
            this.LabelDepth.Text = "Depth (12-48):";
            // 
            // LabelWidth
            // 
            this.LabelWidth.AutoSize = true;
            this.LabelWidth.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWidth.Location = new System.Drawing.Point(245, 120);
            this.LabelWidth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelWidth.Name = "LabelWidth";
            this.LabelWidth.Size = new System.Drawing.Size(154, 36);
            this.LabelWidth.TabIndex = 24;
            this.LabelWidth.Text = "Width (24-96):";
            // 
            // TextBoxCustomerName
            // 
            this.TextBoxCustomerName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextBoxCustomerName.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCustomerName.Location = new System.Drawing.Point(417, 55);
            this.TextBoxCustomerName.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.TextBoxCustomerName.Name = "TextBoxCustomerName";
            this.TextBoxCustomerName.Size = new System.Drawing.Size(274, 45);
            this.TextBoxCustomerName.TabIndex = 0;
            this.TextBoxCustomerName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxCustomerName_Validating);
            // 
            // LabelCustomerName
            // 
            this.LabelCustomerName.AutoSize = true;
            this.LabelCustomerName.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomerName.Location = new System.Drawing.Point(245, 58);
            this.LabelCustomerName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelCustomerName.Name = "LabelCustomerName";
            this.LabelCustomerName.Size = new System.Drawing.Size(172, 36);
            this.LabelCustomerName.TabIndex = 23;
            this.LabelCustomerName.Text = "Customer Name:";
            // 
            // TextBoxWidth
            // 
            this.TextBoxWidth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextBoxWidth.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxWidth.Location = new System.Drawing.Point(417, 117);
            this.TextBoxWidth.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.TextBoxWidth.Name = "TextBoxWidth";
            this.TextBoxWidth.Size = new System.Drawing.Size(274, 45);
            this.TextBoxWidth.TabIndex = 1;
            this.TextBoxWidth.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxWidth_Validating);
            // 
            // deskBindingSource
            // 
            this.deskBindingSource.DataSource = typeof(MegaDeskAngeles.Desk);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.CancelButton = this.ButtonMainMenu;
            this.ClientSize = new System.Drawing.Size(1052, 686);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonGetQuote);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelDeskSpecifications);
            this.Controls.Add(this.ButtonMainMenu);
            this.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDrawers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonMainMenu;
        private System.Windows.Forms.Label LabelDeskSpecifications;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Button ButtonGetQuote;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.BindingSource deskBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox RushBox;
        private System.Windows.Forms.Label RushLabel;
        private System.Windows.Forms.NumericUpDown UpDownDrawers;
        private System.Windows.Forms.ComboBox ComboBoxMaterial;
        private System.Windows.Forms.Label LabelMaterial;
        private System.Windows.Forms.Label LabelDrawers;
        private System.Windows.Forms.TextBox TextBoxDepth;
        private System.Windows.Forms.Label LabelDepth;
        private System.Windows.Forms.Label LabelWidth;
        private System.Windows.Forms.TextBox TextBoxCustomerName;
        private System.Windows.Forms.Label LabelCustomerName;
        private System.Windows.Forms.TextBox TextBoxWidth;
    }
}