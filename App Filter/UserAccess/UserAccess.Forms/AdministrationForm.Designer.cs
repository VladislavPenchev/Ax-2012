namespace UserAccess.Forms
{
    partial class AdministrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationForm));
            this.vButton1 = new VIBlend.WinForms.Controls.vButton();
            this.vLabel2 = new VIBlend.WinForms.Controls.vLabel();
            this.vButton2 = new VIBlend.WinForms.Controls.vButton();
            this.passwordDiscription = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vButton1
            // 
            this.vButton1.AllowAnimations = true;
            this.vButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vButton1.BackColor = System.Drawing.Color.Transparent;
            this.vButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vButton1.Location = new System.Drawing.Point(391, 170);
            this.vButton1.Name = "vButton1";
            this.vButton1.RoundedCornersMask = ((byte)(15));
            this.vButton1.Size = new System.Drawing.Size(132, 30);
            this.vButton1.TabIndex = 1;
            this.vButton1.Text = "Login";
            this.vButton1.UseVisualStyleBackColor = false;
            this.vButton1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.ULTRABLUE;
            this.vButton1.Click += new System.EventHandler(this.LoginButton);
            // 
            // vLabel2
            // 
            this.vLabel2.BackColor = System.Drawing.Color.Transparent;
            this.vLabel2.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.vLabel2.Ellipsis = false;
            this.vLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vLabel2.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel2.Location = new System.Drawing.Point(36, 119);
            this.vLabel2.Multiline = true;
            this.vLabel2.Name = "vLabel2";
            this.vLabel2.Size = new System.Drawing.Size(150, 25);
            this.vLabel2.TabIndex = 2;
            this.vLabel2.Text = "PASSWORD :";
            this.vLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel2.UseMnemonics = true;
            this.vLabel2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // vButton2
            // 
            this.vButton2.AllowAnimations = true;
            this.vButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vButton2.BackColor = System.Drawing.Color.Transparent;
            this.vButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vButton2.Location = new System.Drawing.Point(554, 170);
            this.vButton2.Name = "vButton2";
            this.vButton2.RoundedCornersMask = ((byte)(15));
            this.vButton2.Size = new System.Drawing.Size(128, 30);
            this.vButton2.TabIndex = 3;
            this.vButton2.Text = "Cancel";
            this.vButton2.UseVisualStyleBackColor = false;
            this.vButton2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.ULTRABLUE;
            this.vButton2.Click += new System.EventHandler(this.Cancel_Button);
            // 
            // passwordDiscription
            // 
            this.passwordDiscription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordDiscription.Location = new System.Drawing.Point(192, 119);
            this.passwordDiscription.Name = "passwordDiscription";
            this.passwordDiscription.PasswordChar = '*';
            this.passwordDiscription.Size = new System.Drawing.Size(501, 20);
            this.passwordDiscription.TabIndex = 6;
            this.passwordDiscription.TextChanged += new System.EventHandler(this.PasswordDiscription);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::UserAccess.Forms.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(36, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordDiscription);
            this.Controls.Add(this.vButton2);
            this.Controls.Add(this.vLabel2);
            this.Controls.Add(this.vButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin Mode";
            this.Load += new System.EventHandler(this.AdministrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VIBlend.WinForms.Controls.vButton vButton1;
        private VIBlend.WinForms.Controls.vLabel vLabel2;
        private VIBlend.WinForms.Controls.vButton vButton2;
        private System.Windows.Forms.TextBox passwordDiscription;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}