using CA3Programming.Decorators;
using CA3Programming.PizzaTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA3Programming
{
    public partial class Form1 : Form
    {
        
        IPizza pizza;
        public Form1()
        {
            InitializeComponent();

            List<PictureBox> imageStack = new List<PictureBox> { pictureBoxBasePizza };// created a list of picture boxes here in form1to ensure it waw accessible in the pizza class. 
            pizza = new Pizza(imageStack);
            // in order to make the pepporoni transparent.
            
            ToppingImageInitialize(pictureBoxPepperoni);
            ToppingImageInitialize(pictureBoxCheese);
            ToppingImageInitialize(pictureBoxMushrooms);
            ToppingImageInitialize(pictureBoxTomato);
            ToppingImageInitialize(pictureBoxOnions);

        }
        public void ToppingImageInitialize(PictureBox toppingPictureBox)
        {
            toppingPictureBox.BackColor = Color.Transparent;
            toppingPictureBox.Parent = pictureBoxBasePizza;
            toppingPictureBox.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        public void button1Tomato_Click(object sender, EventArgs e)
        {   
            pizza = new TomatoDecorator(pizza, pictureBoxTomato);
            PrintOutDetails();

        }

        private void button3Cheese_Click(object sender, EventArgs e)
        {
            pizza = new CheeseDecorator(pizza, pictureBoxCheese);
            PrintOutDetails();
        }

        private void button2Onions_Click(object sender, EventArgs e)
        {
            pizza = new OnionDecorator(pizza, pictureBoxOnions);
            PrintOutDetails();
        }

        private void button1Pepperoni_Click(object sender, EventArgs e)
        {
            pizza = new PepperoniDecorator(pizza, pictureBoxPepperoni);
            PrintOutDetails();
        }
        private void buttonAddMushroom_Click(object sender, EventArgs e)
        {
            pizza = new MushroomDecorator(pizza, pictureBoxMushrooms);
            PrintOutDetails();

        }
        private void PrintOutDetails()
        {
            string output = string.Join(Environment.NewLine, pizza.GetPizzaType().ToArray());
            label1.Text = output;
            double totalCost = pizza.calcTotal();
            label2EuroCost.Text = totalCost.ToString() + ".00 Euro";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pizza.RemoveFromStack();
            pizza.RemoveCost();
            pizza.RemoveImage();
            PrintOutDetails();
            double totalCost = pizza.calcTotal();
            label2EuroCost.Text = totalCost.ToString() + ".00 Euro";

        }

       
    }
}