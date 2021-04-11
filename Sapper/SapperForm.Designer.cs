
namespace Sapper
{
    partial class Sapper
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.bt_menu_game = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_menu_game_NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.bt__Size9x9 = new System.Windows.Forms.ToolStripMenuItem();
            this.bt__Size18x18 = new System.Windows.Forms.ToolStripMenuItem();
            this.bt__Size36x36 = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_menu_game_ResultsTable = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_menu_game_HightScore = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_menu_game_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_musicSwitch = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_reference = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_aboutGame = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_general = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_bombs = new System.Windows.Forms.Label();
            this.label_amountOfBombs = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.panel_time = new System.Windows.Forms.Panel();
            this.label_amountOfSeconds = new System.Windows.Forms.Label();
            this.label_colon = new System.Windows.Forms.Label();
            this.label_amountOfMinutes = new System.Windows.Forms.Label();
            this.panel_bombs = new System.Windows.Forms.Panel();
            this.label_allEmptyCells = new System.Windows.Forms.Label();
            this.label_fraction = new System.Windows.Forms.Label();
            this.label_OpenedCells = new System.Windows.Forms.Label();
            this.label_amountOfOpenedCells = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel_Header.SuspendLayout();
            this.Menu.SuspendLayout();
            this.panel_general.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_time.SuspendLayout();
            this.panel_bombs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.Controls.Add(this.Menu);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(529, 25);
            this.panel_Header.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_menu_game,
            this.bt_reference,
            this.bt_aboutGame});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(529, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // bt_menu_game
            // 
            this.bt_menu_game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_menu_game_NewGame,
            this.bt_menu_game_ResultsTable,
            this.bt_menu_game_HightScore,
            this.bt_menu_game_Exit,
            this.bt_musicSwitch});
            this.bt_menu_game.Name = "bt_menu_game";
            this.bt_menu_game.Size = new System.Drawing.Size(46, 20);
            this.bt_menu_game.Text = "Игра";
            // 
            // bt_menu_game_NewGame
            // 
            this.bt_menu_game_NewGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt__Size9x9,
            this.bt__Size18x18,
            this.bt__Size36x36});
            this.bt_menu_game_NewGame.Name = "bt_menu_game_NewGame";
            this.bt_menu_game_NewGame.Size = new System.Drawing.Size(189, 22);
            this.bt_menu_game_NewGame.Text = "Новая игра";
            // 
            // bt__Size9x9
            // 
            this.bt__Size9x9.Name = "bt__Size9x9";
            this.bt__Size9x9.Size = new System.Drawing.Size(177, 22);
            this.bt__Size9x9.Text = "Размер поля:9x9";
            this.bt__Size9x9.Click += new System.EventHandler(this.bt__Size9x9_Click);
            // 
            // bt__Size18x18
            // 
            this.bt__Size18x18.Name = "bt__Size18x18";
            this.bt__Size18x18.Size = new System.Drawing.Size(177, 22);
            this.bt__Size18x18.Text = "Размер поля:18x18";
            this.bt__Size18x18.Click += new System.EventHandler(this.bt__Size18x18_Click);
            // 
            // bt__Size36x36
            // 
            this.bt__Size36x36.Name = "bt__Size36x36";
            this.bt__Size36x36.Size = new System.Drawing.Size(177, 22);
            this.bt__Size36x36.Text = "Размер поля:36x36";
            this.bt__Size36x36.Click += new System.EventHandler(this.bt__Size36x36_Click);
            // 
            // bt_menu_game_ResultsTable
            // 
            this.bt_menu_game_ResultsTable.Name = "bt_menu_game_ResultsTable";
            this.bt_menu_game_ResultsTable.Size = new System.Drawing.Size(189, 22);
            this.bt_menu_game_ResultsTable.Text = "Таблица результатов";
            // 
            // bt_menu_game_HightScore
            // 
            this.bt_menu_game_HightScore.Name = "bt_menu_game_HightScore";
            this.bt_menu_game_HightScore.Size = new System.Drawing.Size(189, 22);
            this.bt_menu_game_HightScore.Text = "Рекорды";
            // 
            // bt_menu_game_Exit
            // 
            this.bt_menu_game_Exit.Name = "bt_menu_game_Exit";
            this.bt_menu_game_Exit.Size = new System.Drawing.Size(189, 22);
            this.bt_menu_game_Exit.Text = "Выйти";
            this.bt_menu_game_Exit.Click += new System.EventHandler(this.bt_menu_game_Exit_Click);
            // 
            // bt_musicSwitch
            // 
            this.bt_musicSwitch.Name = "bt_musicSwitch";
            this.bt_musicSwitch.Size = new System.Drawing.Size(189, 22);
            this.bt_musicSwitch.Text = "Выключить музыку";
            this.bt_musicSwitch.Click += new System.EventHandler(this.bt_musicSwitch_Click);
            // 
            // bt_reference
            // 
            this.bt_reference.Name = "bt_reference";
            this.bt_reference.Size = new System.Drawing.Size(65, 20);
            this.bt_reference.Text = "Справка";
            // 
            // bt_aboutGame
            // 
            this.bt_aboutGame.Name = "bt_aboutGame";
            this.bt_aboutGame.Size = new System.Drawing.Size(63, 20);
            this.bt_aboutGame.Text = "Об игре";
            this.bt_aboutGame.Click += new System.EventHandler(this.bt_aboutGame_Click);
            // 
            // panel_general
            // 
            this.panel_general.Controls.Add(this.panel1);
            this.panel_general.Controls.Add(this.label_Time);
            this.panel_general.Controls.Add(this.panel_time);
            this.panel_general.Controls.Add(this.panel_bombs);
            this.panel_general.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_general.Location = new System.Drawing.Point(0, 25);
            this.panel_general.Name = "panel_general";
            this.panel_general.Size = new System.Drawing.Size(529, 15);
            this.panel_general.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_bombs);
            this.panel1.Controls.Add(this.label_amountOfBombs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(215, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 15);
            this.panel1.TabIndex = 3;
            // 
            // label_bombs
            // 
            this.label_bombs.AutoSize = true;
            this.label_bombs.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_bombs.Location = new System.Drawing.Point(98, 0);
            this.label_bombs.Name = "label_bombs";
            this.label_bombs.Size = new System.Drawing.Size(19, 13);
            this.label_bombs.TabIndex = 1;
            this.label_bombs.Text = "00";
            // 
            // label_amountOfBombs
            // 
            this.label_amountOfBombs.AutoSize = true;
            this.label_amountOfBombs.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_amountOfBombs.Location = new System.Drawing.Point(0, 0);
            this.label_amountOfBombs.Name = "label_amountOfBombs";
            this.label_amountOfBombs.Size = new System.Drawing.Size(98, 13);
            this.label_amountOfBombs.TabIndex = 0;
            this.label_amountOfBombs.Text = "Количество бомб:";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(338, 0);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(43, 13);
            this.label_Time.TabIndex = 2;
            this.label_Time.Text = "Время:";
            // 
            // panel_time
            // 
            this.panel_time.Controls.Add(this.label_amountOfSeconds);
            this.panel_time.Controls.Add(this.label_colon);
            this.panel_time.Controls.Add(this.label_amountOfMinutes);
            this.panel_time.Location = new System.Drawing.Point(378, 0);
            this.panel_time.Name = "panel_time";
            this.panel_time.Size = new System.Drawing.Size(51, 15);
            this.panel_time.TabIndex = 1;
            // 
            // label_amountOfSeconds
            // 
            this.label_amountOfSeconds.AutoSize = true;
            this.label_amountOfSeconds.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_amountOfSeconds.Location = new System.Drawing.Point(29, 0);
            this.label_amountOfSeconds.Name = "label_amountOfSeconds";
            this.label_amountOfSeconds.Size = new System.Drawing.Size(19, 13);
            this.label_amountOfSeconds.TabIndex = 4;
            this.label_amountOfSeconds.Text = "00";
            this.label_amountOfSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_colon
            // 
            this.label_colon.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label_colon.AutoSize = true;
            this.label_colon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_colon.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_colon.Location = new System.Drawing.Point(19, 0);
            this.label_colon.Name = "label_colon";
            this.label_colon.Size = new System.Drawing.Size(10, 13);
            this.label_colon.TabIndex = 3;
            this.label_colon.Text = ":";
            // 
            // label_amountOfMinutes
            // 
            this.label_amountOfMinutes.AutoSize = true;
            this.label_amountOfMinutes.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_amountOfMinutes.Location = new System.Drawing.Point(0, 0);
            this.label_amountOfMinutes.Name = "label_amountOfMinutes";
            this.label_amountOfMinutes.Size = new System.Drawing.Size(19, 13);
            this.label_amountOfMinutes.TabIndex = 2;
            this.label_amountOfMinutes.Text = "00";
            this.label_amountOfMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_bombs
            // 
            this.panel_bombs.Controls.Add(this.label_allEmptyCells);
            this.panel_bombs.Controls.Add(this.label_fraction);
            this.panel_bombs.Controls.Add(this.label_OpenedCells);
            this.panel_bombs.Controls.Add(this.label_amountOfOpenedCells);
            this.panel_bombs.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_bombs.Location = new System.Drawing.Point(0, 0);
            this.panel_bombs.Name = "panel_bombs";
            this.panel_bombs.Size = new System.Drawing.Size(215, 15);
            this.panel_bombs.TabIndex = 0;
            // 
            // label_allEmptyCells
            // 
            this.label_allEmptyCells.AutoSize = true;
            this.label_allEmptyCells.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_allEmptyCells.Location = new System.Drawing.Point(190, 0);
            this.label_allEmptyCells.Name = "label_allEmptyCells";
            this.label_allEmptyCells.Size = new System.Drawing.Size(19, 13);
            this.label_allEmptyCells.TabIndex = 3;
            this.label_allEmptyCells.Text = "00";
            // 
            // label_fraction
            // 
            this.label_fraction.AutoSize = true;
            this.label_fraction.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_fraction.Location = new System.Drawing.Point(178, 0);
            this.label_fraction.Name = "label_fraction";
            this.label_fraction.Size = new System.Drawing.Size(12, 13);
            this.label_fraction.TabIndex = 2;
            this.label_fraction.Text = "/";
            // 
            // label_OpenedCells
            // 
            this.label_OpenedCells.AutoSize = true;
            this.label_OpenedCells.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_OpenedCells.Location = new System.Drawing.Point(159, 0);
            this.label_OpenedCells.Name = "label_OpenedCells";
            this.label_OpenedCells.Size = new System.Drawing.Size(19, 13);
            this.label_OpenedCells.TabIndex = 1;
            this.label_OpenedCells.Text = "00";
            // 
            // label_amountOfOpenedCells
            // 
            this.label_amountOfOpenedCells.AutoSize = true;
            this.label_amountOfOpenedCells.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_amountOfOpenedCells.Location = new System.Drawing.Point(0, 0);
            this.label_amountOfOpenedCells.Name = "label_amountOfOpenedCells";
            this.label_amountOfOpenedCells.Size = new System.Drawing.Size(159, 13);
            this.label_amountOfOpenedCells.TabIndex = 0;
            this.label_amountOfOpenedCells.Text = "Количество открытых клеток:";
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Sapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 391);
            this.Controls.Add(this.panel_general);
            this.Controls.Add(this.panel_Header);
            this.Name = "Sapper";
            this.Text = "Sapper";
            this.Load += new System.EventHandler(this.Sapper_Load);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panel_general.ResumeLayout(false);
            this.panel_general.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_time.ResumeLayout(false);
            this.panel_time.PerformLayout();
            this.panel_bombs.ResumeLayout(false);
            this.panel_bombs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem bt_menu_game;
        private System.Windows.Forms.ToolStripMenuItem bt_menu_game_NewGame;
        private System.Windows.Forms.ToolStripMenuItem bt__Size9x9;
        private System.Windows.Forms.ToolStripMenuItem bt__Size18x18;
        private System.Windows.Forms.ToolStripMenuItem bt__Size36x36;
        private System.Windows.Forms.ToolStripMenuItem bt_menu_game_ResultsTable;
        private System.Windows.Forms.ToolStripMenuItem bt_menu_game_HightScore;
        private System.Windows.Forms.ToolStripMenuItem bt_menu_game_Exit;
        private System.Windows.Forms.ToolStripMenuItem bt_reference;
        private System.Windows.Forms.ToolStripMenuItem bt_aboutGame;
        private System.Windows.Forms.Panel panel_general;
        private System.Windows.Forms.Panel panel_time;
        private System.Windows.Forms.Panel panel_bombs;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label_amountOfMinutes;
        private System.Windows.Forms.Label label_colon;
        private System.Windows.Forms.Label label_amountOfSeconds;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_allEmptyCells;
        private System.Windows.Forms.Label label_fraction;
        private System.Windows.Forms.Label label_OpenedCells;
        private System.Windows.Forms.Label label_amountOfOpenedCells;
        private System.Windows.Forms.Label label_bombs;
        private System.Windows.Forms.Label label_amountOfBombs;
        private System.Windows.Forms.ToolStripMenuItem bt_musicSwitch;
    }
}

