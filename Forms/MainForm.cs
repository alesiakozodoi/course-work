using Course_work.Models;
using Course_work.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Course_work.Forms
{
    public partial class MainForm : Form
    {
        private UniversityService universityService;
        private List<Specialty> favoriteSpecialties;

        public MainForm()
        {
            InitializeComponent();
            universityService = new UniversityService();
            favoriteSpecialties = LoadFavoriteSpecialties();
            LoadUniversities();
            btnFavoriteSpecialties.Click += btnFavoriteSpecialties_Click;
            btnShowInfo.Click += btnShowInfo_Click;
            btnOpenEditor.Click += btnOpenEditor_Click;
            btnSearch.Click += btnSearch_Click;
        }

        private void LoadUniversities()
        {
            var universities = universityService.GetUniversities();
            lstResults.Items.Clear();
            foreach (var university in universities)
            {
                foreach (var specialty in university.Specialties)
                {
                    lstResults.Items.Add($"{university.Location} - {university.Name} - {specialty.Name}");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string universityName = txtUniversityName.Text;
            string specialtyName = txtSpecialityName.Text;
            string location = txtLocation.Text;
            double? tuitionFeeFrom = null;
            double? tuitionFeeTo = null;
            string formOfStudy = txtFormsOfStudy.Text;

            if (double.TryParse(txtTuitionFeeFrom.Text, out double feeFrom))
            {
                tuitionFeeFrom = feeFrom;
            }

            if (double.TryParse(txtTuitionFeeTo.Text, out double feeTo))
            {
                tuitionFeeTo = feeTo;
            }

            var results = universityService.SearchUniversities(universityName, specialtyName, location, tuitionFeeFrom, tuitionFeeTo, formOfStudy);

            lstResults.Items.Clear();
            foreach (var result in results)
            {
                if (result.Type == "University")
                {
                    var university = (University)result.Item;
                    lstResults.Items.Add($"{university.Name} ({university.Location})");
                }
                else if (result.Type == "Specialty")
                {
                    var tuple = (Tuple<University, Specialty>)result.Item;
                    var university = tuple.Item1;
                    var specialty = tuple.Item2;
                    lstResults.Items.Add($"{university.Name} ({university.Location}) - {specialty.Name}");
                }
            }
        }

        private void btnOpenEditor_Click(object sender, EventArgs e)
        {
            EditUniversityForm editForm = new EditUniversityForm(universityService);
            editForm.ShowDialog();
            LoadUniversities(); // Refresh the list after editing
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            if (lstResults.SelectedItem == null)
            {
                MessageBox.Show("Please select an item from the list.");
                return;
            }

            string selectedItem = lstResults.SelectedItem.ToString();
            var universities = universityService.GetUniversities();

            // Check if selectedItem matches a university format
            var selectedUniversity = universities.FirstOrDefault(u => selectedItem.Equals($"{u.Name} ({u.Location})", StringComparison.OrdinalIgnoreCase));
            if (selectedUniversity != null)
            {
                // Show university info
                UniversityDetailsForm detailsForm = new UniversityDetailsForm(selectedUniversity, favoriteSpecialties);
                detailsForm.ShowDialog();
            }
            else
            {
                // Check if selectedItem matches a specialty format
                Specialty selectedSpecialty = null;
                University containingUniversity = null;
                foreach (var university in universities)
                {
                    selectedSpecialty = university.Specialties.FirstOrDefault(s => selectedItem.Equals($"{university.Name} ({university.Location}) - {s.Name}", StringComparison.OrdinalIgnoreCase));
                    if (selectedSpecialty != null)
                    {
                        containingUniversity = university;
                        break;
                    }
                }

                if (selectedSpecialty != null && containingUniversity != null)
                {
                    SpecialtyDetailsForm detailsForm = new SpecialtyDetailsForm(containingUniversity, selectedSpecialty, favoriteSpecialties);
                    detailsForm.ShowDialog();
                    SaveFavoriteSpecialties();
                }
            }
        }

        private void btnFavoriteSpecialties_Click(object sender, EventArgs e)
        {
            FavoriteSpecialtiesForm favoriteForm = new FavoriteSpecialtiesForm(favoriteSpecialties);
            favoriteForm.ShowDialog();
        }

        private List<Specialty> LoadFavoriteSpecialties()
        {
            string filename = "favorites.json";
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    return JsonConvert.DeserializeObject<List<Specialty>>(json) ?? new List<Specialty>();
                }
            }
            return new List<Specialty>();
        }

        private void SaveFavoriteSpecialties()
        {
            string json = JsonConvert.SerializeObject(favoriteSpecialties, Formatting.Indented);
            File.WriteAllText("favorites.json", json);
        }

        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
