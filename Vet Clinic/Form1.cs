namespace Vet_Clinic
{
    public partial class Form1 : Form
    {
        public partial class IndexForm : Form
        {
            private readonly List<IAnimal> pets = new()
    {
        new Cat("Fluffy", new DateTime(2018, 5, 15), "Persian", "Regular checkups", 4.5, "Golden", "Feather wand"),
        new Dog("Buddy", new DateTime(2016, 8, 20), "Golden Retriever", "Vaccinated", 25.5, "Golden")
         };
            private void OnLoad(object sender, EventArgs e)
            {
                //LoadALlPetsO;
            }


        }

    }
}
