using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA3Programming
{
    public interface IPizza
    {
        List<string> GetPizzaType();// it is a function which returns a list of strings. 

        double GetCost();

        void AddToStack(String topping);

        void RemoveFromStack();
        List<double> AddCostToList(double toppingCost);
        void RemoveCost();// list of doubles

        double calcTotal();// calculating the cost from out stack. 

        void AddImageToList(PictureBox image);

        void RemoveImage();

    }

    
}
