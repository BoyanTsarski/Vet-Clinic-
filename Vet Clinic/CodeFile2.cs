
using System;

public class Dog : IAnimal
{
    public string Name { get; set; }
    public string Breed { get; set; }
    public string Color { get; set; }
    public string MedicalHistory { get; set; }
    public double Weight { get; set; }
    public DateTime Birthday { get; set; }
    public string Status { get; set; } = "Available";

    public Dog(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color)
    {
        Name = name;
        Birthday = birthday;
        Breed = breed;
        MedicalHistory = medicalHistory;
        Weight = weight;
        Color = color;
    }
}
