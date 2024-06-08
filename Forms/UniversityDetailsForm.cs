using Course_work.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_work.Forms
{
    public partial class UniversityDetailsForm : Form
    {
        private University university;
        private List<Specialty> favoriteSpecialties;

        public UniversityDetailsForm(University university, List<Specialty> favoriteSpecialties)
        {
            InitializeComponent();
            this.university = university;
            this.favoriteSpecialties = favoriteSpecialties;
            DisplayUniversityDetails();
        }

        private void DisplayUniversityDetails()
        {
            lblName.Text = university.Name;
            lblLocation.Text = university.Location;
            lblRating.Text = university.Rating.ToString();
            lstSpecialties.Items.Clear();
            foreach (var specialty in university.Specialties)
            {
                lstSpecialties.Items.Add(specialty.Name);
            }
        }

        private void btnSpecialtyDetails_Click(object sender, EventArgs e)
        {
            if (lstSpecialties.SelectedItem == null)
            {
                MessageBox.Show("Please select a specialty from the list.");
                return;
            }

            string selectedSpecialtyName = lstSpecialties.SelectedItem.ToString();
            var selectedSpecialty = university.Specialties.FirstOrDefault(s => s.Name == selectedSpecialtyName);

            if (selectedSpecialty != null)
            {
                SpecialtyDetailsForm detailsForm = new SpecialtyDetailsForm(university, selectedSpecialty, favoriteSpecialties);
                detailsForm.ShowDialog();
            }
        }
    }

}
