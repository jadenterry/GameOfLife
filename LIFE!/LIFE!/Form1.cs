using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIFE_
{
    public partial class Form1 : Form
    {
        public bool[,] grid = new bool[gridSize, gridSize];
        public bool playButtonClick = true;
        public int population = 0;
        public Color c = Color.Black;
        public Color c2 = Color.Blue;
        public int mouseX;
        public int mouseY;
        public int generation = 0;
        public static int gridSize = 70;
        public bool fallOff;
        public int rectSize = 10;
        public Form1()
        {
            InitializeComponent();
            this.Text = "LIFE";
            comboBox1.SelectedIndex = 1; 
            genNumLabel.Text = "Generation #: " + generation;
            sizeLabel.Text = "Universe Size: " + gridSize * gridSize;
            popLabel.Text = "Population: " + population;

        }

        private void theWorld_Paint_1(object sender, PaintEventArgs e)
        {
            population = 0;
            drawGrid(e.Graphics);
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            genNumLabel.Text = "Generation #: " + generation;
            sizeLabel.Text = "Universe Size: " + gridSize * gridSize;
            popLabel.Text = "Population: " + population;
            timer.Interval = speedBar.Value;
            if (playButtonClick == true)
            {
                evolve();
                generation++;
            }
            theWorld.Invalidate();
        }

        private void theWorld_MouseClick(object sender, MouseEventArgs e)
        {
            mouseX = e.X / rectSize;
            mouseY = e.Y / rectSize;
            int x = (e.X);
            int y = (e.Y);
            int i = x / rectSize;
            int j = y / rectSize;
            grid[i, j] = !grid[i, j];
            theWorld.Invalidate();

        }

        private void drawGrid(Graphics g)
        {
            
            SolidBrush b = new SolidBrush(c);
            Pen p = new Pen(c2);
            Pen p2 = new Pen(Color.Red, 4);
            g.Clear(Color.White);
            g.DrawLine(p2, (gridSize * rectSize)/2, 0, (gridSize* rectSize)/2, gridSize * rectSize);
            g.DrawLine(p2, 0, (gridSize * rectSize) / 2, (gridSize * rectSize), (gridSize * rectSize)/2);
            for (int i = 0; i < gridSize - 1; i++)
            {
                for (int j = 0; j < gridSize - 1; j++)
                {
                    g.DrawRectangle(p, i * rectSize, j * rectSize, rectSize, rectSize);
                    if (grid[i, j])
                    {
                        g.FillRectangle(b, i * rectSize, j * rectSize, rectSize, rectSize);
                        population++;
                    }
                }
            }
        }
        public void evolve()
        {
            bool[,] newGrid = new bool[gridSize, gridSize];
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (fallOff == true)
                    {
                        newGrid[i, j] = fallOffEdge(i, j);
                    }
                    else                    
                    {
                        newGrid[i, j] = wrapAround(i, j);
                    }
                }
            }
            grid = newGrid;
        }
        public Boolean wrapAround(int x, int y)
        {
            int counter = 0;
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        int a = (i + gridSize) % gridSize;
                        int b = (j + gridSize) % gridSize;
                        if (grid[a, b])
                        {
                            counter++;
                        }
                    }
                }
                if (!grid[x, y])
                {
                    return counter == 3;
                }
                else
                {
                    return counter >= 3 && counter <= 4;
                }
            
        }
        public Boolean fallOffEdge(int x, int y)
        {
            int counter = 0;
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (j < gridSize && j >= 0)

                            if (i < gridSize && i >= 0)
                            {
                                if (grid[i, j])
                                    counter++;
                            }
                    }

                }
                if (!grid[x, y])
                {
                    return counter == 3;
                }
                else
                {
                    return counter >= 3 && counter <= 4;
                }
        }


        private void playButton_Click(object sender, EventArgs e)
        {
            if (playButtonClick == true)
            {
                timer.Start();
                playButton.Text = "Play";
                playButtonClick = false;
            }
            else if (playButtonClick == false)
            {
                playButton.Text = "Pause";
                playButtonClick = true;
            }
            theWorld.Refresh();
        }
        

        private void loadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Text File";
            openFileDialog1.Filter = "Text Files | *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            int x = 0;
            using(StreamReader infile = File.OpenText(openFileDialog1.FileName))
                try
                {
                    while (infile.Peek() >= 0)
                    {
                        string values = infile.ReadLine();
                        for (int i = 0; i < values.Length; i++)
                        {
                            if (values[i].Equals('*'))
                            {
                                grid[i, x] = true;
                            }
                            else
                            {
                                grid[i, x] = false;
                            }
                        }
                        x++;
                    }
                }
            catch
            {
                MessageBox.Show("File is GARBAGE!!");
            }
            theWorld.Invalidate();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Random.txt";
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.Filter = "Text Files | *.txt";
            int counter = 0;
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                    
                    for (int i = 0; i < gridSize; i++)
                    {
                        for (int j = 0; j < gridSize; j++)
                        {
                            if (counter % gridSize == 0)
                            {
                                writer.Write(Environment.NewLine);
                            }
                            if (grid[j, i])
                            {
                                counter++;
                                writer.Write("*");
                            }
                            if (!grid[j, i])
                            {
                                counter++;
                                writer.Write(" ");
                            }
                        }

                    }
            }
        }

        private void speedBar_Scroll(object sender, ScrollEventArgs e)
        {
            speedBar.Value = e.NewValue;
        }

        private void resizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int size = int.Parse(resizeTextbox.Text);
                bool[,] newGrid = new bool[size, size];
                int r = (size - gridSize) / 2;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (i - r >= 0 && i - r < size && j - r >= 0 && j - r < size)
                        {
                            newGrid[i, j] = grid[i - r, j - r];
                        }
                    }
                }
                grid = newGrid;
                theWorld.Invalidate();
            }
            catch
            {
                resizeTextbox.Text = "50";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                fallOff = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                fallOff = true;
            }
        }

        private void gridBox_CheckedChanged(object sender, EventArgs e)
        {
            if (gridBox.Checked)
            {
                c2 = Color.White;
            }
            else if (!gridBox.Checked)
            {
                c2 = Color.Blue;
            }
            theWorld.Invalidate();
        }

        private void resetButton1_Click_1(object sender, EventArgs e)
        {
            generation = 0;
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    grid[i, j] = false;
                }
            }
            theWorld.Invalidate();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                c = colorDialog1.Color;
            }
            theWorld.Invalidate();
        }

        private void nextGen_Click(object sender, EventArgs e)
        {
            evolve();
            generation++;
            genNumLabel.Text = "Generation #: " + generation;
            theWorld.Refresh();

        }

        private void mirrorButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize/2; j++)
                {
                    grid[i, (gridSize - j) - 1] = grid[i, j];

                }
            }
            theWorld.Invalidate();
        }

        private void mirror2Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridSize / 2; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    grid[(gridSize - i) - 1, j] = grid[i, j];
                }
            }
            theWorld.Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
            grid[10, 20] = true;
            grid[11, 20] = true;
            grid[10, 21] = true;
            grid[11, 21] = true;
            grid[22, 18] = true;
            grid[23, 18] = true;
            grid[21, 19] = true;
            grid[20, 20] = true;
            grid[20, 21] = true;
            grid[20, 22] = true;
            grid[21, 23] = true;
            grid[22, 24] = true;
            grid[23, 24] = true;
            grid[25, 23] = true;
            grid[26, 22] = true;
            grid[26, 21] = true;
            grid[27, 21] = true;
            grid[24, 21] = true;
            grid[26, 20] = true;
            grid[25, 19] = true;
            grid[30, 18] = true;
            grid[31, 18] = true;
            grid[30, 19] = true;
            grid[31, 19] = true;
            grid[30, 20] = true;
            grid[31, 20] = true;
            grid[32, 21] = true;
            grid[34, 21] = true;
            grid[34, 22] = true;
            grid[32, 17] = true;
            grid[34, 16] = true;
            grid[34, 17] = true;
            grid[44, 18] = true;
            grid[45, 18] = true;
            grid[44, 19] = true;
            grid[45, 19] = true;
            theWorld.Invalidate();
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

                    grid[mouseX, mouseY] = true;
                    grid[mouseX + 1, mouseY] = true;
                    grid[mouseX + 1, mouseY + 1] = true;
                    grid[mouseX + 1, mouseY + 2] = true;
                    grid[mouseX - 1, mouseY + 1] = true;
                
            theWorld.Invalidate();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

                grid[mouseX, mouseY] = true;
                grid[mouseX + 1, mouseY] = true;
                grid[mouseX + 2, mouseY] = true;
                grid[mouseX + 4, mouseY] = true;
                grid[mouseX, mouseY + 1] = true;
                grid[mouseX, mouseY + 4] = true;
                grid[mouseX + 1, mouseY + 3] = true;
                grid[mouseX + 2, mouseY + 3] = true;
                grid[mouseX + 2, mouseY + 4] = true;
                grid[mouseX + 3, mouseY + 2] = true;
                grid[mouseX + 4, mouseY + 2] = true;
                grid[mouseX + 4, mouseY + 3] = true;
                grid[mouseX + 4, mouseY + 4] = true;
                theWorld.Invalidate();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
                grid[mouseX, mouseY] = true;
                grid[mouseX + 2, mouseY] = true;
                grid[mouseX + 2, mouseY - 1] = true;
                grid[mouseX + 4, mouseY - 2] = true;
                grid[mouseX + 4, mouseY - 3] = true;
                grid[mouseX + 4, mouseY - 4] = true;
                grid[mouseX + 6, mouseY - 4] = true;
                grid[mouseX + 7, mouseY - 4] = true;
                grid[mouseX + 6, mouseY - 5] = true;
                grid[mouseX + 6, mouseY - 3] = true;
                theWorld.Invalidate();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
 
                grid[mouseX, mouseY] = true;
                grid[mouseX + 1, mouseY] = true;
                grid[mouseX + 1, mouseY - 2] = true;
                grid[mouseX + 3, mouseY - 1] = true;
                grid[mouseX + 4, mouseY] = true;
                grid[mouseX + 5, mouseY] = true;
                grid[mouseX + 6, mouseY] = true;
                theWorld.Invalidate();
            
        }
        }
    }




