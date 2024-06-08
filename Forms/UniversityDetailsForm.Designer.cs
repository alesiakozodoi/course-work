using System.Windows.Forms;

namespace Course_work.Forms
{
    partial class UniversityDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblNameTitle;
        private Label lblName;
        private Label lblLocationTitle;
        private Label lblLocation;
        private Label lblRatingTitle;
        private Label lblRating;
        private Label lblSpecialtiesTitle;
        private ListBox lstSpecialties;

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
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLocationTitle = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblRatingTitle = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblSpecialtiesTitle = new System.Windows.Forms.Label();
            this.lstSpecialties = new System.Windows.Forms.ListBox();
            this.btnSpecialtyDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Location = new System.Drawing.Point(20, 20);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(143, 16);
            this.lblNameTitle.TabIndex = 0;
            this.lblNameTitle.Text = "Назва університету:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(160, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 1;
            // 
            // lblLocationTitle
            // 
            this.lblLocationTitle.AutoSize = true;
            this.lblLocationTitle.Location = new System.Drawing.Point(20, 50);
            this.lblLocationTitle.Name = "lblLocationTitle";
            this.lblLocationTitle.Size = new System.Drawing.Size(136, 16);
            this.lblLocationTitle.TabIndex = 2;
            this.lblLocationTitle.Text = "Місце знаходження:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(160, 50);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(0, 16);
            this.lblLocation.TabIndex = 3;
            // 
            // lblRatingTitle
            // 
            this.lblRatingTitle.AutoSize = true;
            this.lblRatingTitle.Location = new System.Drawing.Point(20, 80);
            this.lblRatingTitle.Name = "lblRatingTitle";
            this.lblRatingTitle.Size = new System.Drawing.Size(64, 16);
            this.lblRatingTitle.TabIndex = 4;
            this.lblRatingTitle.Text = "Рейтинг:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(160, 80);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(0, 16);
            this.lblRating.TabIndex = 5;
            // 
            // lblSpecialtiesTitle
            // 
            this.lblSpecialtiesTitle.AutoSize = true;
            this.lblSpecialtiesTitle.Location = new System.Drawing.Point(20, 110);
            this.lblSpecialtiesTitle.Name = "lblSpecialtiesTitle";
            this.lblSpecialtiesTitle.Size = new System.Drawing.Size(102, 16);
            this.lblSpecialtiesTitle.TabIndex = 6;
            this.lblSpecialtiesTitle.Text = "Спеціальності:";
            // 
            // lstSpecialties
            // 
            this.lstSpecialties.FormattingEnabled = true;
            this.lstSpecialties.ItemHeight = 16;
            this.lstSpecialties.Location = new System.Drawing.Point(128, 110);
            this.lstSpecialties.Name = "lstSpecialties";
            this.lstSpecialties.Size = new System.Drawing.Size(300, 196);
            this.lstSpecialties.TabIndex = 7;
            // 
            // btnSpecialtyDetails
            // 
            this.btnSpecialtyDetails.Location = new System.Drawing.Point(325, 312);
            this.btnSpecialtyDetails.Name = "btnSpecialtyDetails";
            this.btnSpecialtyDetails.Size = new System.Drawing.Size(103, 31);
            this.btnSpecialtyDetails.TabIndex = 8;
            this.btnSpecialtyDetails.Text = "Детальніше";
            this.btnSpecialtyDetails.UseVisualStyleBackColor = true;
            this.btnSpecialtyDetails.Click += new System.EventHandler(this.btnSpecialtyDetails_Click);
            // 
            // UniversityDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 403);
            this.Controls.Add(this.btnSpecialtyDetails);
            this.Controls.Add(this.lstSpecialties);
            this.Controls.Add(this.lblSpecialtiesTitle);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblRatingTitle);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblLocationTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameTitle);
            this.Name = "UniversityDetailsForm";
            this.Text = "University Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btnSpecialtyDetails;
    }
}