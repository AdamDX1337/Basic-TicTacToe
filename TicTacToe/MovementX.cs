using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    internal class MovementX
    {
        static Random ranNum = new Random();
        public static int MakeEducatedMoveX(Button a1, Button b1, Button c1, Button d1, Button e1, Button f1, Button g1, Button h1, Button i1)
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


            //Diagonals
            //Doing Diagonals first makes it harder for some reason
            if (a == "" && e == "O" && i == "O")
            {

                a1.Text = "X";
                return 2;
            }
            else if (a == "O" && e == "" && i == "O")
            {

                e1.Text = "X";
                return 2;
            }
            else if (a == "O" && e == "O" && i == "")
            {

                i1.Text = "X";
                return 2;
            }


            else if (c == "" && e == "O" && g == "O")
            {

                c1.Text = "X";
                return 2;
            }
            else if (c == "O" && e == "" && g == "O")
            {

                e1.Text = "X";
                return 2;
            }
            else if (c == "O" && e == "O" && g == "")
            {

                g1.Text = "X";
                return 2;
            }

            //horizontal
            else if (a == "" && b == "O" && c == "O")
            {

                a1.Text = "X";
                return 2;
            }
            else if (a == "O" && b == "" && c == "O")
            {

                b1.Text = "X";
                return 2;
            }
            else if (a == "O" && b == "O" && c == "")
            {

                c1.Text = "X";
                return 2;
            }


            else if (d == "" && e == "O" && f == "O")
            {

                d1.Text = "X";
                return 2;
            }
            else if (d == "O" && e == "" && f == "O")
            {

                e1.Text = "X";
                return 2;
            }
            else if (d == "O" && e == "O" && f == "")
            {

                f1.Text = "X";
                return 2;
            }


            else if (g == "" && h == "O" && i == "O")
            {

                g1.Text = "X";
                return 2;
            }
            else if (g == "O" && h == "" && i == "O")
            {

                h1.Text = "X";
                return 2;
            }
            else if (g == "O" && h == "O" && i == "")
            {

                i1.Text = "X";
                return 2;
            }

            //Vertical
            else if (a == "" && d == "O" && g == "O")
            {

                a1.Text = "X";
                return 2;
            }
            else if (a == "O" && d == "" && g == "O")
            {

                d1.Text = "X";
                return 2;
            }
            else if (a == "O" && d == "O" && g == "")
            {

                g1.Text = "X";
                return 2;
            }


            else if (b == "" && e == "O" && h == "O")
            {

                b1.Text = "X";
                return 2;
            }
            else if (b == "O" && e == "" && h == "O")
            {

                e1.Text = "X";
                return 2;
            }
            else if (b == "O" && e == "O" && h == "")
            {

                h1.Text = "X";
                return 2;
            }


            else if (c == "" && f == "O" && i == "O")
            {

                c1.Text = "X";
                return 2;
            }
            else if (c == "O" && f == "" && i == "O")
            {

                f1.Text = "X";
                return 2;
            }
            else if (c == "O" && f == "O" && i == "")
            {

                i1.Text = "X";
                return 2;
            }


            else
            {
                return MakeMoveX(a1, b1, c1, d1, e1, f1, g1, h1, i1);
            }



        }
        public static int MakeMoveX(Button a1, Button b1, Button c1, Button d1, Button e1, Button f1, Button g1, Button h1, Button i1)
        {
            int num = ranNum.Next(1, 10);
            switch (num)
            {
                case 1:
                    if (a1.Text == "")
                    {

                        a1.Text = "X";
                        return 2;
                    }
                    break;
                case 2:
                    if (b1.Text == "")
                    {

                        b1.Text = "X";
                        return 2;
                    }
                    break;
                case 3:
                    if (c1.Text == "")
                    {

                        c1.Text = "X";
                        return 2;
                    }
                    break;
                case 4:
                    if (d1.Text == "")
                    {

                        d1.Text = "X";
                        return 2;
                    }
                    break;
                case 5:
                    if (e1.Text == "")
                    {

                        e1.Text = "X";
                        return 2;
                    }
                    break;
                case 6:
                    if (f1.Text == "")
                    {

                        f1.Text = "X";
                        return 2;
                    }
                    break;
                case 7:
                    if (g1.Text == "")
                    {

                        g1.Text = "X";
                        return 2;
                    }
                    break;
                case 8:
                    if (h1.Text == "")
                    {

                        h1.Text = "X";
                        return 2;
                    }
                    break;
                case 9:
                    if (i1.Text == "")
                    {

                        i1.Text = "X";
                        return 2;
                    }
                    break;


            }
            return 1;
        }
    }
}
