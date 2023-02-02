using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tic_Tac_Toe_Project
{
    class Computer1
    {
        public static Holder determineAndPlaceMark(Holder[,] board)
        {
            Holder move = new Holder();
            move.setValue(Board.O);

            //verificam centrul
            if (board[1, 1].getValue() == Board.B)
            {
                move.setLocation(new Point(1, 1));
                return move;
            }
           

                for (int x = 0; x < 3; x++)
                {
                    if (board[x, 0].getValue() == Board.O && board[x, 1].getValue() == Board.O && board[x, 2].getValue() == Board.B)
                    {
                        move.setLocation(new Point(x, 2));
                        return move;
                    }
                }

                for (int x = 0; x < 3; x++)
                {
                    if (board[x, 0].getValue() == Board.B && board[x, 1].getValue() == Board.O && board[x, 2].getValue() == Board.O)
                    {
                        move.setLocation(new Point(x, 0));
                        return move;
                    }
                }

                for (int x = 0; x < 3; x++)
                {
                    if (board[x, 0].getValue() == Board.O && board[x, 1].getValue() == Board.B && board[x, 2].getValue() == Board.O)
                    {
                        move.setLocation(new Point(x, 1));
                        return move;
                    }
                }

                for (int y = 0; y < 3; y++)
                {
                    if (board[0,y].getValue() == Board.O && board[1,y].getValue() == Board.O && board[2,y].getValue() == Board.B)
                    {
                        move.setLocation(new Point(2, y));
                        return move;
                    }
                }

                for (int y = 0; y < 3; y++)
                {
                    if (board[0, y].getValue() == Board.B && board[1, y].getValue() == Board.O && board[2, y].getValue() == Board.O)
                    {
                        move.setLocation(new Point(0, y));
                        return move;
                    }
                }

                for (int y = 0; y < 3; y++)
                {
                    if (board[0, y].getValue() == Board.O && board[1, y].getValue() == Board.B && board[2, y].getValue() == Board.O)
                    {
                        move.setLocation(new Point(1, y));
                        return move;
                    }
                }

                if(board[0,0].getValue() == Board.O && board[1,1].getValue()== Board.O && board[2,2].getValue() ==Board.B)
                {
                    move.setLocation(new Point(2, 2));
                    return move;
                }

                else if (board[2, 0].getValue() == Board.O && board[1, 1].getValue() == Board.O && board[0, 2].getValue() == Board.B)
                {
                    move.setLocation(new Point(0, 2));
                    return move;
                }

                if (board[0, 2].getValue() == Board.O && board[1, 1].getValue() == Board.O && board[2, 0].getValue() == Board.B)
                {
                    move.setLocation(new Point(0, 2));
                    return move;
                }

                else if (board[2, 2].getValue() == Board.O && board[1, 1].getValue() == Board.O && board[0, 0].getValue() == Board.B)
                {
                    move.setLocation(new Point(0, 0));
                    return move;
                }

                if (board[0, 0].getValue() == Board.O && board[1, 1].getValue() == Board.B && board[2, 2].getValue() == Board.O)
                {
                    move.setLocation(new Point(1, 1));
                    return move;
                }

                else if (board[0, 2].getValue() == Board.O && board[1, 1].getValue() == Board.B && board[2, 0].getValue() == Board.O)
                {
                    move.setLocation(new Point(1, 1));
                    return move;
                }

                // check miscari defensive

                for (int x = 0; x < 3; x++)
                {
                    if (board[x, 0].getValue() == Board.X && board[x, 1].getValue() == Board.X && board[x, 2].getValue() == Board.B)
                    {
                        move.setLocation(new Point(x, 2));
                        return move;
                    }
                }

                for (int x = 0; x < 3; x++)
                {
                    if (board[x, 0].getValue() == Board.B && board[x, 1].getValue() == Board.X && board[x, 2].getValue() == Board.X)
                    {
                        move.setLocation(new Point(x, 0));
                        return move;
                    }
                }

                for (int x = 0; x < 3; x++)
                {
                    if (board[x, 0].getValue() == Board.X && board[x, 1].getValue() == Board.B && board[x, 2].getValue() == Board.X)
                    {
                        move.setLocation(new Point(x, 1));
                        return move;
                    }
                }

                for (int y = 0; y < 3; y++)
                {
                    if (board[0, y].getValue() == Board.X && board[1, y].getValue() == Board.X && board[2, y].getValue() == Board.B)
                    {
                        move.setLocation(new Point(2, y));
                        return move;
                    }
                }

                for (int y = 0; y < 3; y++)
                {
                    if (board[0, y].getValue() == Board.B && board[1, y].getValue() == Board.X && board[2, y].getValue() == Board.X)
                    {
                        move.setLocation(new Point(0, y));
                        return move;
                    }
                }

                for (int y = 0; y < 3; y++)
                {
                    if (board[0, y].getValue() == Board.X && board[1, y].getValue() == Board.B && board[2, y].getValue() == Board.X)
                    {
                        move.setLocation(new Point(1, y));
                        return move;
                    }
                }

                //1
                if (board[0, 0].getValue() == Board.X && board[1, 1].getValue() == Board.X && board[2, 2].getValue() == Board.B)
                {
                    move.setLocation(new Point(2, 2));
                    return move;
                }

                else if (board[2, 0].getValue() == Board.X && board[1, 1].getValue() == Board.X && board[0, 2].getValue() == Board.B)
                {
                    move.setLocation(new Point(0, 2));
                    return move;
                }
                //2
                if (board[0, 2].getValue() == Board.X && board[1, 1].getValue() == Board.X && board[2, 0].getValue() == Board.B)
                {
                    move.setLocation(new Point(0, 2));
                    return move;
                }

                else if (board[2, 2].getValue() == Board.X && board[1, 1].getValue() == Board.X && board[0, 0].getValue() == Board.B)
                {
                    move.setLocation(new Point(0, 0));
                    return move;
                }
                //3
                if (board[0, 0].getValue() == Board.X && board[1, 1].getValue() == Board.B && board[2, 2].getValue() == Board.X)
                {
                    move.setLocation(new Point(1, 1));
                    return move;
                }

                else if (board[0, 2].getValue() == Board.X && board[1, 1].getValue() == Board.B && board[2, 0].getValue() == Board.X)
                {
                    move.setLocation(new Point(1, 1));
                    return move;
                }



                //bool foundPlace = false;

                //Random gen = new Random();

                //while(!foundPlace)
                //{
                //    int xcord = gen.Next(0, 2);
                //    int ycord = gen.Next(0, 2);

                //    if(board[xcord,ycord].getValue()==Board.B)
                //    {
                //        foundPlace = true;
                //        move.setLocation(new Point(xcord, ycord));
                //    }
                //}

                List<Holder> blankSpaces = new List<Holder>();

                foreach(Holder h in board)
                {
                    if(h.getValue()==Board.B)
                    {
                        blankSpaces.Add(h);
                    }
                }

                move.setLocation(blankSpaces.ToArray()[0].getLocation());

                return move;


            


        }
    }
}
