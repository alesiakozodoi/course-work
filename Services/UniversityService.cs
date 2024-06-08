using Course_work.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using Newtonsoft.Json;

namespace Course_work.Services
{
    public class UniversityService
    {
        private List<University> universities;

        public UniversityService()
        {
            // Initialize universities list or load from file
            LoadFromFile("universities.json");
        }

        public List<University> GetUniversities()
        {
            return universities;
        }

        public void SaveToFile(string filename)
        {
            string json = JsonConvert.SerializeObject(universities, Formatting.Indented);
            File.WriteAllText(filename, json);
        }

        public void LoadFromFile(string filename)
        {
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                universities = JsonConvert.DeserializeObject<List<University>>(json);
            }
            else
            {
                universities = new List<University>(); // Create a new list if file doesn't exist
            }
        }

        public void AddUniversity(University university)
        {
            universities.Add(university);
            SaveToFile("universities.json");
        }

        public void UpdateUniversity(University university)
        {
            // Find and replace the university
            int index = universities.FindIndex(u => u.Name == university.Name && u.Location == university.Location);
            if (index != -1)
            {
                universities[index] = university;
                SaveToFile("universities.json");
            }
        }

        public void DeleteUniversity(string name, string location)
        {
            universities.RemoveAll(u => u.Name == name && u.Location == location);
            SaveToFile("universities.json");
        }

        public List<(string Type, object Item)> SearchUniversities(string universityName, string specialtyName, string location, double? tuitionFeeFrom, double? tuitionFeeTo, string formOfStudy)
        {
            var filteredUniversities = universities
                .Where(u =>
                    (string.IsNullOrEmpty(universityName) || u.Name.IndexOf(universityName, StringComparison.OrdinalIgnoreCase) >= 0) &&
                    (string.IsNullOrEmpty(location) || u.Location.IndexOf(location, StringComparison.OrdinalIgnoreCase) >= 0))
                .ToList();

            var result = new List<(string Type, object Item)>();

            if (string.IsNullOrEmpty(specialtyName) && string.IsNullOrEmpty(formOfStudy) && !tuitionFeeFrom.HasValue && !tuitionFeeTo.HasValue)
            {
                // If only university name or location is provided, return list of universities
                result.AddRange(filteredUniversities.Select(u => ("University", (object)u)));
                return result;
            }

            var filteredSpecialties = filteredUniversities
                .SelectMany(u => u.Specialties, (u, s) => new { University = u, Specialty = s })
                .Where(us =>
                    (string.IsNullOrEmpty(specialtyName) || us.Specialty.Name.IndexOf(specialtyName, StringComparison.OrdinalIgnoreCase) >= 0) &&
                    (!tuitionFeeFrom.HasValue || us.Specialty.TuitionFee >= tuitionFeeFrom) &&
                    (!tuitionFeeTo.HasValue || us.Specialty.TuitionFee <= tuitionFeeTo) &&
                    (string.IsNullOrEmpty(formOfStudy) || us.Specialty.FormsOfStudy.Equals(formOfStudy, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            result.AddRange(filteredSpecialties.Select(us => ("Specialty", (object)new Tuple<University, Specialty>(us.University, us.Specialty))));
            return result;
        }


    }
}
