namespace FormController.UI.Views
{
    partial class SeedImageProfilePicture
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
            this.components = new System.ComponentModel.Container();
            this.BtnLoadProfilePictures = new System.Windows.Forms.Button();
            this.SendProfilePictures = new System.Windows.Forms.Button();
            this.ImgListProfilePictures = new System.Windows.Forms.ImageList(this.components);
            this.qtyProfilePicturesLoaded = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLoadProfilePictures
            // 
            this.BtnLoadProfilePictures.Location = new System.Drawing.Point(109, 23);
            this.BtnLoadProfilePictures.Name = "BtnLoadProfilePictures";
            this.BtnLoadProfilePictures.Size = new System.Drawing.Size(156, 28);
            this.BtnLoadProfilePictures.TabIndex = 0;
            this.BtnLoadProfilePictures.Text = "Carregar imagens";
            this.BtnLoadProfilePictures.UseVisualStyleBackColor = true;
            this.BtnLoadProfilePictures.Click += new System.EventHandler(this.BtnLoadProfilePictures_Click);
            // 
            // SendProfilePictures
            // 
            this.SendProfilePictures.BackColor = System.Drawing.Color.SeaGreen;
            this.SendProfilePictures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendProfilePictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendProfilePictures.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SendProfilePictures.Location = new System.Drawing.Point(109, 142);
            this.SendProfilePictures.Name = "SendProfilePictures";
            this.SendProfilePictures.Size = new System.Drawing.Size(156, 38);
            this.SendProfilePictures.TabIndex = 1;
            this.SendProfilePictures.Text = "Enviar";
            this.SendProfilePictures.UseVisualStyleBackColor = false;
            this.SendProfilePictures.Click += new System.EventHandler(this.SendProfilePictures_Click);
            // 
            // ImgListProfilePictures
            // 
            this.ImgListProfilePictures.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgListProfilePictures.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgListProfilePictures.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // qtyProfilePicturesLoaded
            // 
            this.qtyProfilePicturesLoaded.AutoSize = true;
            this.qtyProfilePicturesLoaded.Location = new System.Drawing.Point(126, 113);
            this.qtyProfilePicturesLoaded.Name = "qtyProfilePicturesLoaded";
            this.qtyProfilePicturesLoaded.Size = new System.Drawing.Size(121, 15);
            this.qtyProfilePicturesLoaded.TabIndex = 2;
            this.qtyProfilePicturesLoaded.Text = "0 imagens carregadas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnLoadProfilePictures);
            this.panel1.Controls.Add(this.SendProfilePictures);
            this.panel1.Controls.Add(this.qtyProfilePicturesLoaded);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 204);
            this.panel1.TabIndex = 3;
            // 
            // SeedImageProfilePicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 212);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeedImageProfilePicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeedImageProfilePicture";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnLoadProfilePictures;
        private Button SendProfilePictures;
        private ImageList ImgListProfilePictures;
        private Label qtyProfilePicturesLoaded;
        private Panel panel1;
    }
}