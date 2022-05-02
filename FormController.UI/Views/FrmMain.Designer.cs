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
            this.BtnCloseProgram.Location = new System.Drawing.Point(3, 201);
            this.BtnCloseProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCloseProgram.Name = "BtnCloseProgram";
            this.BtnCloseProgram.Size = new System.Drawing.Size(86, 32);
            this.BtnCloseProgram.TabIndex = 0;
            this.BtnCloseProgram.Text = "Sair";
            this.BtnCloseProgram.UseVisualStyleBackColor = true;
            this.BtnCloseProgram.Click += new System.EventHandler(this.BtnCloseProgram_Click);
            // 
            // BtnGenerateAllData
            // 
            this.BtnGenerateAllData.Location = new System.Drawing.Point(161, 15);
            this.BtnGenerateAllData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGenerateAllData.Name = "BtnGenerateAllData";
            this.BtnGenerateAllData.Size = new System.Drawing.Size(201, 55);
            this.BtnGenerateAllData.TabIndex = 1;
            this.BtnGenerateAllData.Text = "Semear base de dados";
            this.BtnGenerateAllData.UseVisualStyleBackColor = true;
            this.BtnGenerateAllData.Click += new System.EventHandler(this.BtnGenerateAllData_Click);
            // 
            // BtnGerateProfilePictures
            // 
            this.BtnGerateProfilePictures.Location = new System.Drawing.Point(161, 77);
            this.BtnGerateProfilePictures.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGerateProfilePictures.Name = "BtnGerateProfilePictures";
            this.BtnGerateProfilePictures.Size = new System.Drawing.Size(201, 49);
            this.BtnGerateProfilePictures.TabIndex = 2;
            this.BtnGerateProfilePictures.Text = "Fotos de perfil";
            this.BtnGerateProfilePictures.UseVisualStyleBackColor = true;
            this.BtnGerateProfilePictures.Click += new System.EventHandler(this.BtnGerateProfilePictures_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(161, 135);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 53);
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
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 237);
            this.panel1.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 256);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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