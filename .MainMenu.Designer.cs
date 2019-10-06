namespace MegaDesk_BekahHowe
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
            this.viewquoteBtn = new System.Windows.Forms.Button();
            this.newQuoteBtn = new System.Windows.Forms.Button();
            this.searchQuotesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewquoteBtn
            // 
            this.viewquoteBtn.Location = new System.Drawing.Point(89, 84);
            this.viewquoteBtn.Name = "viewquoteBtn";
            this.viewquoteBtn.Size = new System.Drawing.Size(100, 60);
            this.viewquoteBtn.TabIndex = 0;
            this.viewquoteBtn.Text = "View Quotes";
            this.viewquoteBtn.UseVisualStyleBackColor = true;
            this.viewquoteBtn.Click += new System.EventHandler(this.ViewquoteBtn_Click);
            // 
            // newQuoteBtn
            // 
            this.newQuoteBtn.Location = new System.Drawing.Point(89, 18);
            this.newQuoteBtn.Name = "newQuoteBtn";
            this.newQuoteBtn.Size = new System.Drawing.Size(100, 60);
            this.newQuoteBtn.TabIndex = 1;
            this.newQuoteBtn.Text = "New Quote";
            this.newQuoteBtn.UseVisualStyleBackColor = true;
            this.newQuoteBtn.Click += new System.EventHandler(this.NewQuoteBtn_Click);
            // 
            // searchQuotesBtn
            // 
            this.searchQuotesBtn.Location = new System.Drawing.Point(89, 150);
            this.searchQuotesBtn.Name = "searchQuotesBtn";
            this.searchQuotesBtn.Size = new System.Drawing.Size(100, 60);
            this.searchQuotesBtn.TabIndex = 2;
            this.searchQuotesBtn.Text = "Search Quotes";
            this.searchQuotesBtn.UseVisualStyleBackColor = true;
            this.searchQuotesBtn.Click += new System.EventHandler(this.SearchQuotesBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(89, 216);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 60);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 294);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.searchQuotesBtn);
            this.Controls.Add(this.newQuoteBtn);
            this.Controls.Add(this.viewquoteBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewquoteBtn;
        private System.Windows.Forms.Button newQuoteBtn;
        private System.Windows.Forms.Button searchQuotesBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

