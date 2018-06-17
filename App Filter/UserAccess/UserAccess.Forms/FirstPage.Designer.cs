namespace UserAccess.Forms
{
    partial class FirstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPage));
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxViewUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.discriptionBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new VIBlend.WinForms.Controls.vButton();
            this.cancelBtn = new VIBlend.WinForms.Controls.vButton();
            this.adminModeButton = new VIBlend.WinForms.Controls.vButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            this.label1.Click += new System.EventHandler(this.UserLabel);
            // 
            // TextBoxViewUser
            // 
            this.TextBoxViewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxViewUser.Location = new System.Drawing.Point(119, 96);
            this.TextBoxViewUser.Name = "TextBoxViewUser";
            this.TextBoxViewUser.ReadOnly = true;
            this.TextBoxViewUser.Size = new System.Drawing.Size(260, 22);
            this.TextBoxViewUser.TabIndex = 0;
            this.TextBoxViewUser.TextChanged += new System.EventHandler(this.TextBoxEnterUser);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.DiscriptionLabel);
            // 
            // discriptionBox
            // 
            this.discriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discriptionBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discriptionBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.discriptionBox.Location = new System.Drawing.Point(119, 132);
            this.discriptionBox.Multiline = true;
            this.discriptionBox.Name = "discriptionBox";
            this.discriptionBox.Size = new System.Drawing.Size(636, 353);
            this.discriptionBox.TabIndex = 3;
            this.discriptionBox.Text = "Please, describe the reason for login.";
            this.discriptionBox.TextChanged += new System.EventHandler(this.TextBoxDiscription);
            this.discriptionBox.Enter += new System.EventHandler(this.Description_Enter);
            this.discriptionBox.Leave += new System.EventHandler(this.Description_Leave);
            // 
            // submitBtn
            // 
            this.submitBtn.AllowAnimations = true;
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.BackColor = System.Drawing.Color.Transparent;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitBtn.Location = new System.Drawing.Point(367, 508);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.RoundedCornersMask = ((byte)(15));
            this.submitBtn.Size = new System.Drawing.Size(180, 40);
            this.submitBtn.TabIndex = 9;
            this.submitBtn.Text = "Submit\r\n";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.ULTRABLUE;
            this.submitBtn.Click += new System.EventHandler(this.SubmitButton);
            // 
            // cancelBtn
            // 
            this.cancelBtn.AllowAnimations = true;
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(575, 508);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.RoundedCornersMask = ((byte)(15));
            this.cancelBtn.Size = new System.Drawing.Size(180, 40);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.ULTRABLUE;
            this.cancelBtn.Click += new System.EventHandler(this.Cancel_Button);
            // 
            // adminModeButton
            // 
            this.adminModeButton.AllowAnimations = true;
            this.adminModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminModeButton.BackColor = System.Drawing.Color.Transparent;
            this.adminModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminModeButton.ForeColor = System.Drawing.Color.Black;
            this.adminModeButton.Location = new System.Drawing.Point(624, 38);
            this.adminModeButton.Name = "adminModeButton";
            this.adminModeButton.RoundedCornersMask = ((byte)(15));
            this.adminModeButton.Size = new System.Drawing.Size(131, 24);
            this.adminModeButton.TabIndex = 11;
            this.adminModeButton.Text = "Development Settings";
            this.adminModeButton.UseVisualStyleBackColor = false;
            this.adminModeButton.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.NERO;
            this.adminModeButton.Click += new System.EventHandler(this.AdminModeButton);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminModeButton);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxViewUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.discriptionBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstPage";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Access Microsoft Dynamics AX 2012";
            this.Load += new System.EventHandler(this.FirstPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxViewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox discriptionBox;
        private System.Windows.Forms.Label label2;
        private VIBlend.WinForms.Controls.vButton submitBtn;
        private VIBlend.WinForms.Controls.vButton cancelBtn;
        private VIBlend.WinForms.Controls.vButton adminModeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

