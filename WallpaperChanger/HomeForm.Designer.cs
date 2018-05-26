namespace WallpaperChanger
{
    partial class HomeForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureListCB = new System.Windows.Forms.ComboBox();
            this.SetWallpaperBtn = new System.Windows.Forms.Button();
            this.SetRandomWallpaperBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PictureListCB
            // 
            this.PictureListCB.FormattingEnabled = true;
            this.PictureListCB.Location = new System.Drawing.Point(13, 30);
            this.PictureListCB.Name = "PictureListCB";
            this.PictureListCB.Size = new System.Drawing.Size(178, 21);
            this.PictureListCB.TabIndex = 0;
            // 
            // SetWallpaperBtn
            // 
            this.SetWallpaperBtn.Location = new System.Drawing.Point(197, 28);
            this.SetWallpaperBtn.Name = "SetWallpaperBtn";
            this.SetWallpaperBtn.Size = new System.Drawing.Size(75, 23);
            this.SetWallpaperBtn.TabIndex = 1;
            this.SetWallpaperBtn.Text = "Ustaw";
            this.SetWallpaperBtn.UseVisualStyleBackColor = true;
            this.SetWallpaperBtn.Click += new System.EventHandler(this.SetWallpaperBtn_Click);
            // 
            // SetRandomWallpaperBtn
            // 
            this.SetRandomWallpaperBtn.Location = new System.Drawing.Point(13, 76);
            this.SetRandomWallpaperBtn.Name = "SetRandomWallpaperBtn";
            this.SetRandomWallpaperBtn.Size = new System.Drawing.Size(259, 23);
            this.SetRandomWallpaperBtn.TabIndex = 2;
            this.SetRandomWallpaperBtn.Text = "Ustaw losową tapetę";
            this.SetRandomWallpaperBtn.UseVisualStyleBackColor = true;
            this.SetRandomWallpaperBtn.Click += new System.EventHandler(this.SetRandomWallpaperBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz tapetę:";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetRandomWallpaperBtn);
            this.Controls.Add(this.SetWallpaperBtn);
            this.Controls.Add(this.PictureListCB);
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "HomeForm";
            this.Text = "Wallpaper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PictureListCB;
        private System.Windows.Forms.Button SetWallpaperBtn;
        private System.Windows.Forms.Button SetRandomWallpaperBtn;
        private System.Windows.Forms.Label label1;
    }
}

