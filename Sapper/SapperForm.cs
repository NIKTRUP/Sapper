using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapper
{
    public partial class Sapper : Form
    {
        // не изменяемые
        int cellWidth = 30, cellHeight = 30, changeLocation = 30;
        int bombCreationProbability = 20;
        int start_x = 10, start_y = 50;
        //bool registrationFirstClickBomb = false;
        ButtonExtended[,] allButtons;

        // изменяемые компьютером
        int amountOfOpenedСells = 0, amountOfBombs = 0;
        int seconds, minutes;
        bool firstclick = true;

        // изменяемые человеком
        int fieldWidth = 270, fieldHeight = 270;
        int sizeFieldInCells = 9;
        int timeLimitInMminutes = 10;

        public Sapper()
        {
            InitializeComponent();
            gameTimer.Interval = 1000;
            seconds = 0;
            minutes = 0;
            label_amountOfSeconds.Text = "00";
            label_amountOfMinutes.Text = "00";
        }
        private void Sapper_Load(object sender, EventArgs e)
        {
            CreateGame();
        }
        private void CreateGame()
        {
            allButtons = new ButtonExtended[sizeFieldInCells, sizeFieldInCells];
            Random random = new Random(); 
            for (int i = 0, index_y = 0; i < fieldHeight; i += changeLocation, index_y++)
            {
                for (int j = 0, index_x = 0; j < fieldWidth; j += changeLocation, index_x++)
                {
                    ButtonExtended button = new ButtonExtended();
                    button.Location = new Point(start_x + j, start_y + i);
                    button.Size = new Size(cellWidth, cellHeight);
                    button.isFlag = true;
                    if (random.Next(0, 100) < bombCreationProbability) //вероятность 20% появления бомбы на кнопке
                    {
                        button.isBomb = true;
                        amountOfBombs++;
                    }
                    button.x_currectCell = index_x;
                    button.y_currectCell = index_y;
                    allButtons[index_x, index_y] = button;
                    Controls.Add(button);
                    button.MouseUp += new MouseEventHandler(ClickOnСell);
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\back.png");
                }
            }
        }
        private void DisplayingBombs()
        {
            if (amountOfBombs < 10)
            {
                label_bombs.Text = "0" + amountOfBombs;
            }
            else
            {
                label_bombs.Text = amountOfBombs.ToString();
            }
        }
        private void DisplayingOpenedCells()
        {
            if (amountOfOpenedСells < 10)
            {
                label_OpenedCells.Text = "0" + amountOfOpenedСells.ToString();
            }
            else
            {
                label_OpenedCells.Text = amountOfOpenedСells.ToString();
            }
        }
        private void DisplayingAllEmptyCells()
        {
            /*
            if (registrationFirstClickBomb == true)
            {
                label_OpenedCells.Text = "0" + 1;
                registrationFirstClickBomb = false;
            }
            */
            if (sizeFieldInCells * sizeFieldInCells - amountOfBombs < 10)
            {
                label_OpenedCells.Text = "0" + (sizeFieldInCells * sizeFieldInCells - amountOfBombs).ToString();
            }
            else
            {
                label_allEmptyCells.Text = (sizeFieldInCells * sizeFieldInCells - amountOfBombs).ToString();
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (minutes < timeLimitInMminutes)
            {
                if (seconds < 59)
                {
                    seconds++;
                    if (seconds < 10)
                    {
                        label_amountOfSeconds.Text = "0" + seconds.ToString();
                    }
                    else
                    {
                        label_amountOfSeconds.Text = seconds.ToString();
                    }
                }
                else
                {
                    if (minutes < 59)
                    {

                        minutes++;
                        if (minutes < 10)
                        {
                            label_amountOfMinutes.Text = "0" + minutes.ToString();
                        }
                        else
                        {
                            label_amountOfMinutes.Text = minutes.ToString();
                        }
                        seconds = 0;
                        label_amountOfSeconds.Text = "00";
                    }
                    else
                    {
                        minutes = 0;
                        label_amountOfMinutes.Text = "00";
                    }
                }
            }
            else
            {
                gameTimer.Enabled = false;
                ButtonExtended button = new ButtonExtended();
                Explode(button);
                
                
            }
        }
        void ClickOnСell(object sender, MouseEventArgs e)
        {
            gameTimer.Enabled = true;
            ButtonExtended button = (ButtonExtended)sender;
            LeftClick(e, button);
            RightClick(e, button);
            DisplayingBombs();
            DisplayingAllEmptyCells();
            RegistrationOfVictory();
        }
        private void LeftClick(MouseEventArgs e, ButtonExtended button)
        {
            if (e.Button == MouseButtons.Left && button.isFlag)
            {
                if (firstclick)
                {
                    if (button.isBomb)
                    {
                        button.isBomb = false;
                        amountOfBombs--;
                       // registrationFirstClickBomb = true;
                    }
                    firstclick = false;
                }
                if (button.isBomb)
                {
                    Explode(button);
                }
                else
                {
                    EmptyСell(button);
                }
            }
        }
        private static void RightClick(MouseEventArgs e, ButtonExtended button)
        {
            if (e.Button == MouseButtons.Right && !button.isOpen)
            {
                button.isFlag = !button.isFlag;
                if (!button.isFlag)
                {
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\flag.png");
                }
                else
                {
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\back.png");
                }
            }
        }

        void OpenRegion(int index_x , int index_y , ButtonExtended button)
        {
            Queue<ButtonExtended> queue = new Queue<ButtonExtended>();
            queue.Enqueue(button);
            button.isOpen = true;
            while (queue.Count > 0)
            {
                ButtonExtended currectСell = queue.Dequeue();
                OpenCell(currectСell.x_currectCell, currectСell.y_currectCell, currectСell);
                ShowImageInsteadOfNumbers(currectСell.x_currectCell, currectСell.y_currectCell, currectСell);
                if (CountBombsAround(currectСell.x_currectCell, currectСell.y_currectCell) == 0)
                {
                    for (int x = currectСell.x_currectCell - 1; x <= currectСell.x_currectCell + 1; x++)
                    {
                        for (int y = currectСell.y_currectCell - 1; y <= currectСell.y_currectCell + 1; y++)
                        {
                            if (x == currectСell.x_currectCell && y == currectСell.y_currectCell)
                            {
                                continue;
                            }    
                            if (x >= 0 && x < sizeFieldInCells && y >= 0 && y < sizeFieldInCells)
                            {
                                if (!allButtons[x, y].isOpen)
                                {
                                    queue.Enqueue(allButtons[x, y]);
                                    allButtons[x, y].isOpen = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        void OpenCell(int index_x, int index_y, ButtonExtended button)
        {
            if (button.wasСlicked == false)
            {
                amountOfOpenedСells++;
                DisplayingOpenedCells();
                button.wasСlicked = true;
            }
            int bombcount = CountBombsAround(index_x , index_y );
            if (button.isOpen)
            {
                ShowImageInsteadOfNumbers(index_x, index_y, button);
            }
        }
        void Explode(ButtonExtended button)
        {
            ShowBombs();
            Losing checkLoser = new Losing();
            checkLoser.ShowDialog();
            gameTimer.Enabled = false;
        }
        void EmptyСell(ButtonExtended button)
        {
            for (int i = 0; i < sizeFieldInCells; i++)
            {
                for (int j = 0; j < sizeFieldInCells; j++)
                {
                    if (allButtons[i, j] == button)
                    {
                        OpenRegion(i, j, button);
                    }
                }
            }
        }
        int CountBombsAround(int index_x , int index_y)
        {
            int bombcount = 0;
            for (int x = index_x - 1; x <= index_x + 1; x++)
            {
                for (int y = index_y - 1; y <= index_y + 1; y++)
                {
                    if (x >= 0 && x < sizeFieldInCells && y >= 0 && y < sizeFieldInCells)
                    {
                        if (allButtons[x, y].isBomb)
                        {
                            bombcount++;
                        }
                    }
                }
            }
            return bombcount;
        }
        
        void ShowImageInsteadOfNumbers(int index_x, int index_y, ButtonExtended button)
        {
            if (!button.isBomb)
            {
                if (CountBombsAround(index_x, index_y) == 0)
                {
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\whiteBackground.png");
                }
                if (CountBombsAround(index_x, index_y) == 1)
                {
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\1.png");
                }
                if (CountBombsAround(index_x, index_y) == 2)
                {
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\2.png");
                }
                if (CountBombsAround(index_x, index_y) == 3)
                {
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\3.png");
                }
                if (CountBombsAround(index_x, index_y) == 4)
                {
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\4.png");
                }
                if (CountBombsAround(index_x, index_y) == 5)
                {
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\5.png");
                }
                if (CountBombsAround(index_x, index_y) == 6)
                {
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\6.png");
                }
                if (CountBombsAround(index_x, index_y) == 7)
                {
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\7.png");
                }
                if (CountBombsAround(index_x, index_y) == 8)
                {
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\8.png");
                }
            }
        }
        
        void RegistrationOfVictory()
        {
            int cells = sizeFieldInCells * sizeFieldInCells;
            int allEmptyCells = cells - amountOfBombs;
            DisplayingAllEmptyCells();
            if (allEmptyCells == amountOfOpenedСells)
            {
                ShowBombs();
                gameTimer.Enabled = false;
                Victory checkVictory = new Victory();
                checkVictory.ShowDialog();
            }

        }
        private void ShowBombs()
        {
            foreach (ButtonExtended item in allButtons)
            {
                if (item.isBomb)
                {
                    item.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\bomb.png");
                }
            }
        }

        private void bt__Size9x9_Click(object sender, EventArgs e)
        {
            Application.Restart();
            fieldWidth = 270;
            fieldHeight = 270;
            sizeFieldInCells = 9;
            timeLimitInMminutes = 10;
            CreateGame();
        }//To DO
        private void bt__Size18x18_Click(object sender, EventArgs e)
        {
            Application.Restart();
            fieldWidth = 540;
            fieldHeight = 540;
            sizeFieldInCells = 18;
            timeLimitInMminutes = 40;
            CreateGame();

        }//To Do
        private void bt__Size36x36_Click(object sender, EventArgs e)
        {
            Application.Restart();
            fieldWidth = 1080;
            fieldHeight = 1080;
            sizeFieldInCells = 36;
            timeLimitInMminutes = 99;
            CreateGame();
        }//To DO
        private void bt_menu_game_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bt_aboutGame_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }
    }

    public partial class ButtonExtended : Button
    {
        public bool isBomb; 
        public bool isFlag;
        public bool isOpen;
        public int x_currectCell;
        public int y_currectCell;
        public bool wasСlicked;
    }
}
