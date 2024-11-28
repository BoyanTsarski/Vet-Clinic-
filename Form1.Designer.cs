using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewPetForm
{
    public partial class Form1 : Form
    {
        private string petImage;
        private IAnimal pet;

        public IAnimal Pet
        {
            get { return pet; }
            set { pet = value; }
        }

        public Form1()
        {
            InitializeComponent();

            radioButton1.CheckedChanged += RadioButtonDogCheckedChanged;
            radioButton2.CheckedChanged += RadioButtonCatCheckedChanged;

            button1.Click += ButtonAddNewPetClick;
        }

        private void RadioButtonDogCheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
            textBox8.Visible = false;
        }

        private void RadioButtonCatCheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            textBox8.Visible = true;
        }

        private void ButtonAddNewPetClick(object sender, EventArgs e)
        {
            if (!CheckIfInputsAreValid())
            {
                return;
            }

            var newPet = CreateNewAnimal();
            if (newPet != null)
            {
                Pet = newPet;
                DialogResult = DialogResult.OK;
            }
        }


        private bool CheckIfInputsAreValid()
        {
            bool isValid = true;

            isValid &= CheckIfValid(textBox3, 3, label14);  
            isValid &= CheckIfValid(textBox6, 5, label15); 
            isValid &= CheckIfValid(textBox7, 3, label16);  
            isValid &= CheckIfValid(textBox8, 10, label16); 
            isValid &= CheckIfValidDouble(textBox4, label16, 0.5); 
            isValid &= CheckIfNotEmpty(petImage, label16); 

            return isValid;
        }

        private bool CheckIfValid(TextBox textBox, int minLength, Label errorLabel)
        {
            bool isValid = textBox.Text.Length >= minLength;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private void ShowValidationError(Label label, bool isValid)
        {
            label.Visible = !isValid;
        }

        private bool CheckIfValidDouble(TextBox textBox, Label errorLabel, double min)
        {
            bool isValid = double.TryParse(textBox.Text, out double value) && value >= min;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private bool CheckIfNotEmpty(string value, Label errorLabel)
        {
            bool isValid = !string.IsNullOrWhiteSpace(value);
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

    
        private IAnimal CreateNewAnimal()
        {
            string name = textBox3.Text;
            DateTime birthday = dateTimePicker1.Value;
            string breed = textBox6.Text;
            string medicalHistory = textBox7.Text;
            double weight = double.Parse(textBox4.Text);
            string color = textBox7.Text;

            if (radioButton2.Checked) 
            {
                string favoriteToy = textBox8.Text;
                return CreateCat(name, birthday, breed, medicalHistory, weight, color, favoriteToy);
            }
            else if (radioButton1.Checked) 
            {
                return CreateDog(name, birthday, breed, medicalHistory, weight, color);
            }
            return null;
        }

       
        private IAnimal CreateCat(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color, string favoriteToy)
        {
            if (favoriteToy.Length < 3)
            {
                ShowValidationError(label16, false);  
                return null;
            }

            return new Cat(name, birthday, breed, medicalHistory, weight, color, favoriteToy);
        }

        private IAnimal CreateDog(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color)
        {
            return new Dog(name, birthday, breed, medicalHistory, weight, color);
        }

        private void TextBoxPhotoMouseDown(object sender, MouseEventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    petImage = dialog.FileName;
                    textBox1.Text = System.IO.Path.GetFileName(petImage);
                }
            }
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }

    public interface IAnimal
    {
        string Name { get; }
        DateTime Birthday { get; }
        string Breed { get; }
        string MedicalHistory { get; }
        double Weight { get; }
        string Color { get; }
    }

    public class Dog : IAnimal
    {
        public string Name { get; }
        public DateTime Birthday { get; }
        public string Breed { get; }
        public string MedicalHistory { get; }
        public double Weight { get; }
        public string Color { get; }

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

    public class Cat : IAnimal
    {
        public string Name { get; }
        public DateTime Birthday { get; }
        public string Breed { get; }
        public string MedicalHistory { get; }
        public double Weight { get; }
        public string Color { get; }
        public string FavoriteToy { get; }

        public Cat(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color, string favoriteToy)
        {
            Name = name;
            Birthday = birthday;
            Breed = breed;
            MedicalHistory = medicalHistory;
            Weight = weight;
            Color = color;
            FavoriteToy = favoriteToy;
        }
    }
    public class NewPetForm : Form
    {
        // Fields for pet image and Animal property
        private string petImage;
        public IAnimal Animal { get; set; }

        // UI Controls
        private TextBox1 textBoxName;
        private TextBox2 textBoxBreed;
        private TextBox3 textBoxColor;
        private TextBox4 textBoxMedicalHistory;
        private TextBox5 textBoxWeight;
        private TextBox6 textBoxFavToy;
        private TextBox7 textBoxImage;
        private RadioButton8 radioButtonDog;
        private RadioButton9 radioButtonCat;
        private Label labelNameError;
        private Label labelBreedError;
        private Label labelColorError;
        private Label labelMedicalHistoryError;
        private Label labelWeightError;
        private Label labelImageError;
        private Label labelFavToy;
        private Label labelInfoFavToy;

        public NewPetForm()
        {
            
        }

        private void RadioButtonDogCheckedChanged(object sender, EventArgs e)
        {
            labelFavToy.Visible = false;
            textBoxFavToy.Visible = false;
            labelInfoFavToy.Visible = false;
        }

        private void RadioButtonCatCheckedChanged(object sender, EventArgs e)
        {
            labelFavToy.Visible = true;
            textBoxFavToy.Visible = true;
            labelInfoFavToy.Visible = true;
        }

        private void ButtonAddNewPetClick(object sender, EventArgs e)
        {
            if (!CheckIfInputsAreValid())
            {
                return; 
            }

            IAnimal newAnimal = CreateNewAnimal();
            if (newAnimal != null)
            {
                Animal = newAnimal;
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool CheckIfInputsAreValid()
        {
            bool isNameValid = CheckIfValid(textBoxName, 3, labelNameError);
            bool isBreedValid = CheckIfValid(textBoxBreed, 5, labelBreedError);
            bool isColorValid = CheckIfValid(textBoxColor, 5, labelColorError);
            bool isMedicalHistoryValid = CheckIfValid(textBoxMedicalHistory, 10, labelMedicalHistoryError);
            bool isWeightValid = CheckIfValidDouble(textBoxWeight, labelWeightError, 0.5);
            bool isImageValid = CheckIfNotEmpty(petImage, labelImageError);

            return isNameValid && isBreedValid && isColorValid && isMedicalHistoryValid && isWeightValid && isImageValid;
        }

        private static bool CheckIfValid(TextBox textBox, int minLength, Label errorLabel)
        {
            bool isValid = textBox.Text.Length >= minLength;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private static void ShowValidationError(Label label, bool isValid)
        {
            label.Visible = !isValid; // Show error if invalid
        }

        private bool CheckIfValidDouble(TextBox textBox, Label errorLabel, double min)
        {
            bool isValid = double.TryParse(textBox.Text, out double value) && value >= min;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private bool CheckIfNotEmpty(string value, Label errorLabel)
        {
            bool isValid = !string.IsNullOrWhiteSpace(value);
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private IAnimal CreateNewAnimal()
        {
            string name = textBoxName.Text;
            string breed = textBoxBreed.Text;
            string color = textBoxColor.Text;
            string medicalHistory = textBoxMedicalHistory.Text;
            double weight = double.Parse(textBoxWeight.Text);
            DateTime birthday = DateTime.Now; // For simplicity, assume current date is the birthday

            if (radioButtonCat.Checked)
            {
                return CreateCat(name, birthday, breed, medicalHistory, weight, color);
            }
            else if (radioButtonDog.Checked)
            {
                return CreateDog(name, birthday, breed, medicalHistory, weight, color);
            }

            return null;
        }

        private IAnimal CreateCat(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color)
        {
            string favToy = textBoxFavToy.Text;
            if (favToy.Length >= 3)
            {
                return new Cat(name, birthday, breed, medicalHistory, weight, color, favToy);
            }
            return null;
        }

        private IAnimal CreateDog(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color)
        {
            return new Dog(name, birthday, breed, medicalHistory, weight, color);
        }

        private void TextBoxPhotoMouseDown(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                petImage = openFileDialog.FileName;
                textBoxImage.Text = openFileDialog.SafeFileName;
            }
        }
    }

}
