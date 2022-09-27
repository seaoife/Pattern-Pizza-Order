using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA3Programming
{
    public class Pizza :IPizza
    {
        //PIzza class is the concrete Component which is the dough.
        double totalCost = 5;
        public List<string> stack = new List<string> { "base pizza"};// creating List so we remove a layer of the toppings when a remove button is pressed.
        public List<double> priceStack = new List<double> { 5 };
        public List<PictureBox> imageStack;

        public Pizza(List<PictureBox> imageList)//constructor starts with the same name as the class name. 
        {
            this.imageStack = imageList;
        }

        public List<string> GetPizzaType()
        {

            return stack;
        }

        public double GetCost()
        {
            return totalCost;
        }

        public void AddToStack(String topping)
        {
            stack.Add(topping);
        }

        public void RemoveFromStack()
        {
            if(stack.Count > 1)
            {
                stack.RemoveAt(stack.Count - 1);

            }
        }
       public List <double> AddCostToList(double toppingCost)
        {
          priceStack.Add(toppingCost);
            return priceStack; 
        }
        public void RemoveCost()
        {
            priceStack.RemoveAt(stack.Count - 1);   
            
        }

        public double calcTotal()
        {
            return priceStack.Sum();
        }

        public void AddImageToList(PictureBox image)
        {
            imageStack.Add(image);
            image.Visible = true;
        }

        public void RemoveImage()
        {
            if (imageStack.Count > 1)
            {
                PictureBox imageToRemove = imageStack.Last();// created variable to get the last item from the list. 
                imageToRemove.Visible = false; // make the image in form not visible.
                imageStack.Remove(imageToRemove);// then remove from the list.
            }
        }
    }
}
