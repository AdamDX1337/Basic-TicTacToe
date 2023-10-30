using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    internal class Movement
    {

        static Random ranNum = new Random();
        public static int MakeEducatedMove(Button a1, Button b1, Button c1, Button d1, Button e1, Button f1, Button g1, Button h1, Button i1)
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
            if (a == "" && e == "X" && i == "X")
            {

                a1.Text = "O";
                return 1;
            }
            else if (a == "X" && e == "" && i == "X")
            {

                e1.Text = "O";
                return 1;
            }
            else if (a == "X" && e == "X" && i == "")
            {

                i1.Text = "O";
                return 1;
            }


            else if (c == "" && e == "X" && g == "X")
            {

                c1.Text = "O";
                return 1;
            }
            else if (c == "X" && e == "" && g == "X")
            {

                e1.Text = "O";
                return 1;
            }
            else if (c == "X" && e == "X" && g == "")
            {

                g1.Text = "O";
                return 1;
            }

            //horizontal
            else if (a == "" && b == "X" && c == "X")
            {

                a1.Text = "O";
                return 1;
            }
            else if (a == "X" && b == "" && c == "X")
            {

                b1.Text = "O";
                return 1;
            }
            else if (a == "X" && b == "X" && c == "")
            {

                c1.Text = "O";
                return 1;
            }


            else if (d == "" && e == "X" && f == "X")
            {

                d1.Text = "O";
                return 1;
            }
            else if (d == "X" && e == "" && f == "X")
            {

                e1.Text = "O";
                return 1;
            }
            else if (d == "X" && e == "X" && f == "")
            {

                f1.Text = "O";
                return 1;
            }


            else if (g == "" && h == "X" && i == "X")
            {

                g1.Text = "O";
                return 1;
            }
            else if (g == "X" && h == "" && i == "X")
            {

                h1.Text = "O";
                return 1;
            }
            else if (g == "X" && h == "X" && i == "")
            {

                i1.Text = "O";
                return 1;
            }

            //Vertical
            else if (a == "" && d == "X" && g == "X")
            {

                a1.Text = "O";
                return 1;
            }
            else if (a == "X" && d == "" && g == "X")
            {

                d1.Text = "O";
                return 1;
            }
            else if (a == "X" && d == "X" && g == "")
            {

                g1.Text = "O";
                return 1;
            }


            else if (b == "" && e == "X" && h == "X")
            {

                b1.Text = "O";
                return 1;
            }
            else if (b == "X" && e == "" && h == "X")
            {

                e1.Text = "O";
                return 1;
            }
            else if (b == "X" && e == "X" && h == "")
            {

                h1.Text = "O";
                return 1;
            }


            else if (c == "" && f == "X" && i == "X")
            {

                c1.Text = "O";
                return 1;
            }
            else if (c == "X" && f == "" && i == "X")
            {

                f1.Text = "O";
                return 1;
            }
            else if (c == "X" && f == "X" && i == "")
            {

                i1.Text = "O";
                return 1;
            }


            else
            {
                return MakeMove(a1,b1,c1,d1,e1,f1,g1,h1,i1);
            }



        }
        public static int MakeMove(Button a1, Button b1, Button c1, Button d1, Button e1, Button f1, Button g1, Button h1, Button i1)
        {
            int num = ranNum.Next(1, 10);
            switch (num)
            {
                case 1:
                    if (a1.Text == "")
                    {
                        
                        a1.Text = "O";
                        return 1;
                    }
                    break;
                case 2:
                    if (b1.Text == "")
                    {
                        
                        b1.Text = "O";
                        return 1;
                    }
                    break;
                case 3:
                    if (c1.Text == "")
                    {
                        
                        c1.Text = "O";
                        return 1;
                    }
                    break;
                case 4:
                    if (d1.Text == "")
                    {
                        
                        d1.Text = "O";
                        return 1;
                    }
                    break;
                case 5:
                    if (e1.Text == "")
                    {
                        
                        e1.Text = "O";
                        return 1;
                    }
                    break;
                case 6:
                    if (f1.Text == "")
                    {
                        
                        f1.Text = "O";
                        return 1;
                    }
                    break;
                case 7:
                    if (g1.Text == "")
                    {
                        
                        g1.Text = "O";
                        return 1;
                    }
                    break;
                case 8:
                    if (h1.Text == "")
                    {
                        
                        h1.Text = "O";
                        return 1;
                    }
                    break;
                case 9:
                    if (i1.Text == "")
                    {
                        
                        i1.Text = "O";
                        return 1;
                    }
                    break;


            }
            return 2;
        }

    }
}
