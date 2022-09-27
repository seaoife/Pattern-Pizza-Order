using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA3Programming
{
    public class ToppingsDecorator : IPizza// abstract will not be initialised. it is just for inheriting.
    {
        //base Decorator
        private IPizza _pizza;
        public ToppingsDecorator(IPizza pizza)// constructor function, it will be called first when initialising the class. 
        {
            // initialising class means creating an instance of any class.
            _pizza = pizza;

        }
        public virtual List<string> GetPizzaType()// a normal function cannot be overriden but a virual, abstract function can. 
        {
            return _pizza.GetPizzaType();
        }
        public virtual double GetCost()
        {
            return _pizza.GetCost();
        }

        public virtual void AddToStack(String topping)
        {
           _pizza.AddToStack(topping);
        }

        public virtual void RemoveFromStack()
        {
            _pizza.RemoveFromStack();
        }
        public virtual List<double> AddCostToList(double toppingCost)
        {
            return _pizza.AddCostToList(toppingCost);
        }
        public virtual void RemoveCost()
        {
            _pizza.RemoveCost();
        }

        public double calcTotal()
        {
            return _pizza.calcTotal();
        }

        public void AddImageToList(PictureBox image)
        {
            _pizza.AddImageToList(image);
        }

        public void RemoveImage()
        {
            _pizza.RemoveImage();
        }
    }
}
