
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
            this.ShippingBox = new System.Windows.Forms.GroupBox();
            this.NoRush14 = new System.Windows.Forms.RadioButton();
            this.Rush7 = new System.Windows.Forms.RadioButton();
            this.Rush5 = new System.Windows.Forms.RadioButton();
            this.Rush3 = new System.Windows.Forms.RadioButton();
            this.UpDownDrawers = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.ShippingBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDrawers)).BeginInit();
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
            this.TextBoxWidth.Location = new System.Drawing.Point(187, 210);
            this.TextBoxWidth.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.TextBoxWidth.Name = "TextBoxWidth";
            this.TextBoxWidth.Size = new System.Drawing.Size(274, 45);
            this.TextBoxWidth.TabIndex = 2;
            this.TextBoxWidth.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxWidth_Validating);
            // 
            // LabelCustomerName
            // 
            this.LabelCustomerName.AutoSize = true;
            this.LabelCustomerName.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomerName.Location = new System.Drawing.Point(15, 151);
            this.LabelCustomerName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelCustomerName.Name = "LabelCustomerName";
            this.LabelCustomerName.Size = new System.Drawing.Size(160, 36);
            this.LabelCustomerName.TabIndex = 9;
            this.LabelCustomerName.Text = "Customer Name:";
            // 
            // TextBoxCustomerName
            // 
            this.TextBoxCustomerName.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCustomerName.Location = new System.Drawing.Point(187, 148);
            this.TextBoxCustomerName.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.TextBoxCustomerName.Name = "TextBoxCustomerName";
            this.TextBoxCustomerName.Size = new System.Drawing.Size(274, 45);
            this.TextBoxCustomerName.TabIndex = 1;
            this.TextBoxCustomerName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxCustomerName_Validating);
            // 
            // LabelWidth
            // 
            this.LabelWidth.AutoSize = true;
            this.LabelWidth.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWidth.Location = new System.Drawing.Point(15, 213);
            this.LabelWidth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelWidth.Name = "LabelWidth";
            this.LabelWidth.Size = new System.Drawing.Size(142, 36);
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
            this.LabelDeskSpecifications.Size = new System.Drawing.Size(392, 71);
            this.LabelDeskSpecifications.TabIndex = 5;
            this.LabelDeskSpecifications.Text = "Desk Specifications";
            // 
            // LabelDepth
            // 
            this.LabelDepth.AutoSize = true;
            this.LabelDepth.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDepth.Location = new System.Drawing.Point(15, 276);
            this.LabelDepth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDepth.Name = "LabelDepth";
            this.LabelDepth.Size = new System.Drawing.Size(142, 36);
            this.LabelDepth.TabIndex = 11;
            this.LabelDepth.Text = "Depth (12-48):";
            // 
            // TextBoxDepth
            // 
            this.TextBoxDepth.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDepth.Location = new System.Drawing.Point(187, 273);
            this.TextBoxDepth.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.TextBoxDepth.Name = "TextBoxDepth";
            this.TextBoxDepth.Size = new System.Drawing.Size(274, 45);
            this.TextBoxDepth.TabIndex = 3;
            this.TextBoxDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDepth_KeyPress);
            this.TextBoxDepth.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxDepth_Validating);
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(15, 99);
            this.LabelDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(56, 36);
            this.LabelDate.TabIndex = 8;
            this.LabelDate.Text = "Date";
            // 
            // LabelMaterial
            // 
            this.LabelMaterial.AutoSize = true;
            this.LabelMaterial.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMaterial.Location = new System.Drawing.Point(15, 401);
            this.LabelMaterial.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelMaterial.Name = "LabelMaterial";
            this.LabelMaterial.Size = new System.Drawing.Size(91, 36);
            this.LabelMaterial.TabIndex = 13;
            this.LabelMaterial.Text = "Material:";
            // 
            // LabelDrawers
            // 
            this.LabelDrawers.AutoSize = true;
            this.LabelDrawers.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDrawers.Location = new System.Drawing.Point(15, 339);
            this.LabelDrawers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDrawers.Name = "LabelDrawers";
            this.LabelDrawers.Size = new System.Drawing.Size(136, 36);
            this.LabelDrawers.TabIndex = 12;
            this.LabelDrawers.Text = "Drawers (0-7):";
            // 
            // ComboBoxMaterial
            // 
            this.ComboBoxMaterial.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMaterial.FormattingEnabled = true;
            this.ComboBoxMaterial.Location = new System.Drawing.Point(187, 398);
            this.ComboBoxMaterial.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.ComboBoxMaterial.Name = "ComboBoxMaterial";
            this.ComboBoxMaterial.Size = new System.Drawing.Size(274, 44);
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
            // ShippingBox
            // 
            this.ShippingBox.Controls.Add(this.NoRush14);
            this.ShippingBox.Controls.Add(this.Rush7);
            this.ShippingBox.Controls.Add(this.Rush5);
            this.ShippingBox.Controls.Add(this.Rush3);
            this.ShippingBox.Location = new System.Drawing.Point(527, 151);
            this.ShippingBox.Name = "ShippingBox";
            this.ShippingBox.Size = new System.Drawing.Size(263, 246);
            this.ShippingBox.TabIndex = 15;
            this.ShippingBox.TabStop = false;
            this.ShippingBox.Text = "Shipping";
            // 
            // NoRush14
            // 
            this.NoRush14.AutoSize = true;
            this.NoRush14.Location = new System.Drawing.Point(30, 182);
            this.NoRush14.Name = "NoRush14";
            this.NoRush14.Size = new System.Drawing.Size(186, 40);
            this.NoRush14.TabIndex = 3;
            this.NoRush14.TabStop = true;
            this.NoRush14.Text = "No Rush: 14 days";
            this.NoRush14.UseVisualStyleBackColor = true;
            // 
            // Rush7
            // 
            this.Rush7.AutoSize = true;
            this.Rush7.Location = new System.Drawing.Point(30, 136);
            this.Rush7.Name = "Rush7";
            this.Rush7.Size = new System.Drawing.Size(143, 40);
            this.Rush7.TabIndex = 2;
            this.Rush7.TabStop = true;
            this.Rush7.Text = "Rush: 7 days";
            this.Rush7.UseVisualStyleBackColor = true;
            // 
            // Rush5
            // 
            this.Rush5.AutoSize = true;
            this.Rush5.Location = new System.Drawing.Point(30, 90);
            this.Rush5.Name = "Rush5";
            this.Rush5.Size = new System.Drawing.Size(143, 40);
            this.Rush5.TabIndex = 1;
            this.Rush5.TabStop = true;
            this.Rush5.Text = "Rush: 5 days";
            this.Rush5.UseVisualStyleBackColor = true;
            // 
            // Rush3
            // 
            this.Rush3.AutoSize = true;
            this.Rush3.Location = new System.Drawing.Point(30, 44);
            this.Rush3.Name = "Rush3";
            this.Rush3.Size = new System.Drawing.Size(143, 40);
            this.Rush3.TabIndex = 0;
            this.Rush3.TabStop = true;
            this.Rush3.Text = "Rush: 3 days";
            this.Rush3.UseVisualStyleBackColor = true;
            // 
            // UpDownDrawers
            // 
            this.UpDownDrawers.Location = new System.Drawing.Point(187, 333);
            this.UpDownDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.UpDownDrawers.Name = "UpDownDrawers";
            this.UpDownDrawers.Size = new System.Drawing.Size(274, 45);
            this.UpDownDrawers.TabIndex = 16;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CancelButton = this.ButtonMainMenu;
            this.ClientSize = new System.Drawing.Size(816, 558);
            this.Controls.Add(this.UpDownDrawers);
            this.Controls.Add(this.ShippingBox);
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
            this.ShippingBox.ResumeLayout(false);
            this.ShippingBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDrawers)).EndInit();
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
        private System.Windows.Forms.GroupBox ShippingBox;
        private System.Windows.Forms.RadioButton NoRush14;
        private System.Windows.Forms.RadioButton Rush7;
        private System.Windows.Forms.RadioButton Rush5;
        private System.Windows.Forms.RadioButton Rush3;
        private System.Windows.Forms.NumericUpDown UpDownDrawers;
    }
}