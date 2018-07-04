namespace UserAccess.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.vLabel1 = new VIBlend.WinForms.Controls.vLabel();
            this.AxDbDiscription = new VIBlend.WinForms.Controls.vTextBox();
            this.passwordLabel = new VIBlend.WinForms.Controls.vLabel();
            this.confirmPassword = new VIBlend.WinForms.Controls.vLabel();
            this.passwordDescription = new System.Windows.Forms.TextBox();
            this.confirmPasswordDescription = new System.Windows.Forms.TextBox();
            this.editDatabaseName = new VIBlend.WinForms.Controls.vButton();
            this.changePassword = new VIBlend.WinForms.Controls.vButton();
            this.vLabel2 = new VIBlend.WinForms.Controls.vLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.appConfigDescription = new System.Windows.Forms.TextBox();
            this.appConfigLabel = new VIBlend.WinForms.Controls.vLabel();
            this.cancelButton = new VIBlend.WinForms.Controls.vButton();
            this.databaseNameLabel = new VIBlend.WinForms.Controls.vLabel();
            this.submitButton = new VIBlend.WinForms.Controls.vButton();
            this.vLabel3 = new VIBlend.WinForms.Controls.vLabel();
            this.Save = new VIBlend.WinForms.Controls.vButton();
            this.vButton1 = new VIBlend.WinForms.Controls.vButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vLabel1
            // 
            this.vLabel1.BackColor = System.Drawing.Color.Transparent;
            this.vLabel1.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.vLabel1.Ellipsis = false;
            this.vLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vLabel1.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel1.Location = new System.Drawing.Point(120, 33);
            this.vLabel1.Multiline = true;
            this.vLabel1.Name = "vLabel1";
            this.vLabel1.Size = new System.Drawing.Size(149, 46);
            this.vLabel1.TabIndex = 0;
            this.vLabel1.Text = "Name Microsoft Dynamics AX 2012 Database";
            this.vLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel1.UseMnemonics = true;
            this.vLabel1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.ULTRABLUE;
            this.vLabel1.Click += new System.EventHandler(this.nameOfDataBase);
            // 
            // AxDbDiscription
            // 
            this.AxDbDiscription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AxDbDiscription.BackColor = System.Drawing.Color.White;
            this.AxDbDiscription.BoundsOffset = new System.Drawing.Size(1, 1);
            this.AxDbDiscription.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.AxDbDiscription.DefaultText = "Empty...";
            this.AxDbDiscription.Location = new System.Drawing.Point(230, 30);
            this.AxDbDiscription.MaxLength = 32767;
            this.AxDbDiscription.Name = "AxDbDiscription";
            this.AxDbDiscription.PasswordChar = '\0';
            this.AxDbDiscription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AxDbDiscription.SelectionLength = 0;
            this.AxDbDiscription.SelectionStart = 0;
            this.AxDbDiscription.ShowDefaultText = false;
            this.AxDbDiscription.Size = new System.Drawing.Size(329, 25);
            this.AxDbDiscription.TabIndex = 1;
            this.AxDbDiscription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AxDbDiscription.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.ULTRABLUE;
            this.AxDbDiscription.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.passwordLabel.Ellipsis = false;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.passwordLabel.Location = new System.Drawing.Point(31, 30);
            this.passwordLabel.Multiline = true;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(80, 25);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password :";
            this.passwordLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.passwordLabel.UseMnemonics = true;
            this.passwordLabel.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.passwordLabel.Visible = false;
            // 
            // confirmPassword
            // 
            this.confirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.confirmPassword.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.confirmPassword.Ellipsis = false;
            this.confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPassword.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.confirmPassword.Location = new System.Drawing.Point(31, 83);
            this.confirmPassword.Multiline = true;
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(132, 25);
            this.confirmPassword.TabIndex = 5;
            this.confirmPassword.Text = "Confirm Password :";
            this.confirmPassword.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.confirmPassword.UseMnemonics = true;
            this.confirmPassword.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.confirmPassword.Visible = false;
            // 
            // passwordDescription
            // 
            this.passwordDescription.Location = new System.Drawing.Point(175, 30);
            this.passwordDescription.Name = "passwordDescription";
            this.passwordDescription.PasswordChar = '*';
            this.passwordDescription.Size = new System.Drawing.Size(264, 20);
            this.passwordDescription.TabIndex = 6;
            this.passwordDescription.Visible = false;
            // 
            // confirmPasswordDescription
            // 
            this.confirmPasswordDescription.Location = new System.Drawing.Point(175, 88);
            this.confirmPasswordDescription.Name = "confirmPasswordDescription";
            this.confirmPasswordDescription.PasswordChar = '*';
            this.confirmPasswordDescription.Size = new System.Drawing.Size(264, 20);
            this.confirmPasswordDescription.TabIndex = 7;
            this.confirmPasswordDescription.Visible = false;
            this.confirmPasswordDescription.TextChanged += new System.EventHandler(this.confirmPasswordDescription_TextChanged);
            // 
            // editDatabaseName
            // 
            this.editDatabaseName.AllowAnimations = true;
            this.editDatabaseName.BackColor = System.Drawing.Color.Transparent;
            this.editDatabaseName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editDatabaseName.Location = new System.Drawing.Point(27, 33);
            this.editDatabaseName.Name = "editDatabaseName";
            this.editDatabaseName.RoundedCornersMask = ((byte)(15));
            this.editDatabaseName.Size = new System.Drawing.Size(60, 30);
            this.editDatabaseName.TabIndex = 9;
            this.editDatabaseName.Text = "Edit";
            this.editDatabaseName.UseVisualStyleBackColor = false;
            this.editDatabaseName.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2003OLIVE;
            this.editDatabaseName.Click += new System.EventHandler(this.EditDatabaseName_Click);
            // 
            // changePassword
            // 
            this.changePassword.AllowAnimations = true;
            this.changePassword.BackColor = System.Drawing.Color.Transparent;
            this.changePassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassword.Location = new System.Drawing.Point(27, 95);
            this.changePassword.Name = "changePassword";
            this.changePassword.RoundedCornersMask = ((byte)(15));
            this.changePassword.Size = new System.Drawing.Size(60, 30);
            this.changePassword.TabIndex = 10;
            this.changePassword.Text = "Edit";
            this.changePassword.UseVisualStyleBackColor = false;
            this.changePassword.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2003OLIVE;
            this.changePassword.Click += new System.EventHandler(this.EditChangePasswordButton);
            // 
            // vLabel2
            // 
            this.vLabel2.BackColor = System.Drawing.Color.Transparent;
            this.vLabel2.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.vLabel2.Ellipsis = false;
            this.vLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vLabel2.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel2.Location = new System.Drawing.Point(120, 95);
            this.vLabel2.Multiline = true;
            this.vLabel2.Name = "vLabel2";
            this.vLabel2.Size = new System.Drawing.Size(123, 25);
            this.vLabel2.TabIndex = 11;
            this.vLabel2.Text = "Change Password";
            this.vLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel2.UseMnemonics = true;
            this.vLabel2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.vLabel2.Click += new System.EventHandler(this.vLabel2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.appConfigDescription);
            this.panel1.Controls.Add(this.appConfigLabel);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.databaseNameLabel);
            this.panel1.Controls.Add(this.AxDbDiscription);
            this.panel1.Controls.Add(this.submitButton);
            this.panel1.Controls.Add(this.confirmPassword);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.confirmPasswordDescription);
            this.panel1.Controls.Add(this.passwordDescription);
            this.panel1.Location = new System.Drawing.Point(68, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 177);
            this.panel1.TabIndex = 12;
            // 
            // appConfigDescription
            // 
            this.appConfigDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appConfigDescription.Location = new System.Drawing.Point(31, 75);
            this.appConfigDescription.Multiline = true;
            this.appConfigDescription.Name = "appConfigDescription";
            this.appConfigDescription.ReadOnly = true;
            this.appConfigDescription.Size = new System.Drawing.Size(567, 39);
            this.appConfigDescription.TabIndex = 17;
            this.appConfigDescription.Visible = false;
            this.appConfigDescription.TextChanged += new System.EventHandler(this.appConfigDescription_TextChanged);
            // 
            // appConfigLabel
            // 
            this.appConfigLabel.BackColor = System.Drawing.Color.Transparent;
            this.appConfigLabel.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.appConfigLabel.Ellipsis = false;
            this.appConfigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appConfigLabel.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.appConfigLabel.Location = new System.Drawing.Point(31, 30);
            this.appConfigLabel.Multiline = true;
            this.appConfigLabel.Name = "appConfigLabel";
            this.appConfigLabel.Size = new System.Drawing.Size(291, 39);
            this.appConfigLabel.TabIndex = 15;
            this.appConfigLabel.Text = "Do you want to save new App.Config ?";
            this.appConfigLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.appConfigLabel.UseMnemonics = true;
            this.appConfigLabel.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.appConfigLabel.Visible = false;
            this.appConfigLabel.Click += new System.EventHandler(this.appConfigLabel_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AllowAnimations = true;
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(531, 130);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.RoundedCornersMask = ((byte)(15));
            this.cancelButton.Size = new System.Drawing.Size(119, 29);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.ULTRABLUE;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.Cancel_Button);
            // 
            // databaseNameLabel
            // 
            this.databaseNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.databaseNameLabel.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.databaseNameLabel.Ellipsis = false;
            this.databaseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.databaseNameLabel.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.databaseNameLabel.Location = new System.Drawing.Point(31, 33);
            this.databaseNameLabel.Multiline = true;
            this.databaseNameLabel.Name = "databaseNameLabel";
            this.databaseNameLabel.Size = new System.Drawing.Size(177, 25);
            this.databaseNameLabel.TabIndex = 13;
            this.databaseNameLabel.Text = "AX 2012 database name :";
            this.databaseNameLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.databaseNameLabel.UseMnemonics = true;
            this.databaseNameLabel.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.databaseNameLabel.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.AllowAnimations = true;
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.BackColor = System.Drawing.Color.Transparent;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.Location = new System.Drawing.Point(384, 130);
            this.submitButton.Name = "submitButton";
            this.submitButton.RoundedCornersMask = ((byte)(15));
            this.submitButton.Size = new System.Drawing.Size(119, 30);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.ULTRABLUE;
            this.submitButton.Visible = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton);
            // 
            // vLabel3
            // 
            this.vLabel3.BackColor = System.Drawing.Color.Transparent;
            this.vLabel3.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.vLabel3.Ellipsis = false;
            this.vLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vLabel3.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel3.Location = new System.Drawing.Point(120, 155);
            this.vLabel3.Multiline = true;
            this.vLabel3.Name = "vLabel3";
            this.vLabel3.Size = new System.Drawing.Size(131, 25);
            this.vLabel3.TabIndex = 13;
            this.vLabel3.Text = "Save App.Config";
            this.vLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel3.UseMnemonics = true;
            this.vLabel3.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // Save
            // 
            this.Save.AllowAnimations = true;
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(27, 155);
            this.Save.Name = "Save";
            this.Save.RoundedCornersMask = ((byte)(15));
            this.Save.Size = new System.Drawing.Size(60, 30);
            this.Save.TabIndex = 14;
            this.Save.Text = "Edit";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2003OLIVE;
            this.Save.Click += new System.EventHandler(this.EditAppConfig);
            // 
            // vButton1
            // 
            this.vButton1.AllowAnimations = true;
            this.vButton1.BackColor = System.Drawing.Color.Transparent;
            this.vButton1.Location = new System.Drawing.Point(599, 33);
            this.vButton1.Name = "vButton1";
            this.vButton1.RoundedCornersMask = ((byte)(15));
            this.vButton1.Size = new System.Drawing.Size(100, 30);
            this.vButton1.TabIndex = 15;
            this.vButton1.Text = "View Userinfo";
            this.vButton1.UseVisualStyleBackColor = false;
            this.vButton1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.ORANGEFRESH;
            this.vButton1.Click += new System.EventHandler(this.vButton1_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UserAccess.Forms.Properties.Resources.DynamicsAxWallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.vButton1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.vLabel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vLabel2);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.editDatabaseName);
            this.Controls.Add(this.vLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VIBlend.WinForms.Controls.vLabel vLabel1;
        private VIBlend.WinForms.Controls.vTextBox AxDbDiscription;
        private VIBlend.WinForms.Controls.vLabel passwordLabel;
        private VIBlend.WinForms.Controls.vLabel confirmPassword;
        private System.Windows.Forms.TextBox passwordDescription;
        private System.Windows.Forms.TextBox confirmPasswordDescription;
        private VIBlend.WinForms.Controls.vButton editDatabaseName;
        private VIBlend.WinForms.Controls.vButton changePassword;
        private VIBlend.WinForms.Controls.vLabel vLabel2;
        private System.Windows.Forms.Panel panel1;
        private VIBlend.WinForms.Controls.vButton cancelButton;
        private VIBlend.WinForms.Controls.vButton submitButton;
        private VIBlend.WinForms.Controls.vLabel databaseNameLabel;
        private VIBlend.WinForms.Controls.vLabel vLabel3;
        private VIBlend.WinForms.Controls.vButton Save;
        private VIBlend.WinForms.Controls.vLabel appConfigLabel;
        private System.Windows.Forms.TextBox appConfigDescription;
        private VIBlend.WinForms.Controls.vButton vButton1;
    }
}