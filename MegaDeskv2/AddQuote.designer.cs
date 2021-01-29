
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
            this.LabelRushOrder = new System.Windows.Forms.Label();
            this.LabelMaterial = new System.Windows.Forms.Label();
            this.LabelDrawers = new System.Windows.Forms.Label();
            this.ComboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.ButtonGetQuote = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ComboBoxDrawers = new System.Windows.Forms.ComboBox();
            this.ComboBoxRush = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonMainMenu
            // 
            this.ButtonMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMainMenu.Location = new System.Drawing.Point(23, 329);
            this.ButtonMainMenu.Name = "ButtonMainMenu";
            this.ButtonMainMenu.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ButtonMainMenu.Size = new System.Drawing.Size(95, 35);
            this.ButtonMainMenu.TabIndex = 8;
            this.ButtonMainMenu.Text = "Main Menu";
            this.ButtonMainMenu.UseVisualStyleBackColor = true;
            this.ButtonMainMenu.Click += new System.EventHandler(this.ButtonMainMenu_Click);
            // 
            // TextBoxWidth
            // 
            this.TextBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxWidth.Location = new System.Drawing.Point(170, 102);
            this.TextBoxWidth.Name = "TextBoxWidth";
            this.TextBoxWidth.Size = new System.Drawing.Size(121, 23);
            this.TextBoxWidth.TabIndex = 2;
            this.TextBoxWidth.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxWidth_Validating);
            // 
            // LabelCustomerName
            // 
            this.LabelCustomerName.AutoSize = true;
            this.LabelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomerName.Location = new System.Drawing.Point(48, 67);
            this.LabelCustomerName.Name = "LabelCustomerName";
            this.LabelCustomerName.Size = new System.Drawing.Size(113, 17);
            this.LabelCustomerName.TabIndex = 9;
            this.LabelCustomerName.Text = "Customer Name:";
            // 
            // TextBoxCustomerName
            // 
            this.TextBoxCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCustomerName.Location = new System.Drawing.Point(170, 64);
            this.TextBoxCustomerName.Name = "TextBoxCustomerName";
            this.TextBoxCustomerName.Size = new System.Drawing.Size(120, 23);
            this.TextBoxCustomerName.TabIndex = 1;
            this.TextBoxCustomerName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxCustomerName_Validating);
            // 
            // LabelWidth
            // 
            this.LabelWidth.AutoSize = true;
            this.LabelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWidth.Location = new System.Drawing.Point(48, 105);
            this.LabelWidth.Name = "LabelWidth";
            this.LabelWidth.Size = new System.Drawing.Size(99, 17);
            this.LabelWidth.TabIndex = 10;
            this.LabelWidth.Text = "Width (24-96):";
            // 
            // LabelDeskSpecifications
            // 
            this.LabelDeskSpecifications.AutoSize = true;
            this.LabelDeskSpecifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeskSpecifications.Location = new System.Drawing.Point(19, 18);
            this.LabelDeskSpecifications.Name = "LabelDeskSpecifications";
            this.LabelDeskSpecifications.Size = new System.Drawing.Size(203, 26);
            this.LabelDeskSpecifications.TabIndex = 5;
            this.LabelDeskSpecifications.Text = "Desk Specifications";
            // 
            // LabelDepth
            // 
            this.LabelDepth.AutoSize = true;
            this.LabelDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDepth.Location = new System.Drawing.Point(48, 144);
            this.LabelDepth.Name = "LabelDepth";
            this.LabelDepth.Size = new System.Drawing.Size(101, 17);
            this.LabelDepth.TabIndex = 11;
            this.LabelDepth.Text = "Depth (12-48):";
            // 
            // TextBoxDepth
            // 
            this.TextBoxDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDepth.Location = new System.Drawing.Point(170, 141);
            this.TextBoxDepth.Name = "TextBoxDepth";
            this.TextBoxDepth.Size = new System.Drawing.Size(120, 23);
            this.TextBoxDepth.TabIndex = 3;
            this.TextBoxDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDepth_KeyPress);
            this.TextBoxDepth.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxDepth_Validating);
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(266, 18);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(58, 26);
            this.LabelDate.TabIndex = 8;
            this.LabelDate.Text = "Date";
            // 
            // LabelRushOrder
            // 
            this.LabelRushOrder.AutoSize = true;
            this.LabelRushOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRushOrder.Location = new System.Drawing.Point(48, 267);
            this.LabelRushOrder.Name = "LabelRushOrder";
            this.LabelRushOrder.Size = new System.Drawing.Size(132, 17);
            this.LabelRushOrder.TabIndex = 14;
            this.LabelRushOrder.Text = "Rush Order (3,5,7):";
            // 
            // LabelMaterial
            // 
            this.LabelMaterial.AutoSize = true;
            this.LabelMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMaterial.Location = new System.Drawing.Point(48, 225);
            this.LabelMaterial.Name = "LabelMaterial";
            this.LabelMaterial.Size = new System.Drawing.Size(62, 17);
            this.LabelMaterial.TabIndex = 13;
            this.LabelMaterial.Text = "Material:";
            // 
            // LabelDrawers
            // 
            this.LabelDrawers.AutoSize = true;
            this.LabelDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDrawers.Location = new System.Drawing.Point(48, 185);
            this.LabelDrawers.Name = "LabelDrawers";
            this.LabelDrawers.Size = new System.Drawing.Size(99, 17);
            this.LabelDrawers.TabIndex = 12;
            this.LabelDrawers.Text = "Drawers (0-7):";
            // 
            // ComboBoxMaterial
            // 
            this.ComboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMaterial.FormattingEnabled = true;
            this.ComboBoxMaterial.Location = new System.Drawing.Point(170, 223);
            this.ComboBoxMaterial.Name = "ComboBoxMaterial";
            this.ComboBoxMaterial.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxMaterial.TabIndex = 5;
            this.ComboBoxMaterial.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxMaterial_Validating);
            // 
            // ButtonGetQuote
            // 
            this.ButtonGetQuote.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonGetQuote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonGetQuote.FlatAppearance.BorderSize = 3;
            this.ButtonGetQuote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonGetQuote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonGetQuote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonGetQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGetQuote.Location = new System.Drawing.Point(271, 329);
            this.ButtonGetQuote.Name = "ButtonGetQuote";
            this.ButtonGetQuote.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ButtonGetQuote.Size = new System.Drawing.Size(110, 35);
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
            // ComboBoxDrawers
            // 
            this.ComboBoxDrawers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDrawers.FormattingEnabled = true;
            this.ComboBoxDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.ComboBoxDrawers.Location = new System.Drawing.Point(170, 183);
            this.ComboBoxDrawers.Name = "ComboBoxDrawers";
            this.ComboBoxDrawers.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxDrawers.TabIndex = 4;
            this.ComboBoxDrawers.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxDrawers_Validating);
            // 
            // ComboBoxRush
            // 
            this.ComboBoxRush.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRush.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRush.FormattingEnabled = true;
            this.ComboBoxRush.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.ComboBoxRush.Location = new System.Drawing.Point(170, 265);
            this.ComboBoxRush.Name = "ComboBoxRush";
            this.ComboBoxRush.Size = new System.Drawing.Size(120, 24);
            this.ComboBoxRush.TabIndex = 6;
            this.ComboBoxRush.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxRush_Validating);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CancelButton = this.ButtonMainMenu;
            this.ClientSize = new System.Drawing.Size(414, 381);
            this.Controls.Add(this.ComboBoxRush);
            this.Controls.Add(this.ComboBoxDrawers);
            this.Controls.Add(this.ButtonGetQuote);
            this.Controls.Add(this.ComboBoxMaterial);
            this.Controls.Add(this.LabelRushOrder);
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
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
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
        private System.Windows.Forms.Label LabelRushOrder;
        private System.Windows.Forms.Label LabelMaterial;
        private System.Windows.Forms.Label LabelDrawers;
        private System.Windows.Forms.ComboBox ComboBoxMaterial;
        private System.Windows.Forms.Button ButtonGetQuote;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ComboBox ComboBoxDrawers;
        private System.Windows.Forms.ComboBox ComboBoxRush;
    }
}