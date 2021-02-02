
namespace MegaDeskAngeles
{
    partial class SearchQuotes
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
            this.ButtonMainMenu = new System.Windows.Forms.Button();
            this.LabelSearchByMaterial = new System.Windows.Forms.Label();
            this.ComboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.dataGridQuotes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonMainMenu
            // 
            this.ButtonMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonMainMenu.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMainMenu.Location = new System.Drawing.Point(21, 442);
            this.ButtonMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonMainMenu.Name = "ButtonMainMenu";
            this.ButtonMainMenu.Size = new System.Drawing.Size(221, 63);
            this.ButtonMainMenu.TabIndex = 0;
            this.ButtonMainMenu.Text = "Main Menu";
            this.ButtonMainMenu.UseVisualStyleBackColor = true;
            this.ButtonMainMenu.Click += new System.EventHandler(this.ButtonMainMenu_Click);
            // 
            // LabelSearchByMaterial
            // 
            this.LabelSearchByMaterial.AutoSize = true;
            this.LabelSearchByMaterial.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchByMaterial.Location = new System.Drawing.Point(15, 27);
            this.LabelSearchByMaterial.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelSearchByMaterial.Name = "LabelSearchByMaterial";
            this.LabelSearchByMaterial.Size = new System.Drawing.Size(160, 36);
            this.LabelSearchByMaterial.TabIndex = 11;
            this.LabelSearchByMaterial.Text = "Customer Name:";
            // 
            // ComboBoxMaterial
            // 
            this.ComboBoxMaterial.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMaterial.FormattingEnabled = true;
            this.ComboBoxMaterial.Location = new System.Drawing.Point(187, 19);
            this.ComboBoxMaterial.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.ComboBoxMaterial.Name = "ComboBoxMaterial";
            this.ComboBoxMaterial.Size = new System.Drawing.Size(274, 44);
            this.ComboBoxMaterial.TabIndex = 12;
            this.ComboBoxMaterial.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMaterial_SelectedIndexChanged);
            // 
            // dataGridQuotes
            // 
            this.dataGridQuotes.AllowUserToDeleteRows = false;
            this.dataGridQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuotes.Location = new System.Drawing.Point(21, 101);
            this.dataGridQuotes.Name = "dataGridQuotes";
            this.dataGridQuotes.ReadOnly = true;
            this.dataGridQuotes.RowHeadersWidth = 51;
            this.dataGridQuotes.RowTemplate.Height = 24;
            this.dataGridQuotes.Size = new System.Drawing.Size(1078, 281);
            this.dataGridQuotes.TabIndex = 13;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonMainMenu;
            this.ClientSize = new System.Drawing.Size(1117, 525);
            this.Controls.Add(this.dataGridQuotes);
            this.Controls.Add(this.ComboBoxMaterial);
            this.Controls.Add(this.LabelSearchByMaterial);
            this.Controls.Add(this.ButtonMainMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonMainMenu;
        private System.Windows.Forms.Label LabelSearchByMaterial;
        private System.Windows.Forms.ComboBox ComboBoxMaterial;
        private System.Windows.Forms.DataGridView dataGridQuotes;
    }
}