namespace Course_work.Forms
{
    partial class FavoriteSpecialtiesForm
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
            this.lstFavoriteSpecialties = new System.Windows.Forms.ListBox();
            this.btnDeleteSpecialty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFavoriteSpecialties
            // 
            this.lstFavoriteSpecialties.FormattingEnabled = true;
            this.lstFavoriteSpecialties.ItemHeight = 16;
            this.lstFavoriteSpecialties.Location = new System.Drawing.Point(136, 54);
            this.lstFavoriteSpecialties.Name = "lstFavoriteSpecialties";
            this.lstFavoriteSpecialties.Size = new System.Drawing.Size(448, 244);
            this.lstFavoriteSpecialties.TabIndex = 0;
            // 
            // btnDeleteSpecialty
            // 
            this.btnDeleteSpecialty.Location = new System.Drawing.Point(479, 304);
            this.btnDeleteSpecialty.Name = "btnDeleteSpecialty";
            this.btnDeleteSpecialty.Size = new System.Drawing.Size(105, 32);
            this.btnDeleteSpecialty.TabIndex = 1;
            this.btnDeleteSpecialty.Text = "Видалити";
            this.btnDeleteSpecialty.UseVisualStyleBackColor = true;
            this.btnDeleteSpecialty.Click += new System.EventHandler(this.btnDeleteSpecialty_Click);
            // 
            // FavoriteSpecialtiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteSpecialty);
            this.Controls.Add(this.lstFavoriteSpecialties);
            this.Name = "FavoriteSpecialtiesForm";
            this.Text = "FavoriteSpecialtiesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFavoriteSpecialties;
        private System.Windows.Forms.Button btnDeleteSpecialty;
    }
}