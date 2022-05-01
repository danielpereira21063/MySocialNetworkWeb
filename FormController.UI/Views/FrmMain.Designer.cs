namespace FormController.UI.Views
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCloseProgram = new System.Windows.Forms.Button();
            this.BtnGenerateAllData = new System.Windows.Forms.Button();
            this.BtnGerateProfilePictures = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCloseProgram
            // 
            this.BtnCloseProgram.Location = new System.Drawing.Point(3, 182);
            this.BtnCloseProgram.Name = "BtnCloseProgram";
            this.BtnCloseProgram.Size = new System.Drawing.Size(75, 24);
            this.BtnCloseProgram.TabIndex = 0;
            this.BtnCloseProgram.Text = "Sair";
            this.BtnCloseProgram.UseVisualStyleBackColor = true;
            this.BtnCloseProgram.Click += new System.EventHandler(this.BtnCloseProgram_Click);
            // 
            // BtnGenerateAllData
            // 
            this.BtnGenerateAllData.Location = new System.Drawing.Point(141, 11);
            this.BtnGenerateAllData.Name = "BtnGenerateAllData";
            this.BtnGenerateAllData.Size = new System.Drawing.Size(176, 41);
            this.BtnGenerateAllData.TabIndex = 1;
            this.BtnGenerateAllData.Text = "Semear base de dados";
            this.BtnGenerateAllData.UseVisualStyleBackColor = true;
            this.BtnGenerateAllData.Click += new System.EventHandler(this.BtnGenerateAllData_Click);
            // 
            // BtnGerateProfilePictures
            // 
            this.BtnGerateProfilePictures.Location = new System.Drawing.Point(141, 58);
            this.BtnGerateProfilePictures.Name = "BtnGerateProfilePictures";
            this.BtnGerateProfilePictures.Size = new System.Drawing.Size(176, 37);
            this.BtnGerateProfilePictures.TabIndex = 2;
            this.BtnGerateProfilePictures.Text = "Fotos de perfil";
            this.BtnGerateProfilePictures.UseVisualStyleBackColor = true;
            this.BtnGerateProfilePictures.Click += new System.EventHandler(this.BtnGerateProfilePictures_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(141, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Imagens de postagens";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnGenerateAllData);
            this.panel1.Controls.Add(this.BtnCloseProgram);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.BtnGerateProfilePictures);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 209);
            this.panel1.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 233);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de dados";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnCloseProgram;
        private Button BtnGenerateAllData;
        private Button BtnGerateProfilePictures;
        private Button button3;
        private Panel panel1;
    }
}