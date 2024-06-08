using Course_work.Models;
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
    public partial class FavoriteSpecialtiesForm : Form
    {
        private List<Specialty> favoriteSpecialties;

        public FavoriteSpecialtiesForm(List<Specialty> favoriteSpecialties)
        {
            InitializeComponent();
            this.favoriteSpecialties = favoriteSpecialties ?? new List<Specialty>();
            DisplayFavoriteSpecialties();
            btnDeleteSpecialty.Click += btnDeleteSpecialty_Click;
        }

        private void DisplayFavoriteSpecialties()
        {
            lstFavoriteSpecialties.Items.Clear();
            foreach (var specialty in favoriteSpecialties)
            {
                lstFavoriteSpecialties.Items.Add($"{specialty.Name} - {specialty.MinimumCompetition} - {specialty.TuitionFee} - {specialty.FormsOfStudy}");
            }
        }

        private void btnDeleteSpecialty_Click(object sender, EventArgs e)
        {
            if (lstFavoriteSpecialties.SelectedItem != null)
            {
                string selectedSpecialtyInfo = lstFavoriteSpecialties.SelectedItem.ToString();
                var selectedSpecialty = favoriteSpecialties.FirstOrDefault(s => $"{s.Name} - {s.MinimumCompetition} - {s.TuitionFee} - {s.FormsOfStudy}" == selectedSpecialtyInfo);

                if (selectedSpecialty != null)
                {
                    favoriteSpecialties.Remove(selectedSpecialty);
                    SaveFavoriteSpecialties();
                    DisplayFavoriteSpecialties();
                    MessageBox.Show("Specialty removed from favorites.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a specialty to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveFavoriteSpecialties()
        {
            string json = JsonConvert.SerializeObject(favoriteSpecialties, Formatting.Indented);
            File.WriteAllText("favorites.json", json);
        }
    }

}


