
namespace OrdersProgramm
{
    partial class KapchaWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KapchaWindow));
            this.Vhod = new System.Windows.Forms.Button();
            this.Kapcha = new System.Windows.Forms.TextBox();
            this.KapchaText = new System.Windows.Forms.Label();
            this.kapchatekst = new System.Windows.Forms.Label();
            this.Reload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vhod
            // 
            this.Vhod.Location = new System.Drawing.Point(70, 178);
            this.Vhod.Name = "Vhod";
            this.Vhod.Size = new System.Drawing.Size(157, 81);
            this.Vhod.TabIndex = 2;
            this.Vhod.Text = "Подтвердить";
            this.Vhod.UseVisualStyleBackColor = true;
            this.Vhod.Click += new System.EventHandler(this.Vhod_Click);
            // 
            // Kapcha
            // 
            this.Kapcha.Location = new System.Drawing.Point(64, 137);
            this.Kapcha.Name = "Kapcha";
            this.Kapcha.Size = new System.Drawing.Size(163, 22);
            this.Kapcha.TabIndex = 3;
            // 
            // KapchaText
            // 
            this.KapchaText.AutoSize = true;
            this.KapchaText.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KapchaText.Location = new System.Drawing.Point(67, 9);
            this.KapchaText.Name = "KapchaText";
            this.KapchaText.Size = new System.Drawing.Size(160, 26);
            this.KapchaText.TabIndex = 4;
            this.KapchaText.Text = "Введите капчу";
            // 
            // kapchatekst
            // 
            this.kapchatekst.AutoSize = true;
            this.kapchatekst.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kapchatekst.Location = new System.Drawing.Point(18, 62);
            this.kapchatekst.Name = "kapchatekst";
            this.kapchatekst.Size = new System.Drawing.Size(0, 35);
            this.kapchatekst.TabIndex = 5;
            // 
            // Reload
            // 
            this.Reload.Location = new System.Drawing.Point(195, 74);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(94, 23);
            this.Reload.TabIndex = 6;
            this.Reload.Text = "Обновить";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click_1);
            // 
            // KapchaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(301, 271);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.kapchatekst);
            this.Controls.Add(this.KapchaText);
            this.Controls.Add(this.Kapcha);
            this.Controls.Add(this.Vhod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KapchaWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Капча";
            this.Load += new System.EventHandler(this.KapchaWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Vhod;
        private System.Windows.Forms.TextBox Kapcha;
        private System.Windows.Forms.Label KapchaText;
        private System.Windows.Forms.Label kapchatekst;
        private System.Windows.Forms.Button Reload;
    }
}