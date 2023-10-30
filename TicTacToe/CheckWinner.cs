using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public class CheckWinner
    {
        public static bool CheckWin(string type, Button a1, Button b1, Button c1, Button d1, Button e1, Button f1, Button g1, Button h1, Button i1)
        {
            string a = a1.Text;
            string b = b1.Text;
            string c = c1.Text;
            string d = d1.Text;
            string e = e1.Text;
            string f = f1.Text;
            string g = g1.Text;
            string h = h1.Text;
            string i = i1.Text;



            // Horizontal Win
            if (a == type && b == type && c == type)
            {
                return true;
            }
            else if (d == type && e == type && f == type)
            {
                return true;
            }
            else if (g == type && h == type && i == type)
            {
                return true;
            }

            // Diagonal Win
            else if (a == type && e == type && i == type)
            {
                return true;
            }
            else if (c == type && e == type && g == type)
            {
                return true;
            }

            // Vertical Win
            else if (a == type && d == type && g == type)
            {
                return true;
            }
            else if (b == type && e == type && h == type)
            {
                return true;
            }
            else if (c == type && f == type && i == type)
            {
                return true;
            }




            return false;
        }
    }
}
