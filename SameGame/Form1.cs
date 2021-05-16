using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace SameGame
{
    public partial class Form1 : Form
    {
        enum PieceTypes { Blank = 0, Red = 1, redHover = 2, Blue = 3, blueHover = 4, Green = 5, greenHover = 6, Yellow = 7, yellowHover = 8, Purple = 9, purpleHover = 10, Orange = 11, orangeHover = 12, LightBlue = 13, lightBlueHover = 14 }
        Size cellSize = new Size(30, 30);
        Size gridSize = new Size(10, 10);
        Bitmap imageStrip = new Bitmap(typeof(Form1), "SameGameImages.png");
        PieceTypes[,] gameData;
        // the number of colors being played with
        int numColors = 3;
        int Score = 0, points = 0;
        double time = 0;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        //closes the game
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //cell size 10,10
        private void x10ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cellSize = new Size(10, 10);
            x20ToolStripMenuItem1.Checked = false;
            x30ToolStripMenuItem1.Checked = false;
            GameSetup();
        }
        //cell size 20,20
        private void x20ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            cellSize = new Size(20, 20);
            x10ToolStripMenuItem1.Checked = false;
            x30ToolStripMenuItem1.Checked = false;
            GameSetup();
        }
        //cell size 30,30
        private void x30ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cellSize = new Size(30, 30);
            x10ToolStripMenuItem1.Checked = false;
            x20ToolStripMenuItem1.Checked = false;
            GameSetup();
        }
        //boarder size 10,10
        private void x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridSize = new Size(10, 10);
            x30ToolStripMenuItem.Checked = false;
            x20ToolStripMenuItem.Checked = false;
            GameSetup();
        }
        // boarder size 20,20
        private void x20ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gridSize = new Size(20, 20);
            x10ToolStripMenuItem.Checked = false;
            x30ToolStripMenuItem.Checked = false;
            GameSetup();
        }
        //boarder size 30,30
        private void x30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridSize = new Size(30, 30);
            x10ToolStripMenuItem.Checked = false;
            x20ToolStripMenuItem.Checked = false;
            GameSetup();
        }
        /// <summary>
        /// removes the pieces clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            TimeItTakes.Enabled = true;
            double finalScore = 0;
            int x = e.X / cellSize.Width;
            int y = (e.Y - menuStrip1.Height) / cellSize.Height;
            //piece clicked
            PieceTypes CurrentPiece = gameData[x, y];
            // prevents a crash if the piece clicked is a blank
            if (gameData[x, y] != PieceTypes.Blank)
                //removes the pieces
                NeighbourMatch(x, y, CurrentPiece);
            // resets the points to zero
            points = 0;
            // moves remaing pieces down
            MoveDown();
            // checks to see if pieces can be moved left
            MoveLeftCheck();
            Invalidate();
            // checks to see if they won the game
            if (GameWin())
            {
                // shows message and resets
                TimeItTakes.Enabled = false;
                finalScore = Score - (15 * (time * time));
                MessageBox.Show("You Win\nYour score was: " + Score.ToString("0.00") + "\nTime taken: " + time.ToString("0.00") + " Seconds" + "\nFinal score: " + finalScore.ToString("0.00"),"You Win!");
                GameSetup();
            }
            // they didn win but did they loose
            else if (!GameLoose())
            {
                //yes showns a message and resets
                TimeItTakes.Enabled = false;
                finalScore = Score - (15 * (time * time));
                MessageBox.Show("You lose\nYour final score was: " + Score.ToString("0.00") + "\nTime taken: " + time.ToString("0.00")+ " Seconds" + "\nFinal score: " + finalScore.ToString("0.00"),"You Lose ):");
                GameSetup();
            }
        }
        /// <summary>
        /// looks to see if the pieces left have friends
        /// </summary>
        /// <returns></returns>
        private bool GameLoose()
        {
            // a random thing
            PieceTypes color = PieceTypes.blueHover;
            // looks for a piece
            for (int x = 0; x < gridSize.Width; x++)
                for (int y = 0; y < gridSize.Width; y++)
                    if (gameData[x, y] != PieceTypes.Blank)
                    {
                        // changes the color to the piece found
                        color = gameData[x, y];
                        //bounds checks left for a friend
                        if (x > 0 && gameData[x - 1, y] == color)
                        {
                            return true;
                        }
                        //bounds checks right for a friend
                        if (x < gridSize.Width - 1 && gameData[x + 1, y] == color)
                        {
                            return true;
                        }
                        //bounds checks up for a friend
                        if (y > 0 && gameData[x, y - 1] == color)
                        {
                            return true;
                        }
                        //bounds checks down for a friend
                        if (y < gridSize.Height - 1 && gameData[x, y + 1] == color)
                        {
                            return true;
                        }
                    }
            // no friends
            return false;
        }
        // looks for any piece
        private bool GameWin()
        {
            for (int x = 0; x < gridSize.Width; x++)
                for (int y = 0; y < gridSize.Width; y++)
                    if (gameData[x, y] != PieceTypes.Blank)
                        return false;
            return true;
        }
        /// <summary>
        /// checks to find all the friends of the one clicked
        /// </summary>
        /// <param name="x">the x location of the click</param>
        /// <param name="y"> the y location of the click</param>
        /// <param name="color">the color clicked</param>
        private void NeighbourMatch(int x, int y, PieceTypes color)
        {
            // bounds and checks to the left to see if there are friends there
            if (x > 0 && gameData[x - 1, y] == color)
            {
                // add to the point score
                points++;
                // remove the piece
                gameData[x - 1, y] = PieceTypes.Blank;
                // call the function again and see if there are more in that direction
                NeighbourMatch(x - 1, y, color);
            }
            // repeat in different direction
            if (x < gridSize.Width - 1 && gameData[x + 1, y] == color)
            {
                points++;
                gameData[x + 1, y] = PieceTypes.Blank;
                NeighbourMatch(x + 1, y, color);
            }
            // repeat in different direction
            if (y > 0 && gameData[x, y - 1] == color)
            {
                points++;
                gameData[x, y - 1] = PieceTypes.Blank;
                NeighbourMatch(x, y - 1, color);
            }
            // repeat in different direction
            if (y < gridSize.Height - 1 && gameData[x, y + 1] == color)
            {
                points++;
                gameData[x, y + 1] = PieceTypes.Blank;
                NeighbourMatch(x, y + 1, color);
            }
            // reward the player for getting lots of pieces out in one click
            Score = Score + (points * points);
        }
        /// <summary>
        /// moves all the pieces down
        /// </summary>
        private void MoveDown()
        {
            PieceTypes CurrentPiece;
            // checks for pieces
            for (int i = 0; i < gridSize.Width; i++)
                for (int j = 0; j < gridSize.Height; j++)
                    if (gameData[i, j] != PieceTypes.Blank)
                        // if there is a blank under the piece move the piece down
                        if (j < gridSize.Height - 1 && gameData[i, j + 1] == PieceTypes.Blank)
                        {
                            //the swap
                            CurrentPiece = gameData[i, j];
                            gameData[i, j + 1] = CurrentPiece;
                            gameData[i, j] = PieceTypes.Blank;
                            // check again
                            MoveDown();
                        }
        }
        /// <summary>
        /// finds and empty colum to move the pieces to
        /// </summary>
        private void MoveLeftCheck()
        {
            int numBlank = 0;
            //checks for blanks
            for (int i = 0; i < gridSize.Width; i++)
                for (int j = 0; j < gridSize.Height; j++)
                    //if it finds one
                    if (gameData[i, j] == PieceTypes.Blank)
                    {
                        // add it to the score
                        numBlank++;
                        // if there is a whole colum of them move the pieces
                        if (numBlank == gridSize.Height)
                            MoveLeft(i);
                    }
                    // if not a whole colum is blank start again
                    else
                        numBlank = 0;
        }
        /// <summary>
        /// attually moves the pieces to the empty colum
        /// </summary>
        /// <param name="emptyColum">a empty colum to move the pieces to</param>
        private void MoveLeft(int emptyColum)
        {
            int moveAgain = 0;
            PieceTypes CurrentPiece;
            //starts at the empty colum
            for (int i = emptyColum; i < gridSize.Width; i++)
                for (int j = 0; j < gridSize.Height; j++)
                    //bounds check and if the piece next to it is blank and the piece on it is not blank
                    if (i < gridSize.Width && i != 0 && gameData[i - 1, j] == PieceTypes.Blank && gameData[i, j] != PieceTypes.Blank)
                    {
                        //swap
                        CurrentPiece = gameData[i, j];
                        gameData[i - 1, j] = CurrentPiece;
                        gameData[i, j] = PieceTypes.Blank;
                        // runs to check again
                        MoveLeftCheck();
                        // bounds and checks if it can move again
                        if (i < gridSize.Width && i >= 2 && gameData[i - 2, j] == PieceTypes.Blank && gameData[i, j] != PieceTypes.Blank)
                            moveAgain++;
                        //calls itself if it is at the bottom and there is an open space
                        if (j == gridSize.Height - 1 && moveAgain != 0)
                            MoveLeft(emptyColum + 1);
                    }
        }
        /// <summary>
        /// when the form is first loaded sets up the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            GameSetup();
        }
        /// <summary>
        /// sets up the board
        /// </summary>
        private void GameSetup()
        {
            // sets up gameData
            gameData = new PieceTypes[gridSize.Width, gridSize.Height];
            //fills the board with random pieces
            for (int i = 0; i < gridSize.Width; i++)
                for (int j = 0; j < gridSize.Height; j++)
                    // the location is filled with the piecetype number with a random number to find which color it is
                    gameData[i, j] = (PieceTypes)(rand.Next(numColors) * 2 + 1);
            // changes the screen size
            this.ClientSize = new Size(gridSize.Width * cellSize.Width, gridSize.Height * cellSize.Height + menuStrip1.Height + statusStrip1.Height);
            this.CenterToScreen();
            // resets the score
            Score = 0;
            time = 0;
            TimeItTakes.Enabled = false;
            Invalidate();
        }
        /// <summary>
        /// paint the board
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int x = 0; x < gridSize.Width; x++)
                for (int y = 0; y < gridSize.Height; y++)
                    if (gameData[x, y] != PieceTypes.Blank)
                    {
                        Rectangle destRect = new Rectangle(x * cellSize.Width,
                                        y * cellSize.Height + menuStrip1.Height,
                                        cellSize.Width,
                                        cellSize.Height);
                        int PicCell = imageStrip.Height;

                        Rectangle srcRect = new Rectangle(PicCell * (int)gameData[x, y], 0, PicCell, PicCell);
                        e.Graphics.DrawImage(imageStrip, destRect, srcRect, GraphicsUnit.Pixel);
                    }
        }
        /// <summary>
        /// changes the color of the orbs to indicate the size of orbs being deleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X / cellSize.Width;
            int y = (e.Y - menuStrip1.Height) / cellSize.Height;
            // bounds check for very sultle error
            if (x >= gridSize.Width || y >= gridSize.Height)
                return;
            // checks if the mouse is already on the hovering orbs
            if ((int)gameData[x, y] % 2 == 0)
                return;
            //goes through the board and checks if there are hovered pieces changes them back to normal
            for (int i = 0; i < gridSize.Width; i++)
                for (int j = 0; j < gridSize.Height; j++)
                    if ((int)gameData[i, j] % 2 == 0 && gameData[i, j] != PieceTypes.Blank)
                        gameData[i, j]--;
            // the current piece the user is over
            PieceTypes selected = gameData[x, y];
            // finds it friends
            NeighbourMatchMouseMove(x, y, selected);
            toolStripStatusLabel1.Text = ("Your Score: " + Score.ToString());
            this.Invalidate();
        }
        /// <summary>
        /// changes the orbs to become smaller when hovered
        /// </summary>
        /// <param name="x">x location of the mouse</param>
        /// <param name="y">y location of the mouse</param>
        /// <param name="color">the color of the orb the mouse is on</param>
        private void NeighbourMatchMouseMove(int x, int y, PieceTypes color)
        {
            // check to the left if there is a same color
            if (x > 0 && gameData[x - 1, y] == color)
            {
                // change the color
                gameData[x - 1, y]++;
                // call the function again to see if there are more orbs on that side
                NeighbourMatchMouseMove(x - 1, y, color);
            }
            //repeat the first one in a different direction
            if (x < gridSize.Width - 1 && gameData[x + 1, y] == color)
            {
                gameData[x + 1, y]++;
                NeighbourMatchMouseMove(x + 1, y, color);
            }
            if (y > 0 && gameData[x, y - 1] == color)
            {
                gameData[x, y - 1]++;
                NeighbourMatchMouseMove(x, y - 1, color);
            }
            if (y < gridSize.Height - 1 && gameData[x, y + 1] == color)
            {
                gameData[x, y + 1]++;
                NeighbourMatchMouseMove(x, y + 1, color);
            }
        }
        /// <summary>
        /// sets the number of colors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMNumColor7_Click(object sender, EventArgs e)
        {
            numColors = 7;
            TSMNumColor3.Checked = false;
            TSMNumColor4.Checked = false;
            TSMNumColor5.Checked = false;
            TSMNumColor6.Checked = false;
            GameSetup();
            Invalidate();
        }
        /// <summary>
        /// sets the number of colors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMNumColor6_Click(object sender, EventArgs e)
        {
            numColors = 6;
            TSMNumColor3.Checked = false;
            TSMNumColor4.Checked = false;
            TSMNumColor5.Checked = false;
            TSMNumColor7.Checked = false;
            GameSetup();
            Invalidate();
        }
        /// <summary>
        /// sets the number of colors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMNumColor5_Click(object sender, EventArgs e)
        {
            numColors = 5;
            TSMNumColor3.Checked = false;
            TSMNumColor4.Checked = false;
            TSMNumColor7.Checked = false;
            TSMNumColor6.Checked = false;
            GameSetup();
            Invalidate();
        }
        /// <summary>
        /// sets the number of colors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMNumColor4_Click(object sender, EventArgs e)
        {
            numColors = 4;
            TSMNumColor3.Checked = false;
            TSMNumColor7.Checked = false;
            TSMNumColor5.Checked = false;
            TSMNumColor6.Checked = false;
            GameSetup();
            Invalidate();
        }
        /// <summary>
        /// sets the number of colors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMNumColor3_Click(object sender, EventArgs e)
        {
            numColors = 3;
            TSMNumColor7.Checked = false;
            TSMNumColor4.Checked = false;
            TSMNumColor5.Checked = false;
            TSMNumColor6.Checked = false;
            GameSetup();
            Invalidate();
        }
        /// <summary>
        /// resets the board
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameSetup();
        }
        /// <summary>
        /// Who made it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(c) John Hiebert, 2015", "About...");
        }
        /// <summary>
        /// the rules
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Suck all the orbs into the vacum.\nThe more orbs you select the more points you are given.\nTry to get as many point as possible. Good Luck!");
        }
        /// <summary>
        /// runs a time to show the time played
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeItTakes_Tick(object sender, EventArgs e)
        {
            double timevalue = time = time + .1;
            toolStripStatusLabel2.Text = ("Time Taken: " + timevalue.ToString("0.0"));
        }


    }
}
