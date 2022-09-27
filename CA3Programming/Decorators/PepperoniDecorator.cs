using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA3Programming.Decorators
{
    public class PepperoniDecorator:ToppingsDecorator
    {
        public PepperoniDecorator(IPizza pizza, PictureBox pictureBox) : base(pizza)
        {
            base.AddToStack("pepperoni");
            base.AddCostToList(2);
            base.AddImageToList(pictureBox);

        }

        public override List<string> GetPizzaType()
        {
            //List<string> stack= base.GetPizzaType();
            //stack.Add("cheese"); BP, BP,C,P
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
        //public override List<double> RemoveCost()
        //{
        //    return 

        //}
    }
}
