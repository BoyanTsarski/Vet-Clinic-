using Vet_Clinic;

public partial class Form1 : Form
{
    private List<IAnimal> pets = new List<IAnimal>();
    private System.ComponentModel.IContainer components = null;
    public partial class IndexForm : Form
    {
        private readonly List<IAnimal> pets = new()
    {
        new Cat("Fluffy", new DateTime(2018, 5, 15), "Persian", "Regular checkups", 4.5, "Golden", "Feather wand"),
        new Dog("Buddy", new DateTime(2016, 8, 20), "Golden Retriever", "Vaccinated", 25.5, "Golden")
    };
    }

    public Form1()
    {
        InitializeComponent();
    }
    private void OnLoad(object sender, EventArgs e)
    {
        Load += OnLoad;
        ResumeLayout(false);
        PerformLayout();

    }
    private void LoadAllPets(List<IAnimal> pets)
    {
        this.listViewPets.Clear();
        foreach (var pet in pets)
        {
            this.listViewPets.Items.Add(pet.Name, pet.GetType() == typeof(Cat) ? 0 : 1);
        }
    }
    private void ListViewPetsMouseClick(object sender, MouseEventArgs e)
    {
        if (this.listViewPets.SelectedItems.Count > 0)
        {
            IAnimal selectedPet = pets[this.listViewPets.SelectedItems[0].Index];

            if (selectedPet != null)
            {
                using (PetDetailsForm detailsForm = new PetDetailsForm(selectedPet))
                {
                    detailsForm.ShowDialog();
                }
            }
        }
    }
    private void ButtonAddNewPetClick(object sender, EventArgs e)
    {
        using (NewPetForm newPetForm = new NewPetForm())
        {
            if (newPetForm.ShowDialog() == DialogResult.OK)
            {
                pets.Add(newPetForm.Pet);

                LoadAllPets(pets);
            }
        }
    }




    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {

    }

    #endregion

    private Label label1;
    private ListView listView1;
    private ImageList imageList1;
}
