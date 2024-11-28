using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vet_Clinic
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Breed { get; set; }
        public double Weight { get; set; }
        public string MedicalHistory { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        public Status Status { get; set; }
    }
    public enum Status
    {
        NotAdopted,
        Adopted,
    }
    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Breed { get; set; }
        public string MedicalHistory { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string FavoriteToy { get; set; }
        public string Image { get; set; }
        public Status Status { get; set; }

        public Cat(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color, string favoriteToy)
        {
            Name = name;
            Birthday = birthday;
            Breed = breed;
            MedicalHistory = medicalHistory;
            Weight = weight;
            Color = color;
            FavoriteToy = favoriteToy;
            Status = Status.NotAdopted;

        }
    }
    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Breed { get; set; }
        public string MedicalHistory { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        public Status Status { get; set; }

        public Dog(string name, DateTime birthday, string breed,
                   string medicalHistory, double weight, string color)
        {
            Name = name;
            Birthday = birthday;
            Breed = breed;
            MedicalHistory = medicalHistory;
            Weight = weight;
            Color = color;
            Status = Status.NotAdopted;
        }

    }
}

