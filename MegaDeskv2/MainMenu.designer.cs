
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
            this.ButtonAddNewQuote.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonAddNewQuote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonAddNewQuote.FlatAppearance.BorderSize = 3;
            this.ButtonAddNewQuote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonAddNewQuote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonAddNewQuote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddNewQuote.Location = new System.Drawing.Point(25, 54);
            this.ButtonAddNewQuote.Name = "ButtonAddNewQuote";
            this.ButtonAddNewQuote.Size = new System.Drawing.Size(122, 30);
            this.ButtonAddNewQuote.TabIndex = 0;
            this.ButtonAddNewQuote.Text = "&Add New Quote";
            this.ButtonAddNewQuote.UseVisualStyleBackColor = false;
            this.ButtonAddNewQuote.Click += new System.EventHandler(this.ButtonAddNewQuote_Click);
            // 
            // ButtonViewQuotes
            // 
            this.ButtonViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonViewQuotes.Location = new System.Drawing.Point(25, 101);
            this.ButtonViewQuotes.Name = "ButtonViewQuotes";
            this.ButtonViewQuotes.Size = new System.Drawing.Size(122, 30);
            this.ButtonViewQuotes.TabIndex = 1;
            this.ButtonViewQuotes.Text = "&View Quotes";
            this.ButtonViewQuotes.UseVisualStyleBackColor = true;
            this.ButtonViewQuotes.Click += new System.EventHandler(this.ButtonViewQuotes_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Location = new System.Drawing.Point(25, 148);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(122, 30);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "&Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(25, 357);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(122, 30);
            this.ButtonExit.TabIndex = 3;
            this.ButtonExit.Text = "E&xit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(475, 425);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonViewQuotes);
            this.Controls.Add(this.ButtonAddNewQuote);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddNewQuote;
        private System.Windows.Forms.Button ButtonViewQuotes;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonExit;
    }
}

