
namespace MegaDeskAngeles
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ButtonAddNewQuote = new System.Windows.Forms.Button();
            this.ButtonViewQuotes = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAddNewQuote
            // 
            this.ButtonAddNewQuote.BackColor = System.Drawing.Color.LightSalmon;
            this.ButtonAddNewQuote.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.ButtonAddNewQuote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddNewQuote.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddNewQuote.Location = new System.Drawing.Point(12, 17);
            this.ButtonAddNewQuote.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.ButtonAddNewQuote.Name = "ButtonAddNewQuote";
            this.ButtonAddNewQuote.Size = new System.Drawing.Size(153, 60);
            this.ButtonAddNewQuote.TabIndex = 0;
            this.ButtonAddNewQuote.Text = "&Add New Quote";
            this.ButtonAddNewQuote.UseVisualStyleBackColor = false;
            this.ButtonAddNewQuote.Click += new System.EventHandler(this.ButtonAddNewQuote_Click);
            // 
            // ButtonViewQuotes
            // 
            this.ButtonViewQuotes.BackColor = System.Drawing.Color.LightSalmon;
            this.ButtonViewQuotes.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.ButtonViewQuotes.FlatAppearance.BorderSize = 3;
            this.ButtonViewQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonViewQuotes.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonViewQuotes.Location = new System.Drawing.Point(12, 93);
            this.ButtonViewQuotes.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.ButtonViewQuotes.Name = "ButtonViewQuotes";
            this.ButtonViewQuotes.Size = new System.Drawing.Size(153, 60);
            this.ButtonViewQuotes.TabIndex = 1;
            this.ButtonViewQuotes.Text = "&View Quotes";
            this.ButtonViewQuotes.UseVisualStyleBackColor = false;
            this.ButtonViewQuotes.Click += new System.EventHandler(this.ButtonViewQuotes_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.LightSalmon;
            this.ButtonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSearch.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Location = new System.Drawing.Point(12, 169);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(153, 62);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "&Search";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.LightSalmon;
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonExit.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonExit.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(12, 350);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(153, 60);
            this.ButtonExit.TabIndex = 3;
            this.ButtonExit.Text = "E&xit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.ButtonExit;
            this.ClientSize = new System.Drawing.Size(471, 427);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonViewQuotes);
            this.Controls.Add(this.ButtonAddNewQuote);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddNewQuote;
        private System.Windows.Forms.Button ButtonViewQuotes;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonExit;
    }
}

