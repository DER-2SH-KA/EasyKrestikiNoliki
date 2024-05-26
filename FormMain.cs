using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyKrestikiNoliki
{
    public partial class FormMain : Form
    {
        private int player = 0;
        private List<Button> buttonsList = new List<Button>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.BackColor = Design.DarkWhite;
            this.MaximizeBox = false;

            Design.setLabelDesign(labelfaut, Design.DarkGray, Design.Font18ptBold);
            panelField.BackColor = Design.LightGray;

            int standartX = 0;
            int standartY = 0;

            for (int i = 0; i < 9; i++)
            {
                Button btn = new Button();
                btn.Text = "";
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Font = Design.Font16ptBold;
                btn.Click += new EventHandler(this.button_Clicked);

                btn.Width = Convert.ToInt32(panelField.Width / 3);
                btn.Height = Convert.ToInt32(panelField.Height / 3);

                panelField.Controls.Add(btn);

                if (i + 1 == 4 || i + 1 == 7)
                {
                    standartY += btn.Height;
                    standartX = 0;
                }
                btn.Location = new Point(standartX, standartY);
                standartX += btn.Width;

                buttonsList.Add(btn);
            }

            Design.setButtonDesign(buttonReset, Design.DarkGray, Design.LightGray, Design.Font14pt);

            Design.setLabelDesign(labelCurrPlayer, Design.Gray, Design.Font16pt);
            RePaintLabelCurrPlayer();

        }

        private void button_Clicked(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;

            if (thisButton.Enabled == true)
            {
                switch (player)
                {
                    case 0:
                        thisButton.Text = "X";
                        thisButton.Enabled = false;
                        player = 1;
                        break;

                    case 1:
                        thisButton.Text = "O";
                        thisButton.Enabled = false;
                        player = 0;
                        break;
                }
            }
            CheckWin();
            RePaintLabelCurrPlayer();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Resett();
        }

        private void Resett()
        {
            foreach (Button btn in buttonsList)
            {
                btn.Text = "";
                btn.Enabled = true;
            }
            player = 0;
        }

        private void RePaintLabelCurrPlayer()
        {
            if (player == 0)
            {
                labelCurrPlayer.Text = "Ходит игрок: Первый (Крестик)";
            }
            else
            {
                labelCurrPlayer.Text = "Ходит игрок: Второй (Нолик)";
            }

            labelCurrPlayer.Location = new Point(20, 400);
        }

        private void CheckWin()
        {
            int[] cells = new int[9];
            int winner = -1;
            int countOfNulls = 0;

            for (int i = 0; i < buttonsList.Count; i++)
            {
                if (buttonsList[i].Text == "X")
                {
                    cells[i] = 1;
                }
                else if (buttonsList[i].Text == "O")
                {
                    cells[i] = 2;
                }
                else
                {
                    cells[i] = 0;
                    countOfNulls++;
                }
            }

            if (cells[0] != 0 && cells[0] == cells[1] && cells[1] == cells[2])
            {
                if (cells[0] == 1) winner = 0;
                else winner = 1;
            }
            else if (cells[3] != 0 && cells[3] == cells[4] && cells[4] == cells[5])
            {
                if (cells[3] == 1) winner = 0;
                else winner = 1;
            }
            else if (cells[6] != 0 && cells[6] == cells[7] && cells[7] == cells[8])
            {
                if (cells[6] == 1) winner = 0;
                else winner = 1;
            }

            else if (cells[0] != 0 && cells[0] == cells[3] && cells[3] == cells[6])
            {
                if (cells[0] == 1) winner = 0;
                else winner = 1;
            }
            else if (cells[1] != 0 && cells[1] == cells[4] && cells[4] == cells[7])
            {
                if (cells[1] == 1) winner = 0;
                else winner = 1;
            }
            else if (cells[2] != 0 && cells[2] == cells[5] && cells[5] == cells[8])
            {
                if (cells[2] == 1) winner = 0;
                else winner = 1;
            }

            else if (cells[0] != 0 && cells[0] == cells[4] && cells[4] == cells[8])
            {
                if (cells[0] == 1) winner = 0;
                else winner = 1;
            }
            else if (cells[2] != 0 && cells[2] == cells[4] && cells[4] == cells[6])
            {
                if (cells[2] == 1) winner = 0;
                else winner = 1;
            }
            
            if (winner == 0)
            {
                MessageBox.Show("Победил Первый игрок (Крестик)!", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Resett();
            }
            else if (winner == 1)
            {
                MessageBox.Show("Победил Второй игрок (Нолик)!", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Resett();
            }
            else if (winner == -1 && countOfNulls == 0)
            {
                MessageBox.Show("Ничья!", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Resett();
            }
        }
    }
    // this.button1.Click += new System.EventHandler(this.button1_Click);
}
