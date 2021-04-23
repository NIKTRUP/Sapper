using System.IO;
using System.Threading;
using System;
using System.Media;
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
        int cellWidth = 50, cellHeight = 50, changeLocation = 50;
        int bombCreationProbability = 20;
        int start_x = 10, start_y = 50;
        ButtonExtended[,] allButtons;
        SoundPlayer musicLoad;
        SoundPlayer musicLose;
        SoundPlayer musicWin;
        HighScoreTableForm tableHighScore = new HighScoreTableForm();
        bool musicScwitch = true;


        // изменяемые компьютером
        int amountOfOpenedСells = 0, amountOfBombs = 0;
        int seconds, minutes;
        bool firstclick = true;

        // изменяемые человеком
        int fieldWidth, fieldHeight;
        int sizeFieldInCells ;
        int timeLimitInMminutes ;

        public Sapper()
        {
            InitializeComponent();
            gameTimer.Interval = 1000;
            seconds = 0;
            minutes = 0;
            label_amountOfSeconds.Text = "00";
            label_amountOfMinutes.Text = "00";
            ReadHighScore();
            //ThreadStart timer = new ThreadStart(gameTimer_Tick);
        }
        private void Init(int fieldWidth, int fieldHeight, int sizeFieldInCells, int timeLimitInMminutes)
        {
            this.fieldWidth = fieldWidth;
            this.fieldHeight = fieldHeight;
            this.sizeFieldInCells = sizeFieldInCells;
            this.timeLimitInMminutes = timeLimitInMminutes;
        }
        private void Sapper_Load(object sender, EventArgs e)
        {
            musicLoad = new SoundPlayer(@"C:\\Users\\nikol\\source\\repos\\Sapper\\Music\\guitar.wav");
            StartMusicLoad();
            Init(450, 450, 9, 10);
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
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\backGround.png");
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
                Explode();
                
                
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
                    }
                    firstclick = false;
                }
                if (button.isBomb)
                {
                    Explode();
                }
                else
                {
                    EmptyСell(button);
                }
            }
        }
        private void RightClick(MouseEventArgs e, ButtonExtended button)
        {
            if (e.Button == MouseButtons.Right && !button.isOpen)
            {
                button.isFlag = !button.isFlag;
                if (!button.isFlag)
                {
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\flag.png");
                }
                else if (!button.isQuestion)
                {
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\question.png");
                    button.isQuestion = !button.isQuestion;
                    button.isFlag = false;
                }
                else if(button.isQuestion)
                {
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\backGround.png");
                    button.isQuestion = !button.isQuestion;
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
        void Explode()
        {
            ShowBombs();
            StartMusicLose();
            gameTimer.Enabled = false;
            SaveHighScore(label_amountOfMinutes.Text , label_amountOfSeconds.Text);
            Losing checkLoser = new Losing();
            checkLoser.ShowDialog();
        }
        private void StartMusicLose()
        {
            musicLose = new SoundPlayer(@"C:\\Users\\nikol\\source\\repos\\Sapper\\Music\\lose.wav");
            if (musicScwitch)
            {
                musicLose.Play();
            }
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
                    button.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\whiteBackground2.png");
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
                StartMusicWin();
                gameTimer.Enabled = false;
                SaveHighScore(label_amountOfMinutes.Text, label_amountOfSeconds.Text);
                Victory checkVictory = new Victory();
                checkVictory.ShowDialog();
            }

        }
        
        private void SaveHighScore(object minutes , object seconds)
        {
            string time = minutes.ToString()+ ":" + seconds.ToString();
            tableHighScore.ListBox_HighScoreTable.Items.Add(time);
        }
        

        private void StartMusicWin()
        {
            musicWin = new SoundPlayer(@"C:\\Users\\nikol\\source\\repos\\Sapper\\Music\\win.wav");
            if (musicScwitch)
            {
                musicWin.Play();
            }
        }
        private void ShowBombs()
        {
            foreach (ButtonExtended item in allButtons)
            {
                if (item.isBomb)
                {
                    item.Image = Image.FromFile("C:\\Users\\nikol\\source\\repos\\Sapper\\Images\\navalMine.png");
                }
            }
        }
        private void bt_musicSwitch_Click(object sender, EventArgs e)
        {
            if (musicScwitch)
            {
                musicScwitch = false;
                bt_musicSwitch.Text = "Включить музыку";
            }
            else 
            {
                musicScwitch = true;
                bt_musicSwitch.Text = "Выключить музыку";
            }
        }
        private void ClearMap()
        {
            amountOfOpenedСells = 0;
            amountOfBombs = 0;
            foreach (ButtonExtended item in allButtons)
            {
                if (Controls.Contains(item))
                {
                    Controls.Remove(item);
                }
            }
        }
        private void bt__Size9x9_Click(object sender, EventArgs e)
        {
            ClearMap();
            StartMusicLoad();
            firstclick = true;
            Init(270, 270, 9, 10);
            CreateGame();
            DisplayingBombs();
            DisplayingAllEmptyCells();
            DisplayingOpenedCells();
        }//To DO
        private void bt__Size18x18_Click(object sender, EventArgs e)
        {
            ClearMap();
            StartMusicLoad();
            firstclick = true;
            Init(900, 900, 18, 40);
            CreateGame();
            DisplayingBombs();
            DisplayingAllEmptyCells();
            DisplayingOpenedCells();

        }
        private void bt__Size36x36_Click(object sender, EventArgs e)
        {
            ClearMap();
            StartMusicLoad();
            firstclick = true;
            Init(1800, 1800, 36, 99);
            CreateGame();
            DisplayingBombs();
            DisplayingAllEmptyCells();
            DisplayingOpenedCells();
        }
        private void bt_menu_game_HighScore_Click(object sender, EventArgs e)
        {
            tableHighScore.Visible = true;
        }
        private void StartMusicLoad()
        {
            if (musicScwitch)
            {
                musicLoad.Play();
            }
        }
        private void bt_menu_game_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bt_aboutGame_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }
        private void SetHighScore()
        {
            
            StreamWriter writer = new StreamWriter("HighScore.txt");
            foreach (string item in tableHighScore.ListBox_HighScoreTable.Items)
            {
                if ( (sizeFieldInCells * sizeFieldInCells - amountOfBombs) == amountOfOpenedСells)
                { 
                writer.Write(item+"\n");
                }
                else 
                {
                    writer.Write(item+"\n");
                }
            }
            writer.Close();
        }
        private void ReadHighScore()
        {
            StreamReader readerHighScore = new StreamReader("HighScore.txt");
            string fileString = readerHighScore.ReadToEnd();
            string[] fileData = fileString.Split('\n');
            for (int i = 0; i < fileData.Length; i++)
            {
                tableHighScore.ListBox_HighScoreTable.Items.Add(fileData[i]);
            }
            readerHighScore.Close();
        }
        
        private void Sapper_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetHighScore();
        }

    }

    public partial class ButtonExtended : Button
    {
        public bool isBomb; 
        public bool isFlag;
        public bool isQuestion;
        public bool isOpen;
        public int x_currectCell;
        public int y_currectCell;
        public bool wasСlicked;
    }
}
