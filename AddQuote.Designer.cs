namespace MegaDesk_BekahHowe
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
            this.mainmenuBtn = new System.Windows.Forms.Button();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.rushLabel = new System.Windows.Forms.Label();
            this.RushOrder = new System.Windows.Forms.TextBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.materialInput = new System.Windows.Forms.TextBox();
            this.drawersLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.depthLabel = new System.Windows.Forms.Label();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.getQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainmenuBtn
            // 
            this.mainmenuBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mainmenuBtn.Location = new System.Drawing.Point(12, 12);
            this.mainmenuBtn.Name = "mainmenuBtn";
            this.mainmenuBtn.Size = new System.Drawing.Size(75, 23);
            this.mainmenuBtn.TabIndex = 1;
            this.mainmenuBtn.Text = "Main Menu";
            this.mainmenuBtn.UseVisualStyleBackColor = true;
            this.mainmenuBtn.Click += new System.EventHandler(this.MainmenuBtn_Click);
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(148, 157);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(130, 20);
            this.widthInput.TabIndex = 2;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.validInt);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "NEW QUOTE";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(56, 161);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(86, 13);
            this.widthLabel.TabIndex = 4;
            this.widthLabel.Text = "Desk Width (in.):";
            // 
            // rushLabel
            // 
            this.rushLabel.AutoSize = true;
            this.rushLabel.Location = new System.Drawing.Point(372, 221);
            this.rushLabel.Name = "rushLabel";
            this.rushLabel.Size = new System.Drawing.Size(64, 13);
            this.rushLabel.TabIndex = 6;
            this.rushLabel.Text = "Rush Order:";
            // 
            // RushOrder
            // 
            this.RushOrder.Location = new System.Drawing.Point(476, 217);
            this.RushOrder.Name = "RushOrder";
            this.RushOrder.Size = new System.Drawing.Size(130, 20);
            this.RushOrder.TabIndex = 5;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(372, 161);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(97, 13);
            this.materialLabel.TabIndex = 8;
            this.materialLabel.Text = "Desk Top Material:";
            // 
            // materialInput
            // 
            this.materialInput.Location = new System.Drawing.Point(476, 157);
            this.materialInput.Name = "materialInput";
            this.materialInput.Size = new System.Drawing.Size(130, 20);
            this.materialInput.TabIndex = 7;
            // 
            // drawersLabel
            // 
            this.drawersLabel.AutoSize = true;
            this.drawersLabel.Location = new System.Drawing.Point(372, 102);
            this.drawersLabel.Name = "drawersLabel";
            this.drawersLabel.Size = new System.Drawing.Size(71, 13);
            this.drawersLabel.TabIndex = 10;
            this.drawersLabel.Text = "# of Drawers:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(476, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(56, 102);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 13);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Full Name:";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(148, 98);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(130, 20);
            this.UserName.TabIndex = 11;
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(56, 221);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(87, 13);
            this.depthLabel.TabIndex = 14;
            this.depthLabel.Text = "Desk Depth (in.):";
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(148, 217);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(130, 20);
            this.depthInput.TabIndex = 13;
            // 
            // getQuote
            // 
            this.getQuote.AutoSize = true;
            this.getQuote.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getQuote.Location = new System.Drawing.Point(229, 303);
            this.getQuote.Name = "getQuote";
            this.getQuote.Size = new System.Drawing.Size(207, 37);
            this.getQuote.TabIndex = 15;
            this.getQuote.Text = "Calculate Quote";
            this.getQuote.UseVisualStyleBackColor = true;
            this.getQuote.Click += new System.EventHandler(this.GetQuote_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mainmenuBtn;
            this.ClientSize = new System.Drawing.Size(679, 370);
            this.Controls.Add(this.getQuote);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.drawersLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.materialInput);
            this.Controls.Add(this.rushLabel);
            this.Controls.Add(this.RushOrder);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.mainmenuBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainmenuBtn;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label rushLabel;
        private System.Windows.Forms.TextBox RushOrder;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.TextBox materialInput;
        private System.Windows.Forms.Label drawersLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.Button getQuote;
    }
}