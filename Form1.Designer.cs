
namespace OrdersProgramm
{
    partial class LoginPassword
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPassword));
            this.LoginName = new System.Windows.Forms.Label();
            this.PasswordName = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.logintext = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginName
            // 
            this.LoginName.AutoSize = true;
            this.LoginName.Location = new System.Drawing.Point(19, 25);
            this.LoginName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginName.Name = "LoginName";
            this.LoginName.Size = new System.Drawing.Size(65, 23);
            this.LoginName.TabIndex = 0;
            this.LoginName.Text = "Логин";
            // 
            // PasswordName
            // 
            this.PasswordName.AutoSize = true;
            this.PasswordName.Location = new System.Drawing.Point(19, 108);
            this.PasswordName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordName.Name = "PasswordName";
            this.PasswordName.Size = new System.Drawing.Size(79, 23);
            this.PasswordName.TabIndex = 1;
            this.PasswordName.Text = "Пароль";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(23, 213);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(265, 120);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Вход";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // logintext
            // 
            this.logintext.Location = new System.Drawing.Point(135, 25);
            this.logintext.Margin = new System.Windows.Forms.Padding(4);
            this.logintext.Name = "logintext";
            this.logintext.Size = new System.Drawing.Size(163, 29);
            this.logintext.TabIndex = 3;
            this.logintext.TextChanged += new System.EventHandler(this.logintext_TextChanged);
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(136, 108);
            this.passwordtext.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(163, 29);
            this.passwordtext.TabIndex = 4;
            // 
            // LoginPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(323, 345);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.logintext);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordName);
            this.Controls.Add(this.LoginName);
            this.Font = new System.Drawing.Font("Old English Text MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginPassword";
            this.ShowInTaskbar = false;
            this.Text = "OrdersProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginName;
        private System.Windows.Forms.Label PasswordName;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox logintext;
        private System.Windows.Forms.TextBox passwordtext;
    }
}

