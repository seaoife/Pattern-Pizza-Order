using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA3Programming.PizzaTypes
{
    public class TomatoDecorator :  ToppingsDecorator
    {
        
        public TomatoDecorator(IPizza pizza, PictureBox pictureBox) : base(pizza)
        {
            //List<string> stack= base.GetPizzaType();
            //stack.Add("cheese"); BP, BP, BP,C,P,T
            //return stack;
            base.AddToStack("tomato sauce");
            base.AddCostToList(1);
            base.AddImageToList(pictureBox);
            //base.AddImageToList(1);
        }

        public override List<string> GetPizzaType()
        {
            return base.GetPizzaType();
        }

        public override double GetCost()
        {
            double cost = base.GetCost();
            cost += 1.00;
            return cost;
        }
        public double calcTotal()
        {
            return base.calcTotal();
        }

    }
}

