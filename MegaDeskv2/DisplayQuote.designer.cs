
namespace MegaDeskAngeles
{
    partial class DisplayQuote
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
            this.LabelDeskQuote = new System.Windows.Forms.Label();
            this.LabelCustomerName = new System.Windows.Forms.Label();
            this.LabelWidth = new System.Windows.Forms.Label();
            this.LabelDepth = new System.Windows.Forms.Label();
            this.LabelDrawers = new System.Windows.Forms.Label();
            this.LabelMaterial = new System.Windows.Forms.Label();
            this.LabelRushOrder = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.LabelQuotedPrice = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxWidth = new System.Windows.Forms.TextBox();
            this.TextBoxDepth = new System.Windows.Forms.TextBox();
            this.TextBoxDrawers = new System.Windows.Forms.TextBox();
            this.TextBoxMaterial = new System.Windows.Forms.TextBox();
            this.TextBoxRush = new System.Windows.Forms.TextBox();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.TextBoxDate = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelDeskQuote
            // 
            this.LabelDeskQuote.AutoSize = true;
            this.LabelDeskQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeskQuote.Location = new System.Drawing.Point(34, 9);
            this.LabelDeskQuote.Name = "LabelDeskQuote";
            this.LabelDeskQuote.Size = new System.Drawing.Size(127, 26);
            this.LabelDeskQuote.TabIndex = 6;
            this.LabelDeskQuote.Text = "Desk Quote";
            // 
            // LabelCustomerName
            // 
            this.LabelCustomerName.AutoSize = true;
            this.LabelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomerName.Location = new System.Drawing.Point(48, 67);
            this.LabelCustomerName.Name = "LabelCustomerName";
            this.LabelCustomerName.Size = new System.Drawing.Size(113, 17);
            this.LabelCustomerName.TabIndex = 7;
            this.LabelCustomerName.Text = "Customer Name:";
            // 
            // LabelWidth
            // 
            this.LabelWidth.AutoSize = true;
            this.LabelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWidth.Location = new System.Drawing.Point(63, 105);
            this.LabelWidth.Name = "LabelWidth";
            this.LabelWidth.Size = new System.Drawing.Size(99, 17);
            this.LabelWidth.TabIndex = 8;
            this.LabelWidth.Text = "Width (24-96):";
            // 
            // LabelDepth
            // 
            this.LabelDepth.AutoSize = true;
            this.LabelDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDepth.Location = new System.Drawing.Point(62, 144);
            this.LabelDepth.Name = "LabelDepth";
            this.LabelDepth.Size = new System.Drawing.Size(101, 17);
            this.LabelDepth.TabIndex = 9;
            this.LabelDepth.Text = "Depth (12-48):";
            // 
            // LabelDrawers
            // 
            this.LabelDrawers.AutoSize = true;
            this.LabelDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDrawers.Location = new System.Drawing.Point(62, 183);
            this.LabelDrawers.Name = "LabelDrawers";
            this.LabelDrawers.Size = new System.Drawing.Size(99, 17);
            this.LabelDrawers.TabIndex = 11;
            this.LabelDrawers.Text = "Drawers (0-7):";
            // 
            // LabelMaterial
            // 
            this.LabelMaterial.AutoSize = true;
            this.LabelMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMaterial.Location = new System.Drawing.Point(99, 222);
            this.LabelMaterial.Name = "LabelMaterial";
            this.LabelMaterial.Size = new System.Drawing.Size(62, 17);
            this.LabelMaterial.TabIndex = 13;
            this.LabelMaterial.Text = "Material:";
            // 
            // LabelRushOrder
            // 
            this.LabelRushOrder.AutoSize = true;
            this.LabelRushOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRushOrder.Location = new System.Drawing.Point(29, 261);
            this.LabelRushOrder.Name = "LabelRushOrder";
            this.LabelRushOrder.Size = new System.Drawing.Size(132, 17);
            this.LabelRushOrder.TabIndex = 14;
            this.LabelRushOrder.Text = "Rush Order (3,5,7):";
            // 
            // ButtonBack
            // 
            this.ButtonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.Location = new System.Drawing.Point(12, 355);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ButtonBack.Size = new System.Drawing.Size(95, 35);
            this.ButtonBack.TabIndex = 15;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // LabelQuotedPrice
            // 
            this.LabelQuotedPrice.AutoSize = true;
            this.LabelQuotedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuotedPrice.Location = new System.Drawing.Point(66, 302);
            this.LabelQuotedPrice.Name = "LabelQuotedPrice";
            this.LabelQuotedPrice.Size = new System.Drawing.Size(95, 17);
            this.LabelQuotedPrice.TabIndex = 16;
            this.LabelQuotedPrice.Text = "Quoted Price:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(167, 64);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.ReadOnly = true;
            this.TextBoxName.Size = new System.Drawing.Size(141, 23);
            this.TextBoxName.TabIndex = 17;
            // 
            // TextBoxWidth
            // 
            this.TextBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxWidth.Location = new System.Drawing.Point(168, 102);
            this.TextBoxWidth.Name = "TextBoxWidth";
            this.TextBoxWidth.ReadOnly = true;
            this.TextBoxWidth.Size = new System.Drawing.Size(141, 23);
            this.TextBoxWidth.TabIndex = 18;
            // 
            // TextBoxDepth
            // 
            this.TextBoxDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDepth.Location = new System.Drawing.Point(167, 141);
            this.TextBoxDepth.Name = "TextBoxDepth";
            this.TextBoxDepth.ReadOnly = true;
            this.TextBoxDepth.Size = new System.Drawing.Size(141, 23);
            this.TextBoxDepth.TabIndex = 19;
            // 
            // TextBoxDrawers
            // 
            this.TextBoxDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDrawers.Location = new System.Drawing.Point(167, 180);
            this.TextBoxDrawers.Name = "TextBoxDrawers";
            this.TextBoxDrawers.ReadOnly = true;
            this.TextBoxDrawers.Size = new System.Drawing.Size(141, 23);
            this.TextBoxDrawers.TabIndex = 20;
            // 
            // TextBoxMaterial
            // 
            this.TextBoxMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMaterial.Location = new System.Drawing.Point(167, 219);
            this.TextBoxMaterial.Name = "TextBoxMaterial";
            this.TextBoxMaterial.ReadOnly = true;
            this.TextBoxMaterial.Size = new System.Drawing.Size(141, 23);
            this.TextBoxMaterial.TabIndex = 21;
            // 
            // TextBoxRush
            // 
            this.TextBoxRush.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRush.Location = new System.Drawing.Point(167, 258);
            this.TextBoxRush.Name = "TextBoxRush";
            this.TextBoxRush.ReadOnly = true;
            this.TextBoxRush.Size = new System.Drawing.Size(141, 23);
            this.TextBoxRush.TabIndex = 22;
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPrice.Location = new System.Drawing.Point(167, 299);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.ReadOnly = true;
            this.TextBoxPrice.Size = new System.Drawing.Size(141, 23);
            this.TextBoxPrice.TabIndex = 23;
            // 
            // TextBoxDate
            // 
            this.TextBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDate.Location = new System.Drawing.Point(168, 13);
            this.TextBoxDate.Name = "TextBoxDate";
            this.TextBoxDate.ReadOnly = true;
            this.TextBoxDate.Size = new System.Drawing.Size(141, 23);
            this.TextBoxDate.TabIndex = 24;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Location = new System.Drawing.Point(306, 355);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ButtonSave.Size = new System.Drawing.Size(96, 35);
            this.ButtonSave.TabIndex = 25;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 402);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxDate);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.TextBoxRush);
            this.Controls.Add(this.TextBoxMaterial);
            this.Controls.Add(this.TextBoxDrawers);
            this.Controls.Add(this.TextBoxDepth);
            this.Controls.Add(this.TextBoxWidth);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelQuotedPrice);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.LabelRushOrder);
            this.Controls.Add(this.LabelMaterial);
            this.Controls.Add(this.LabelDrawers);
            this.Controls.Add(this.LabelDepth);
            this.Controls.Add(this.LabelWidth);
            this.Controls.Add(this.LabelCustomerName);
            this.Controls.Add(this.LabelDeskQuote);
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayQuote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDeskQuote;
        private System.Windows.Forms.Label LabelCustomerName;
        private System.Windows.Forms.Label LabelWidth;
        private System.Windows.Forms.Label LabelDepth;
        private System.Windows.Forms.Label LabelDrawers;
        private System.Windows.Forms.Label LabelMaterial;
        private System.Windows.Forms.Label LabelRushOrder;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelQuotedPrice;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxWidth;
        private System.Windows.Forms.TextBox TextBoxDepth;
        private System.Windows.Forms.TextBox TextBoxDrawers;
        private System.Windows.Forms.TextBox TextBoxMaterial;
        private System.Windows.Forms.TextBox TextBoxRush;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.TextBox TextBoxDate;
        private System.Windows.Forms.Button ButtonSave;
    }
}