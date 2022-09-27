using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA3Programming.Decorators
{
    public class MushroomDecorator : ToppingsDecorator
    {
        public MushroomDecorator(IPizza pizza, PictureBox pictureBox) : base(pizza)
        {
            base.AddToStack("mushroom");
            base.AddCostToList(1);
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
            cost += 1.00;
            return cost;
        }

        public double calcTotal()
        {
            return base.calcTotal();
        }
    }

}
