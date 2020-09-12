using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsOut
{
    public partial class MainForm : Form
    {
        private const int GridOffset = 25; // Distance from upper-left side of window
        private int gridLength = 200; // Size in pixels of grid
        private int cellLength;     //= GridLength / game.GridSize;


        LightsOutGame game;
        

        public MainForm()
        {
            InitializeComponent();

            //rand = new Random(); // Initializes random number generator4

            game = new LightsOutGame();

            x3ToolStripMenuItem.Checked = true;

            cellLength = gridLength / game.GridSize;

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int r = 0; r < game.GridSize; r++)
            {
                for (int c = 0; c < game.GridSize; c++)
                {
                    // Get proper pen and brush for on/off
                    // grid section
                    Brush brush;
                    Pen pen;
                    if (game.GetGridValue(r, c))
                    {
                        pen = Pens.Black;
                        brush = Brushes.White; // On
                    }
                    else
                    {
                        pen = Pens.White;
                        brush = Brushes.Black; // Off
                    }
                    // Determine (x,y) coord of row and col to draw rectangle
                    int x = c * cellLength + GridOffset;
                    int y = r * cellLength + GridOffset;
                    // Draw outline and inner rectangle
                    g.DrawRectangle(pen, x, y, cellLength, cellLength);
                    g.FillRectangle(brush, x + 1, y + 1, cellLength - 1, cellLength - 1);
                }
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Make sure click was inside the grid
            if (e.X < GridOffset || e.X > cellLength * game.GridSize + GridOffset ||
            e.Y < GridOffset || e.Y > cellLength * game.GridSize + GridOffset)
                return;
            // Find row, col of mouse press
            int r = (e.Y - GridOffset) / cellLength;
            int c = (e.X - GridOffset) / cellLength;
            // Invert selected box and all surrounding boxes
            game.Move(r, c);
            // Redraw grid
            this.Invalidate();
            // Check to see if puzzle has been solved
            if (PlayerWon())
            {
                // Display winner dialog box
                MessageBox.Show(this, "Congratulations! You've won!", "Lights Out!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool PlayerWon()
        {
            bool result = true;

            result = game.IsGameOver();

            return result;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            game.NewGame();
            this.Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGameButton_Click(sender, e);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitButton_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutBox = new AboutForm();
            aboutBox.ShowDialog(this);
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x3ToolStripMenuItem.Checked = true;
            game.GridSize = 3;

            x4ToolStripMenuItem.Checked = false;
            x5ToolStripMenuItem.Checked = false;

            ResizeGrid();
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x5ToolStripMenuItem.Checked = true;
            game.GridSize = 5;

            x3ToolStripMenuItem.Checked = false;
            x4ToolStripMenuItem.Checked = false;

            ResizeGrid();
        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x4ToolStripMenuItem.Checked = true;
            game.GridSize = 4;

            x3ToolStripMenuItem.Checked = false;
            x5ToolStripMenuItem.Checked = false;

            ResizeGrid();
        }

        private void ResizeGrid()
        {
            cellLength = gridLength / game.GridSize;
            this.Invalidate();
        }



        private void MainForm_Resize_1(object sender, EventArgs e)
        {
            Control form = (Control)sender;

            if (form.Width < form.Height)
            {
                gridLength = form.Width - (4 * GridOffset);
                cellLength = gridLength / game.GridSize;
            }
            else
            {
                gridLength = form.Height - (4 * GridOffset);
                cellLength = gridLength / game.GridSize;
            }


            this.Invalidate();
        }


    }
}
