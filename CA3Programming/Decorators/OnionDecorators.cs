using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA3Programming.PizzaTypes
{
    public class OnionDecorator : ToppingsDecorator
    {
        
        public OnionDecorator(IPizza pizza, PictureBox pictureBox) : base(pizza)
        {
            base.AddToStack("onion");
            base.AddCostToList(3);
            base.AddImageToList(pictureBox);

        }

        public override List<string> GetPizzaType()
        {
            return base.GetPizzaType();
        }

        public override double GetCost()
        {
            double cost = base.GetCost();
            cost += 3.00;
            return cost;
        }

        public double calcTotal()
        {
            return base.calcTotal();
        }

    }
}

