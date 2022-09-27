using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA3Programming.PizzaTypes
{
    public class CheeseDecorator : ToppingsDecorator
    {
        public CheeseDecorator(IPizza pizza, PictureBox pictureBox) : base(pizza) 
        {
            base.AddToStack("cheese");
            base.AddCostToList(2);
            base.AddImageToList(pictureBox);

        }

        public override List<string> GetPizzaType()
        {
            //List<string> stack= base.GetPizzaType();
            //stack.Add("cheese"); BP,C
            //return stack;
            return base.GetPizzaType();
        }

        public override double GetCost()
        {
            double cost = base.GetCost();
             cost += 2.00;
            return cost;
        }

        public double calcTotal()
        {
            return base.calcTotal();
        }

    }
}
