using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Tic_Tac_Toe_Project
{
    class Board
    {
        public int movesMade = 0;
        public int Owins = 0;
        public int Xwins = 0;
       

        private Holder[,] holders = new Holder[3, 3];
            
        public const int X= 0;
        public const int O = 1;
        public const int B = 2;
        public int playersTurn = X;

        public int getPlayerForTurn()
        {
            return playersTurn;
        }

        public int getOwins()
        {
            return Owins;
        }

        public int getXwins()
        {
            return Xwins;
        }

        public void initBoard()
        {
            for (int x=0;x<3; x++)
            {
                for(int y=0;y<3;y++)
                {
                 
                    holders[x, y] = new Holder();
                    holders[x, y].setValue(B);
                    holders[x, y].setLocation(new Point(x, y));
                }
            }
        }

        public void detectHit(Point loc)
        {
            // verificam daca s-a dat click pe tabla
            if (loc.Y <= 500)
            {

                int x = 0;
                int y = 0;

                if (loc.X < 167)
                {
                    x = 0;
                }
                else if (loc.X > 167 && loc.X < 334)
                {
                    x = 1;
                }
                else if (loc.X > 334)
                {
                    x = 2;
                }

                if (loc.Y < 167)
                {
                    y = 0;
                }
                else if (loc.Y > 167 && loc.Y < 334)
                {
                    y = 1;
                }
                else if (loc.Y > 334 && loc.Y < 500)
                {
                    y = 2;
                }



               // MessageBox.Show(x.ToString() + ", " + y.ToString() + "\n\n" + loc.ToString());
               

                if(movesMade % 2 == 0)
                {
                   Gf.drawX(new Point(x, y));
                    holders[x, y].setValue(X);

                    if (detectRow())
                    {
                        MessageBox.Show("X, a castigat");
                        Xwins++;
                        reset();
                        Gf.setUpCanvas();
                    }

                    if(isBoardFull())
                    {
                        movesMade++;
                    }

                    if (Form1.getAiGame() && !detectRow() && !isBoardFull())
                    {
                        Holder aiMove = Computer1.determineAndPlaceMark(holders);

                        Gf.drawO(aiMove.getLocation());
                        holders[aiMove.getLocation().X, aiMove.getLocation().Y].setValue(O);

                        if (detectRow())
                        {
                            MessageBox.Show("Computerul a castigat");
                            Owins++;
                            reset();
                            Gf.setUpCanvas();
                           
                        }
                        movesMade++;
                        playersTurn = X;
                       
                    }
                   
                    playersTurn = O;
                  
                }

                else
                {
                    Gf.drawO(new Point(x, y));
                    holders[x, y].setValue(O);

                    if (detectRow())
                    {
                       MessageBox.Show("Y, a castigat");
                        Owins++;
                        reset();
                        Gf.setUpCanvas();
                    }
                    playersTurn = X;
                }

                movesMade++;
            }
        }

        public bool detectRow()
        {
            bool isWon = false;

            for (int x = 0; x < 3; x++)
            {
                if (holders[x, 0].getValue() == X && holders[x, 1].getValue() == X && holders[x, 2].getValue() == X)
                {
                    return true;
                }

                if (holders[x, 0].getValue() == O && holders[x, 1].getValue() == O && holders[x, 2].getValue() == O)
                {
                    return true;
                }

                // diagonale
                switch (x)
                {
                    case 0:
                        if (holders[x, 0].getValue() == X && holders[x + 1, 1].getValue() == X && holders[x + 2, 2].getValue() == X)
                        {
                            return true;
                        }

                        if (holders[x, 0].getValue() == O && holders[x + 1, 1].getValue() == O && holders[x + 2, 2].getValue() == O)
                        {
                            return true;
                        }

                        break;

                    case 2:
                        if (holders[x, 0].getValue() == X && holders[x - 1, 1].getValue() == X && holders[x - 2, 2].getValue() == X)
                        {
                            return true;
                        }

                        if (holders[x, 0].getValue() == O && holders[x - 1, 1].getValue() == O && holders[x - 2, 2].getValue() == O)
                        {
                            return true;
                        }
                        break;
                }


            }

            for(int y=0;y<3;y++)
            {
                if (holders[0, y].getValue() == X && holders[1, y].getValue() == X && holders[2, y].getValue() == X)
                {
                    return true;
                }

                if (holders[0, y].getValue() == O && holders[1, y].getValue() == O && holders[2, y].getValue() == O)
                {
                    return true;
                }

            }


            return isWon;
        }

        public void reset()
        {
            holders = new Holder[3, 3];
            initBoard();
        }

        public bool isBoardFull()
        {
            bool full = true;

            foreach(Holder h in holders)
            {
                if(h.getValue() == Board.B)
                {
                    full = false;
                }
            }
            return full;
        }


    }

   
}
