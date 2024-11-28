using System.Windows.Forms;

namespace PetDetailsForm

{
     public partial class Form1
    {
            
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(334, 18);
            label1.Name = "label1";
            label1.Size = new Size(281, 65);
            label1.TabIndex = 0;
            label1.Text = "Pet's Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 255);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Medical History";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(566, 131);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Weight";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(533, 255);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 3;
            label4.Text = "Favourite Toy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 206);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 4;
            label5.Text = "Breed";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(572, 209);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 5;
            label6.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(117, 131);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 6;
            label7.Text = "Type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(572, 172);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 7;
            label8.Text = "Color";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(102, 169);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 8;
            label9.Text = "BirthDay";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(166, 166);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(222, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 255);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(617, 252);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(617, 206);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(617, 171);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(177, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(617, 128);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(177, 23);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(166, 204);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(222, 23);
            textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(166, 128);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(222, 23);
            textBox7.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Location = new Point(672, 322);
            button1.Name = "button1";
            button1.Size = new Size(122, 50);
            button1.TabIndex = 17;
            button1.Text = "Adopt";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(50, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 84);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(990, 500);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
    }
    public class PetDetailsForm : Form
    {
        private IAnimal selectedPet;
        private Label labelName;
        private Label labelBreed;
        private Label labelColor;
        private Label labelMedicalHistory;
        private Label labelWeight;
        private Label labelBirthday;
        private Label labelStatus;
        private Button buttonAdopt;

        public PetDetailsForm(IAnimal pet)
        {
            selectedPet = pet;
            InitializeForm();
        }

        private void InitializeForm()
        {
            labelName.Text = selectedPet.Name;
            labelBreed.Text = selectedPet.Breed;
            labelColor.Text = selectedPet.Color;
            labelMedicalHistory.Text = selectedPet.MedicalHistory;
            labelWeight.Text = selectedPet.Weight.ToString();
            labelBirthday.Text = selectedPet.Birthday.ToShortDateString();

            if (selectedPet is Cat cat)
            {
                // Display favorite toy for cats
                labelStatus.Text = $"Favorite Toy: {cat.FavToy}";
            }

            if (selectedPet.Status != "Adopted")
            {
                buttonAdopt.Visible = true;
            }
            else
            {
                labelStatus.Text = "Adopted";
                buttonAdopt.Visible = false;
            }
        }

        private void ButtonAdoptClick(object sender, EventArgs e)
        {
            selectedPet.Status = "Adopted";
            labelStatus.Text = "Adopted";
            buttonAdopt.Visible = false;
        }
    }

}

