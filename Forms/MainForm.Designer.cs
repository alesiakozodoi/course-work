namespace Course_work.Forms
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUniversityName = new System.Windows.Forms.TextBox();
            this.txtSpecialityName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.labelUniversityName = new System.Windows.Forms.Label();
            this.labelSpecialityName = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.txtTuitionFeeFrom = new System.Windows.Forms.TextBox();
            this.txtTuitionFeeTo = new System.Windows.Forms.TextBox();
            this.labelTuitionFee = new System.Windows.Forms.Label();
            this.labelTuitionFeeFrom = new System.Windows.Forms.Label();
            this.labelTuitionFeeTo = new System.Windows.Forms.Label();
            this.txtFormsOfStudy = new System.Windows.Forms.TextBox();
            this.labelFormsOfStudy = new System.Windows.Forms.Label();
            this.btnOpenEditor = new System.Windows.Forms.Button();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnFavoriteSpecialties = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(85, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 519);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUniversityName
            // 
            this.txtUniversityName.Location = new System.Drawing.Point(261, 76);
            this.txtUniversityName.Name = "txtUniversityName";
            this.txtUniversityName.Size = new System.Drawing.Size(259, 22);
            this.txtUniversityName.TabIndex = 1;
            // 
            // txtSpecialityName
            // 
            this.txtSpecialityName.Location = new System.Drawing.Point(261, 104);
            this.txtSpecialityName.Name = "txtSpecialityName";
            this.txtSpecialityName.Size = new System.Drawing.Size(259, 22);
            this.txtSpecialityName.TabIndex = 2;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(261, 132);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(259, 22);
            this.txtLocation.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(326, 225);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 16;
            this.lstResults.Location = new System.Drawing.Point(210, 338);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(366, 132);
            this.lstResults.TabIndex = 5;
            this.lstResults.SelectedIndexChanged += new System.EventHandler(this.lstResults_SelectedIndexChanged);
            // 
            // labelUniversityName
            // 
            this.labelUniversityName.AutoSize = true;
            this.labelUniversityName.Location = new System.Drawing.Point(115, 82);
            this.labelUniversityName.Name = "labelUniversityName";
            this.labelUniversityName.Size = new System.Drawing.Size(140, 16);
            this.labelUniversityName.TabIndex = 6;
            this.labelUniversityName.Text = "Назва університету";
            // 
            // labelSpecialityName
            // 
            this.labelSpecialityName.AutoSize = true;
            this.labelSpecialityName.Location = new System.Drawing.Point(113, 107);
            this.labelSpecialityName.Name = "labelSpecialityName";
            this.labelSpecialityName.Size = new System.Drawing.Size(142, 16);
            this.labelSpecialityName.TabIndex = 7;
            this.labelSpecialityName.Text = "Назва спеціальності";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(212, 135);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(43, 16);
            this.labelLocation.TabIndex = 8;
            this.labelLocation.Text = "Місто";
            // 
            // txtTuitionFeeFrom
            // 
            this.txtTuitionFeeFrom.Location = new System.Drawing.Point(326, 160);
            this.txtTuitionFeeFrom.Name = "txtTuitionFeeFrom";
            this.txtTuitionFeeFrom.Size = new System.Drawing.Size(74, 22);
            this.txtTuitionFeeFrom.TabIndex = 9;
            // 
            // txtTuitionFeeTo
            // 
            this.txtTuitionFeeTo.Location = new System.Drawing.Point(438, 160);
            this.txtTuitionFeeTo.Name = "txtTuitionFeeTo";
            this.txtTuitionFeeTo.Size = new System.Drawing.Size(82, 22);
            this.txtTuitionFeeTo.TabIndex = 10;
            // 
            // labelTuitionFee
            // 
            this.labelTuitionFee.AutoSize = true;
            this.labelTuitionFee.Location = new System.Drawing.Point(126, 163);
            this.labelTuitionFee.Name = "labelTuitionFee";
            this.labelTuitionFee.Size = new System.Drawing.Size(129, 16);
            this.labelTuitionFee.TabIndex = 11;
            this.labelTuitionFee.Text = "Вартість навчання";
            // 
            // labelTuitionFeeFrom
            // 
            this.labelTuitionFeeFrom.AutoSize = true;
            this.labelTuitionFeeFrom.Location = new System.Drawing.Point(291, 166);
            this.labelTuitionFeeFrom.Name = "labelTuitionFeeFrom";
            this.labelTuitionFeeFrom.Size = new System.Drawing.Size(29, 16);
            this.labelTuitionFeeFrom.TabIndex = 12;
            this.labelTuitionFeeFrom.Text = "від:";
            // 
            // labelTuitionFeeTo
            // 
            this.labelTuitionFeeTo.AutoSize = true;
            this.labelTuitionFeeTo.Location = new System.Drawing.Point(406, 166);
            this.labelTuitionFeeTo.Name = "labelTuitionFeeTo";
            this.labelTuitionFeeTo.Size = new System.Drawing.Size(26, 16);
            this.labelTuitionFeeTo.TabIndex = 13;
            this.labelTuitionFeeTo.Text = "до:";
            // 
            // txtFormsOfStudy
            // 
            this.txtFormsOfStudy.Location = new System.Drawing.Point(261, 188);
            this.txtFormsOfStudy.Name = "txtFormsOfStudy";
            this.txtFormsOfStudy.Size = new System.Drawing.Size(259, 22);
            this.txtFormsOfStudy.TabIndex = 14;
            // 
            // labelFormsOfStudy
            // 
            this.labelFormsOfStudy.AutoSize = true;
            this.labelFormsOfStudy.Location = new System.Drawing.Point(138, 191);
            this.labelFormsOfStudy.Name = "labelFormsOfStudy";
            this.labelFormsOfStudy.Size = new System.Drawing.Size(117, 16);
            this.labelFormsOfStudy.TabIndex = 15;
            this.labelFormsOfStudy.Text = "Форма навчання";
            // 
            // btnOpenEditor
            // 
            this.btnOpenEditor.Location = new System.Drawing.Point(383, 308);
            this.btnOpenEditor.Name = "btnOpenEditor";
            this.btnOpenEditor.Size = new System.Drawing.Size(193, 24);
            this.btnOpenEditor.TabIndex = 16;
            this.btnOpenEditor.Text = "Редагувати університети";
            this.btnOpenEditor.UseVisualStyleBackColor = true;
            this.btnOpenEditor.Click += new System.EventHandler(this.btnOpenEditor_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(463, 476);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(113, 37);
            this.btnShowInfo.TabIndex = 17;
            this.btnShowInfo.Text = "Детальніше";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // btnFavoriteSpecialties
            // 
            this.btnFavoriteSpecialties.Location = new System.Drawing.Point(634, 44);
            this.btnFavoriteSpecialties.Name = "btnFavoriteSpecialties";
            this.btnFavoriteSpecialties.Size = new System.Drawing.Size(109, 32);
            this.btnFavoriteSpecialties.TabIndex = 18;
            this.btnFavoriteSpecialties.Text = "Обране";
            this.btnFavoriteSpecialties.UseVisualStyleBackColor = true;
            this.btnFavoriteSpecialties.Click += new System.EventHandler(this.btnFavoriteSpecialties_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(868, 585);
            this.Controls.Add(this.btnFavoriteSpecialties);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.btnOpenEditor);
            this.Controls.Add(this.labelFormsOfStudy);
            this.Controls.Add(this.txtFormsOfStudy);
            this.Controls.Add(this.labelTuitionFeeTo);
            this.Controls.Add(this.labelTuitionFeeFrom);
            this.Controls.Add(this.labelTuitionFee);
            this.Controls.Add(this.txtTuitionFeeTo);
            this.Controls.Add(this.txtTuitionFeeFrom);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelSpecialityName);
            this.Controls.Add(this.labelUniversityName);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtSpecialityName);
            this.Controls.Add(this.txtUniversityName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "University Search";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUniversityName;
        private System.Windows.Forms.TextBox txtSpecialityName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label labelUniversityName;
        private System.Windows.Forms.Label labelSpecialityName;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox txtTuitionFeeFrom;
        private System.Windows.Forms.TextBox txtTuitionFeeTo;
        private System.Windows.Forms.Label labelTuitionFee;
        private System.Windows.Forms.Label labelTuitionFeeFrom;
        private System.Windows.Forms.Label labelTuitionFeeTo;
        private System.Windows.Forms.TextBox txtFormsOfStudy;
        private System.Windows.Forms.Label labelFormsOfStudy;
        private System.Windows.Forms.Button btnOpenEditor;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Button btnFavoriteSpecialties;
    }
}