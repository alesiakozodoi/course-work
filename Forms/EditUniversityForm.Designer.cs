using Course_work.Models;

namespace Course_work.Forms
{
    partial class EditUniversityForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstUniversities;
        private System.Windows.Forms.ListBox lstSpecialties;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtSpecialtyName;
        private System.Windows.Forms.TextBox txtMinimumCompetition;
        private System.Windows.Forms.TextBox txtTuitionFee;
        private System.Windows.Forms.TextBox txtFormsOfStudy;
        private System.Windows.Forms.Button btnAddUniversity;
        private System.Windows.Forms.Button btnEditUniversity;
        private System.Windows.Forms.Button btnDeleteUniversity;
        private System.Windows.Forms.Button btnSaveUniversity;
        private System.Windows.Forms.Button btnAddSpecialty;
        private System.Windows.Forms.Button btnEditSpecialty;
        private System.Windows.Forms.Button btnDeleteSpecialty;
        private System.Windows.Forms.Button btnSaveSpecialty;

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
            this.lstUniversities = new System.Windows.Forms.ListBox();
            this.lstSpecialties = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtSpecialtyName = new System.Windows.Forms.TextBox();
            this.txtMinimumCompetition = new System.Windows.Forms.TextBox();
            this.txtTuitionFee = new System.Windows.Forms.TextBox();
            this.txtFormsOfStudy = new System.Windows.Forms.TextBox();
            this.btnAddUniversity = new System.Windows.Forms.Button();
            this.btnEditUniversity = new System.Windows.Forms.Button();
            this.btnDeleteUniversity = new System.Windows.Forms.Button();
            this.btnSaveUniversity = new System.Windows.Forms.Button();
            this.btnAddSpecialty = new System.Windows.Forms.Button();
            this.btnEditSpecialty = new System.Windows.Forms.Button();
            this.btnDeleteSpecialty = new System.Windows.Forms.Button();
            this.btnSaveSpecialty = new System.Windows.Forms.Button();
            this.labelUniversityName = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelSpecialtyName = new System.Windows.Forms.Label();
            this.labelMinimumCompetition = new System.Windows.Forms.Label();
            this.labelFormsOfStudy = new System.Windows.Forms.Label();
            this.labelTuitionFee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstUniversities
            // 
            this.lstUniversities.FormattingEnabled = true;
            this.lstUniversities.ItemHeight = 16;
            this.lstUniversities.Location = new System.Drawing.Point(37, 80);
            this.lstUniversities.Name = "lstUniversities";
            this.lstUniversities.Size = new System.Drawing.Size(200, 276);
            this.lstUniversities.TabIndex = 0;
            // 
            // lstSpecialties
            // 
            this.lstSpecialties.FormattingEnabled = true;
            this.lstSpecialties.ItemHeight = 16;
            this.lstSpecialties.Location = new System.Drawing.Point(255, 80);
            this.lstSpecialties.Name = "lstSpecialties";
            this.lstSpecialties.Size = new System.Drawing.Size(200, 276);
            this.lstSpecialties.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(741, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(741, 130);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(150, 22);
            this.txtLocation.TabIndex = 3;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(741, 158);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(150, 22);
            this.txtRating.TabIndex = 4;
            // 
            // txtSpecialtyName
            // 
            this.txtSpecialtyName.Location = new System.Drawing.Point(741, 221);
            this.txtSpecialtyName.Name = "txtSpecialtyName";
            this.txtSpecialtyName.Size = new System.Drawing.Size(150, 22);
            this.txtSpecialtyName.TabIndex = 5;
            // 
            // txtMinimumCompetition
            // 
            this.txtMinimumCompetition.Location = new System.Drawing.Point(741, 249);
            this.txtMinimumCompetition.Name = "txtMinimumCompetition";
            this.txtMinimumCompetition.Size = new System.Drawing.Size(150, 22);
            this.txtMinimumCompetition.TabIndex = 6;
            // 
            // txtTuitionFee
            // 
            this.txtTuitionFee.Location = new System.Drawing.Point(741, 305);
            this.txtTuitionFee.Name = "txtTuitionFee";
            this.txtTuitionFee.Size = new System.Drawing.Size(150, 22);
            this.txtTuitionFee.TabIndex = 7;
            // 
            // txtFormsOfStudy
            // 
            this.txtFormsOfStudy.Location = new System.Drawing.Point(741, 277);
            this.txtFormsOfStudy.Name = "txtFormsOfStudy";
            this.txtFormsOfStudy.Size = new System.Drawing.Size(150, 22);
            this.txtFormsOfStudy.TabIndex = 8;
            // 
            // btnAddUniversity
            // 
            this.btnAddUniversity.Location = new System.Drawing.Point(37, 378);
            this.btnAddUniversity.Name = "btnAddUniversity";
            this.btnAddUniversity.Size = new System.Drawing.Size(200, 23);
            this.btnAddUniversity.TabIndex = 9;
            this.btnAddUniversity.Text = "Додати Університет";
            this.btnAddUniversity.UseVisualStyleBackColor = true;
            this.btnAddUniversity.Click += new System.EventHandler(this.btnAddUniversity_Click);
            // 
            // btnEditUniversity
            // 
            this.btnEditUniversity.Location = new System.Drawing.Point(37, 407);
            this.btnEditUniversity.Name = "btnEditUniversity";
            this.btnEditUniversity.Size = new System.Drawing.Size(200, 23);
            this.btnEditUniversity.TabIndex = 10;
            this.btnEditUniversity.Text = "Редагувати Університет";
            this.btnEditUniversity.UseVisualStyleBackColor = true;
            this.btnEditUniversity.Click += new System.EventHandler(this.btnEditUniversity_Click);
            // 
            // btnDeleteUniversity
            // 
            this.btnDeleteUniversity.Location = new System.Drawing.Point(37, 436);
            this.btnDeleteUniversity.Name = "btnDeleteUniversity";
            this.btnDeleteUniversity.Size = new System.Drawing.Size(200, 23);
            this.btnDeleteUniversity.TabIndex = 11;
            this.btnDeleteUniversity.Text = "Видалити Університет";
            this.btnDeleteUniversity.UseVisualStyleBackColor = true;
            this.btnDeleteUniversity.Click += new System.EventHandler(this.btnDeleteUniversity_Click);
            // 
            // btnSaveUniversity
            // 
            this.btnSaveUniversity.Location = new System.Drawing.Point(741, 186);
            this.btnSaveUniversity.Name = "btnSaveUniversity";
            this.btnSaveUniversity.Size = new System.Drawing.Size(150, 23);
            this.btnSaveUniversity.TabIndex = 12;
            this.btnSaveUniversity.Text = "Зберегти Університет";
            this.btnSaveUniversity.UseVisualStyleBackColor = true;
            this.btnSaveUniversity.Click += new System.EventHandler(this.btnSaveUniversity_Click);
            // 
            // btnAddSpecialty
            // 
            this.btnAddSpecialty.Location = new System.Drawing.Point(255, 378);
            this.btnAddSpecialty.Name = "btnAddSpecialty";
            this.btnAddSpecialty.Size = new System.Drawing.Size(200, 23);
            this.btnAddSpecialty.TabIndex = 13;
            this.btnAddSpecialty.Text = "Додати Спеціальність";
            this.btnAddSpecialty.UseVisualStyleBackColor = true;
            this.btnAddSpecialty.Click += new System.EventHandler(this.btnAddSpecialty_Click);
            // 
            // btnEditSpecialty
            // 
            this.btnEditSpecialty.Location = new System.Drawing.Point(255, 407);
            this.btnEditSpecialty.Name = "btnEditSpecialty";
            this.btnEditSpecialty.Size = new System.Drawing.Size(200, 23);
            this.btnEditSpecialty.TabIndex = 14;
            this.btnEditSpecialty.Text = "Редагувати Спеціальність";
            this.btnEditSpecialty.UseVisualStyleBackColor = true;
            this.btnEditSpecialty.Click += new System.EventHandler(this.btnEditSpecialty_Click);
            // 
            // btnDeleteSpecialty
            // 
            this.btnDeleteSpecialty.Location = new System.Drawing.Point(255, 436);
            this.btnDeleteSpecialty.Name = "btnDeleteSpecialty";
            this.btnDeleteSpecialty.Size = new System.Drawing.Size(200, 23);
            this.btnDeleteSpecialty.TabIndex = 15;
            this.btnDeleteSpecialty.Text = "Видалити Спеціальність";
            this.btnDeleteSpecialty.UseVisualStyleBackColor = true;
            this.btnDeleteSpecialty.Click += new System.EventHandler(this.btnDeleteSpecialty_Click);
            // 
            // btnSaveSpecialty
            // 
            this.btnSaveSpecialty.Location = new System.Drawing.Point(741, 333);
            this.btnSaveSpecialty.Name = "btnSaveSpecialty";
            this.btnSaveSpecialty.Size = new System.Drawing.Size(150, 23);
            this.btnSaveSpecialty.TabIndex = 16;
            this.btnSaveSpecialty.Text = "Зберегти Спеціальність";
            this.btnSaveSpecialty.UseVisualStyleBackColor = true;
            this.btnSaveSpecialty.Click += new System.EventHandler(this.btnSaveSpecialty_Click);
            // 
            // labelUniversityName
            // 
            this.labelUniversityName.AutoSize = true;
            this.labelUniversityName.Location = new System.Drawing.Point(595, 105);
            this.labelUniversityName.Name = "labelUniversityName";
            this.labelUniversityName.Size = new System.Drawing.Size(140, 16);
            this.labelUniversityName.TabIndex = 17;
            this.labelUniversityName.Text = "Назва університету";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(692, 136);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(43, 16);
            this.labelLocation.TabIndex = 18;
            this.labelLocation.Text = "Місто";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(605, 164);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(130, 16);
            this.labelRating.TabIndex = 19;
            this.labelRating.Text = "Рейтингова оцінка";
            // 
            // labelSpecialtyName
            // 
            this.labelSpecialtyName.AutoSize = true;
            this.labelSpecialtyName.Location = new System.Drawing.Point(637, 227);
            this.labelSpecialtyName.Name = "labelSpecialtyName";
            this.labelSpecialtyName.Size = new System.Drawing.Size(98, 16);
            this.labelSpecialtyName.TabIndex = 20;
            this.labelSpecialtyName.Text = "Спеціальність";
            // 
            // labelMinimumCompetition
            // 
            this.labelMinimumCompetition.AutoSize = true;
            this.labelMinimumCompetition.Location = new System.Drawing.Point(608, 252);
            this.labelMinimumCompetition.Name = "labelMinimumCompetition";
            this.labelMinimumCompetition.Size = new System.Drawing.Size(127, 16);
            this.labelMinimumCompetition.TabIndex = 21;
            this.labelMinimumCompetition.Text = "Мін. прохідний бал";
            // 
            // labelFormsOfStudy
            // 
            this.labelFormsOfStudy.AutoSize = true;
            this.labelFormsOfStudy.Location = new System.Drawing.Point(618, 283);
            this.labelFormsOfStudy.Name = "labelFormsOfStudy";
            this.labelFormsOfStudy.Size = new System.Drawing.Size(117, 16);
            this.labelFormsOfStudy.TabIndex = 23;
            this.labelFormsOfStudy.Text = "Форма навчання";
            // 
            // labelTuitionFee
            // 
            this.labelTuitionFee.AutoSize = true;
            this.labelTuitionFee.Location = new System.Drawing.Point(573, 311);
            this.labelTuitionFee.Name = "labelTuitionFee";
            this.labelTuitionFee.Size = new System.Drawing.Size(162, 16);
            this.labelTuitionFee.TabIndex = 24;
            this.labelTuitionFee.Text = "Оплата за рік навчання";
            // 
            // EditUniversityForm
            // 
            this.ClientSize = new System.Drawing.Size(1005, 573);
            this.Controls.Add(this.labelTuitionFee);
            this.Controls.Add(this.labelFormsOfStudy);
            this.Controls.Add(this.labelMinimumCompetition);
            this.Controls.Add(this.labelSpecialtyName);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelUniversityName);
            this.Controls.Add(this.btnSaveSpecialty);
            this.Controls.Add(this.btnDeleteSpecialty);
            this.Controls.Add(this.btnEditSpecialty);
            this.Controls.Add(this.btnAddSpecialty);
            this.Controls.Add(this.btnSaveUniversity);
            this.Controls.Add(this.btnDeleteUniversity);
            this.Controls.Add(this.btnEditUniversity);
            this.Controls.Add(this.btnAddUniversity);
            this.Controls.Add(this.txtFormsOfStudy);
            this.Controls.Add(this.txtTuitionFee);
            this.Controls.Add(this.txtMinimumCompetition);
            this.Controls.Add(this.txtSpecialtyName);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstSpecialties);
            this.Controls.Add(this.lstUniversities);
            this.Name = "EditUniversityForm";
            this.Load += new System.EventHandler(this.EditUniversityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelUniversityName;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelSpecialtyName;
        private System.Windows.Forms.Label labelMinimumCompetition;
        private System.Windows.Forms.Label labelFormsOfStudy;
        private System.Windows.Forms.Label labelTuitionFee;
    }
}