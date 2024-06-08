using System.Windows.Forms;


namespace Course_work.Forms
{
    partial class SpecialtyDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUniversityNameTitle;
        private Label lblUniversityName;
        private Label lblUniversityLocationTitle;
        private Label lblUniversityLocation;
        private Label lblSpecialtyNameTitle;
        private Label lblSpecialtyName;
        private Label lblMinimumCompetitionTitle;
        private Label lblMinimumCompetition;
        private Label lblTuitionFeeTitle;
        private Label lblTuitionFee;
        private Label lblFormsOfStudyTitle;
        private Label lblFormsOfStudy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUniversityNameTitle = new System.Windows.Forms.Label();
            this.lblUniversityName = new System.Windows.Forms.Label();
            this.lblUniversityLocationTitle = new System.Windows.Forms.Label();
            this.lblUniversityLocation = new System.Windows.Forms.Label();
            this.lblSpecialtyNameTitle = new System.Windows.Forms.Label();
            this.lblSpecialtyName = new System.Windows.Forms.Label();
            this.lblMinimumCompetitionTitle = new System.Windows.Forms.Label();
            this.lblMinimumCompetition = new System.Windows.Forms.Label();
            this.lblTuitionFeeTitle = new System.Windows.Forms.Label();
            this.lblTuitionFee = new System.Windows.Forms.Label();
            this.lblFormsOfStudyTitle = new System.Windows.Forms.Label();
            this.lblFormsOfStudy = new System.Windows.Forms.Label();
            this.btnDownloadToFile = new System.Windows.Forms.Button();
            this.btnAddToFavorites = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUniversityNameTitle
            // 
            this.lblUniversityNameTitle.AutoSize = true;
            this.lblUniversityNameTitle.Location = new System.Drawing.Point(20, 20);
            this.lblUniversityNameTitle.Name = "lblUniversityNameTitle";
            this.lblUniversityNameTitle.Size = new System.Drawing.Size(143, 16);
            this.lblUniversityNameTitle.TabIndex = 0;
            this.lblUniversityNameTitle.Text = "Назва університету:";
            // 
            // lblUniversityName
            // 
            this.lblUniversityName.AutoSize = true;
            this.lblUniversityName.Location = new System.Drawing.Point(200, 20);
            this.lblUniversityName.Name = "lblUniversityName";
            this.lblUniversityName.Size = new System.Drawing.Size(0, 16);
            this.lblUniversityName.TabIndex = 1;
            // 
            // lblUniversityLocationTitle
            // 
            this.lblUniversityLocationTitle.AutoSize = true;
            this.lblUniversityLocationTitle.Location = new System.Drawing.Point(20, 50);
            this.lblUniversityLocationTitle.Name = "lblUniversityLocationTitle";
            this.lblUniversityLocationTitle.Size = new System.Drawing.Size(46, 16);
            this.lblUniversityLocationTitle.TabIndex = 2;
            this.lblUniversityLocationTitle.Text = "Місто:";
            // 
            // lblUniversityLocation
            // 
            this.lblUniversityLocation.AutoSize = true;
            this.lblUniversityLocation.Location = new System.Drawing.Point(200, 50);
            this.lblUniversityLocation.Name = "lblUniversityLocation";
            this.lblUniversityLocation.Size = new System.Drawing.Size(0, 16);
            this.lblUniversityLocation.TabIndex = 3;
            // 
            // lblSpecialtyNameTitle
            // 
            this.lblSpecialtyNameTitle.AutoSize = true;
            this.lblSpecialtyNameTitle.Location = new System.Drawing.Point(20, 80);
            this.lblSpecialtyNameTitle.Name = "lblSpecialtyNameTitle";
            this.lblSpecialtyNameTitle.Size = new System.Drawing.Size(101, 16);
            this.lblSpecialtyNameTitle.TabIndex = 4;
            this.lblSpecialtyNameTitle.Text = "Спеціальність:";
            // 
            // lblSpecialtyName
            // 
            this.lblSpecialtyName.AutoSize = true;
            this.lblSpecialtyName.Location = new System.Drawing.Point(200, 80);
            this.lblSpecialtyName.Name = "lblSpecialtyName";
            this.lblSpecialtyName.Size = new System.Drawing.Size(0, 16);
            this.lblSpecialtyName.TabIndex = 5;
            // 
            // lblMinimumCompetitionTitle
            // 
            this.lblMinimumCompetitionTitle.AutoSize = true;
            this.lblMinimumCompetitionTitle.Location = new System.Drawing.Point(20, 110);
            this.lblMinimumCompetitionTitle.Name = "lblMinimumCompetitionTitle";
            this.lblMinimumCompetitionTitle.Size = new System.Drawing.Size(130, 16);
            this.lblMinimumCompetitionTitle.TabIndex = 6;
            this.lblMinimumCompetitionTitle.Text = "Мін. прохідний бал:";
            // 
            // lblMinimumCompetition
            // 
            this.lblMinimumCompetition.AutoSize = true;
            this.lblMinimumCompetition.Location = new System.Drawing.Point(200, 110);
            this.lblMinimumCompetition.Name = "lblMinimumCompetition";
            this.lblMinimumCompetition.Size = new System.Drawing.Size(0, 16);
            this.lblMinimumCompetition.TabIndex = 7;
            // 
            // lblTuitionFeeTitle
            // 
            this.lblTuitionFeeTitle.AutoSize = true;
            this.lblTuitionFeeTitle.Location = new System.Drawing.Point(20, 140);
            this.lblTuitionFeeTitle.Name = "lblTuitionFeeTitle";
            this.lblTuitionFeeTitle.Size = new System.Drawing.Size(165, 16);
            this.lblTuitionFeeTitle.TabIndex = 8;
            this.lblTuitionFeeTitle.Text = "Оплата за рік навчання:";
            // 
            // lblTuitionFee
            // 
            this.lblTuitionFee.AutoSize = true;
            this.lblTuitionFee.Location = new System.Drawing.Point(200, 140);
            this.lblTuitionFee.Name = "lblTuitionFee";
            this.lblTuitionFee.Size = new System.Drawing.Size(0, 16);
            this.lblTuitionFee.TabIndex = 9;
            // 
            // lblFormsOfStudyTitle
            // 
            this.lblFormsOfStudyTitle.AutoSize = true;
            this.lblFormsOfStudyTitle.Location = new System.Drawing.Point(20, 170);
            this.lblFormsOfStudyTitle.Name = "lblFormsOfStudyTitle";
            this.lblFormsOfStudyTitle.Size = new System.Drawing.Size(120, 16);
            this.lblFormsOfStudyTitle.TabIndex = 10;
            this.lblFormsOfStudyTitle.Text = "Форма навчання:";
            // 
            // lblFormsOfStudy
            // 
            this.lblFormsOfStudy.AutoSize = true;
            this.lblFormsOfStudy.Location = new System.Drawing.Point(200, 170);
            this.lblFormsOfStudy.Name = "lblFormsOfStudy";
            this.lblFormsOfStudy.Size = new System.Drawing.Size(0, 16);
            this.lblFormsOfStudy.TabIndex = 11;
            // 
            // btnDownloadToFile
            // 
            this.btnDownloadToFile.Location = new System.Drawing.Point(23, 225);
            this.btnDownloadToFile.Name = "btnDownloadToFile";
            this.btnDownloadToFile.Size = new System.Drawing.Size(117, 31);
            this.btnDownloadToFile.TabIndex = 12;
            this.btnDownloadToFile.Text = "Завантажити";
            this.btnDownloadToFile.UseVisualStyleBackColor = true;
            this.btnDownloadToFile.Click += new System.EventHandler(this.btnDownloadToFile_Click);
            // 
            // btnAddToFavorites
            // 
            this.btnAddToFavorites.Location = new System.Drawing.Point(156, 225);
            this.btnAddToFavorites.Name = "btnAddToFavorites";
            this.btnAddToFavorites.Size = new System.Drawing.Size(156, 31);
            this.btnAddToFavorites.TabIndex = 13;
            this.btnAddToFavorites.Text = "Додати в обране";
            this.btnAddToFavorites.UseVisualStyleBackColor = true;
            this.btnAddToFavorites.Click += new System.EventHandler(this.btnAddToFavorites_Click);
            // 
            // SpecialtyDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.btnAddToFavorites);
            this.Controls.Add(this.btnDownloadToFile);
            this.Controls.Add(this.lblFormsOfStudy);
            this.Controls.Add(this.lblFormsOfStudyTitle);
            this.Controls.Add(this.lblTuitionFee);
            this.Controls.Add(this.lblTuitionFeeTitle);
            this.Controls.Add(this.lblMinimumCompetition);
            this.Controls.Add(this.lblMinimumCompetitionTitle);
            this.Controls.Add(this.lblSpecialtyName);
            this.Controls.Add(this.lblSpecialtyNameTitle);
            this.Controls.Add(this.lblUniversityLocation);
            this.Controls.Add(this.lblUniversityLocationTitle);
            this.Controls.Add(this.lblUniversityName);
            this.Controls.Add(this.lblUniversityNameTitle);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "SpecialtyDetailsForm";
            this.Text = "Specialty Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btnDownloadToFile;
        private Button btnAddToFavorites;
    }
}