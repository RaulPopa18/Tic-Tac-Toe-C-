using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Project
{
    public partial class Form1 : Form
    {
         Gf engine;
         Board theBoard;
        public static bool aiGame = false;

        public static bool getAiGame()
        {
            return aiGame;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ai dori sa joci impotriva computerului? ", "Tic tac toe", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                aiGame = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics toPass = panel1.CreateGraphics();
            engine = new Gf(toPass);

            theBoard = new Board();
            theBoard.initBoard();
           // refreshLabel();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Point mouse = Cursor.Position;
            mouse = panel1.PointToClient(mouse);
            theBoard.detectHit(mouse);
           // refreshLabel();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            theBoard.reset();
            Gf.setUpCanvas();



        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void refreshLabel()
        {
            String newText = "";
            if(theBoard.getPlayerForTurn() ==Board.X)
            {
                newText += "X";

            }else
            {
                newText += "O";
            }

            newText += " muta \n";
            newText += "X a catigat de " + theBoard.getXwins() + " ori\nO a catigat de " + theBoard.getOwins() + " ori";
            label1.Text = newText;
        }




    }
}
