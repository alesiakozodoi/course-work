using Course_work.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Newtonsoft.Json;

namespace Course_work.Forms
{
    public partial class SpecialtyDetailsForm : Form
    {
        private University university;
        private Specialty specialty;
        private List<Specialty> favoriteSpecialties;

        public SpecialtyDetailsForm(University university, Specialty specialty, List<Specialty> favoriteSpecialties)
        {
            InitializeComponent();
            this.university = university;
            this.specialty = specialty;
            this.favoriteSpecialties = favoriteSpecialties ?? new List<Specialty>();
            DisplaySpecialtyDetails();
            btnDownloadToFile.Click += btnDownloadToFile_Click;
            btnAddToFavorites.Click += btnAddToFavorites_Click;
        }

        private void DisplaySpecialtyDetails()
        {
            lblUniversityName.Text = university.Name;
            lblUniversityLocation.Text = university.Location;
            lblSpecialtyName.Text = specialty.Name;
            lblMinimumCompetition.Text = specialty.MinimumCompetition.ToString();
            lblTuitionFee.Text = specialty.TuitionFee.ToString();
            lblFormsOfStudy.Text = specialty.FormsOfStudy;
        }

        private void btnDownloadToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            saveFileDialog.Title = "Save Specialty Info";
            saveFileDialog.FileName = $"{specialty.Name}_Info.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine("Назва університету: " + university.Name);
                    writer.WriteLine("Місто: " + university.Location);
                    writer.WriteLine("Назва спеціальності: " + specialty.Name);
                    writer.WriteLine("Мін.прохідний бал: " + specialty.MinimumCompetition);
                    writer.WriteLine("Оплата за рік навчання: " + specialty.TuitionFee);
                    writer.WriteLine("Форма навчання: " + specialty.FormsOfStudy);
                }

                MessageBox.Show("Інформація про спеціальність була збережена.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddToFavorites_Click(object sender, EventArgs e)
        {
            if (!favoriteSpecialties.Any(s => s.Name == specialty.Name && s.MinimumCompetition == specialty.MinimumCompetition))
            {
                favoriteSpecialties.Add(specialty);
                SaveFavoriteSpecialties();
                MessageBox.Show("Specialty added to favorites.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This specialty is already in your favorites.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveFavoriteSpecialties()
        {
            string json = JsonConvert.SerializeObject(favoriteSpecialties, Formatting.Indented);
            File.WriteAllText("favorites.json", json);
        }
    }

}
