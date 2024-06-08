using Course_work.Models;
using Course_work.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;


namespace Course_work.Forms
{
    public partial class EditUniversityForm : Form
    {
        private UniversityService universityService;
        private University editingUniversity;
        private Specialty editingSpecialty;

        public EditUniversityForm(UniversityService service)
        {
            InitializeComponent();
            universityService = service;
        }

        private void EditUniversityForm_Load(object sender, EventArgs e)
        {
            RefreshUniversityList();
        }

        private void RefreshUniversityList()
        {
            lstUniversities.Items.Clear();
            foreach (var university in universityService.GetUniversities())
            {
                lstUniversities.Items.Add($"{university.Location} - {university.Name}");
            }
        }

        private void btnAddUniversity_Click(object sender, EventArgs e)
        {
            ClearUniversityTextBoxes();
            editingUniversity = null;
        }

        private void btnEditUniversity_Click(object sender, EventArgs e)
        {
            if (lstUniversities.SelectedIndex != -1)
            {
                editingUniversity = universityService.GetUniversities()[lstUniversities.SelectedIndex];
                txtName.Text = editingUniversity.Name;
                txtLocation.Text = editingUniversity.Location;
                txtRating.Text = editingUniversity.Rating.ToString();
                RefreshSpecialtyList(editingUniversity);
            }
        }

        private void btnDeleteUniversity_Click(object sender, EventArgs e)
        {
            if (lstUniversities.SelectedIndex != -1)
            {
                editingUniversity = universityService.GetUniversities()[lstUniversities.SelectedIndex];
                universityService.DeleteUniversity(editingUniversity.Name, editingUniversity.Location);
                RefreshUniversityList();
                ClearUniversityTextBoxes();
                ClearSpecialtyTextBoxes();
            }
        }

        private void btnSaveUniversity_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtLocation.Text) || string.IsNullOrEmpty(txtRating.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            if (double.TryParse(txtRating.Text, out double rating))
            {
                if (editingUniversity == null)
                {
                    var newUniversity = new University
                    {
                        Name = txtName.Text,
                        Location = txtLocation.Text,
                        Rating = rating,
                        Specialties = new List<Specialty>(),
                    };
                    universityService.AddUniversity(newUniversity);
                }
                else
                {
                    editingUniversity.Name = txtName.Text;
                    editingUniversity.Location = txtLocation.Text;
                    editingUniversity.Rating = rating;
                    universityService.UpdateUniversity(editingUniversity);
                }

                RefreshUniversityList();
                ClearUniversityTextBoxes();
            }
            else
            {
                MessageBox.Show("Введіть коректний рейтинг університету.");
            }
        }

        private void btnAddSpecialty_Click(object sender, EventArgs e)
        {
            ClearSpecialtyTextBoxes();
            editingSpecialty = null;
        }

        private void btnEditSpecialty_Click(object sender, EventArgs e)
        {
            if (lstSpecialties.SelectedIndex != -1 && editingUniversity != null)
            {
                editingSpecialty = editingUniversity.Specialties[lstSpecialties.SelectedIndex];
                txtSpecialtyName.Text = editingSpecialty.Name;
                txtMinimumCompetition.Text = editingSpecialty.MinimumCompetition.ToString();
                txtTuitionFee.Text = editingSpecialty.TuitionFee.ToString();
                txtFormsOfStudy.Text = editingSpecialty.FormsOfStudy;
            }
        }

        private void btnDeleteSpecialty_Click(object sender, EventArgs e)
        {
            if (lstSpecialties.SelectedIndex != -1 && editingUniversity != null)
            {
                editingUniversity.Specialties.RemoveAt(lstSpecialties.SelectedIndex);
                universityService.UpdateUniversity(editingUniversity);
                RefreshSpecialtyList(editingUniversity);
                ClearSpecialtyTextBoxes();
            }
        }

        private void btnSaveSpecialty_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSpecialtyName.Text) || string.IsNullOrEmpty(txtMinimumCompetition.Text) || string.IsNullOrEmpty(txtTuitionFee.Text) || string.IsNullOrEmpty(txtFormsOfStudy.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля спеціальності.");
                return;
            }

            if (editingUniversity == null)
            {
                MessageBox.Show("Виберіть університет для додавання спеціальності.");
                return;
            }

            if (double.TryParse(txtMinimumCompetition.Text, out double minimumCompetition) && double.TryParse(txtTuitionFee.Text, out double tuitionFee))
            {
                if (editingSpecialty == null)
                {
                    var newSpecialty = new Specialty
                    {
                        Name = txtSpecialtyName.Text,
                        MinimumCompetition = minimumCompetition,
                        TuitionFee = tuitionFee,
                        FormsOfStudy = txtFormsOfStudy.Text,
                    };
                    editingUniversity.Specialties.Add(newSpecialty);
                }
                else
                {
                    editingSpecialty.Name = txtSpecialtyName.Text;
                    editingSpecialty.MinimumCompetition = minimumCompetition;
                    editingSpecialty.TuitionFee = tuitionFee;
                    editingSpecialty.FormsOfStudy = txtFormsOfStudy.Text;
                }

                universityService.UpdateUniversity(editingUniversity);
                RefreshSpecialtyList(editingUniversity);
                ClearSpecialtyTextBoxes();
            }
            else
            {
                MessageBox.Show("Введіть коректні значення для конкурсу та оплати.");
            }
        }

        private void RefreshSpecialtyList(University university)
        {
            lstSpecialties.Items.Clear();
            foreach (var specialty in university.Specialties)
            {
                lstSpecialties.Items.Add($"{specialty.Name} - {specialty.MinimumCompetition} - {specialty.TuitionFee} - {specialty.FormsOfStudy}");
            }
        }

        private void ClearUniversityTextBoxes()
        {
            txtName.Text = "";
            txtLocation.Text = "";
            txtRating.Text = "";
        }

        private void ClearSpecialtyTextBoxes()
        {
            txtSpecialtyName.Text = "";
            txtMinimumCompetition.Text = "";
            txtTuitionFee.Text = "";
            txtFormsOfStudy.Text = "";
        }


    }
}
