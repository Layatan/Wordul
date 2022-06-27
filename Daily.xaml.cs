using Xamarin.Forms;
using System;
using System.IO;

namespace Wordul
{
    public partial class Daily : ContentPage
    {
        public int y = 0;
        public int x = 0;
        public string[,] boardCell = new string[4, 5];
        public string ans = "DRAWS";
        public string[] WordsList;// = File.ReadAllLines("FullWordsList.txt");
        public Daily()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this,false);
            WordsList = File.ReadAllLines("FullWordsList.txt");
            //Random Rnd = new Random(); //abdoulaye 
            //ans = WordsList[Rnd.Next(0, WordsList.Length + 1)];
            //Console.WriteLine(ans);

        }

        public void Changer(string input)
        {
            if (x > 4) return;

            boardCell[y, x] = input; x++;

            UpdateBoard();
        }

        public void AnsVerify()
        {
            int score = 0;
            if (x != 5) return;
            Label[,] Lines = new Label[,] {
                {Slot1, Slot2, Slot3, Slot4, Slot5},
                {Slot6, Slot7, Slot8, Slot9, Slot10 },
                {Slot11, Slot12, Slot13, Slot14, Slot15},
                {Slot16, Slot17, Slot18, Slot19, Slot20},
            };

            for (int i = 0; i < 5; i++)
            {
                if (ans.Substring(i, 1) == Lines[y, i].Text)
                {
                    Lines[y, i].BackgroundColor = Color.Green;
                    score++;
                }
                else if (ans.Contains(Lines[y, i].Text))
                {
                    Lines[y, i].BackgroundColor = Color.Yellow;
                }
            }

            if (score == 5)
            {
                DisplayAlert("You Win", "You successfully guessed the word " + ans + " in try " + (y + 1) + " :)", "Nice");
                return;
            }
            else if (score < 5 && y == 3)
            {
                DisplayAlert("You Lose", "Soz but the word was " + ans + " :(", "Sad");
                return;
            }

            x = 0; y++;
        }

        public void UpdateBoard()
        {
            if (y == 0)
            {
                Slot1.Text = boardCell[0, 0];
                Slot2.Text = boardCell[0, 1];
                Slot3.Text = boardCell[0, 2];
                Slot4.Text = boardCell[0, 3];
                Slot5.Text = boardCell[0, 4];
            }

            else if (y == 1)
            {
                Slot6.Text = boardCell[1, 0];
                Slot7.Text = boardCell[1, 1];
                Slot8.Text = boardCell[1, 2];
                Slot9.Text = boardCell[1, 3];
                Slot10.Text = boardCell[1, 4];
            }

            else if (y == 2)
            {
                Slot11.Text = boardCell[2, 0];
                Slot12.Text = boardCell[2, 1];
                Slot13.Text = boardCell[2, 2];
                Slot14.Text = boardCell[2, 3];
                Slot15.Text = boardCell[2, 4];
            }

            else if (y == 3)
            {
                Slot16.Text = boardCell[3, 0];
                Slot17.Text = boardCell[3, 1];
                Slot18.Text = boardCell[3, 2];
                Slot19.Text = boardCell[3, 3];
                Slot20.Text = boardCell[3, 4];
            }



        }

        private void Q_Clicked(object sender, EventArgs e)
        {
            Changer("Q");
        }

        private void W_Clicked(object sender, EventArgs e)
        {
            Changer("W");
        }

        private void E_Clicked(object sender, EventArgs e)
        {
            Changer("E");
        }

        private void R_Clicked(object sender, EventArgs e)
        {
            Changer("R");
        }

        private void T_Clicked(object sender, EventArgs e)
        {
            Changer("T");
        }

        private void Y_Clicked(object sender, EventArgs e)
        {
            Changer("Y");
        }

        private void U_Clicked(object sender, EventArgs e)
        {
            Changer("U");
        }

        private void I_Clicked(object sender, EventArgs e)
        {
            Changer("I");
        }

        private void O_Clicked(object sender, EventArgs e)
        {
            Changer("O");
        }

        private void P_Clicked(object sender, EventArgs e)
        {
            Changer("P");
        }

        private void A_Clicked(object sender, EventArgs e)
        {
            Changer("A");
        }

        private void S_Clicked(object sender, EventArgs e)
        {
            Changer("S");
        }

        private void D_Clicked(object sender, EventArgs e)
        {
            Changer("D");
        }

        private void F_Clicked(object sender, EventArgs e)
        {
            Changer("F");
        }

        private void G_Clicked(object sender, EventArgs e)
        {
            Changer("G");
        }

        private void H_Clicked(object sender, EventArgs e)
        {
            Changer("H");
        }

        private void J_Clicked(object sender, EventArgs e)
        {
            Changer("J");
        }

        private void K_Clicked(object sender, EventArgs e)
        {
            Changer("K");
        }

        private void L_Clicked(object sender, EventArgs e)
        {
            Changer("L");
        }

        private void Z_Clicked(object sender, EventArgs e)
        {
            Changer("Z");
        }

        private void X_Clicked(object sender, EventArgs e)
        {
            Changer("X");
        }

        private void C_Clicked(object sender, EventArgs e)
        {
            Changer("C");
        }

        private void V_Clicked(object sender, EventArgs e)
        {
            Changer("V");
        }

        private void B_Clicked(object sender, EventArgs e)
        {
            Changer("B");
        }

        private void N_Clicked(object sender, EventArgs e)
        {
            Changer("N");
        }

        private void M_Clicked(object sender, EventArgs e)
        {
            Changer("M");
        }

        private void Erase_Clicked(object sender, EventArgs e)
        {
            if (x == 0) return;

            x--;
            boardCell[y, x] = "";
            UpdateBoard();
        }

        private void Enter_Clicked(object sender, EventArgs e)
        {
            AnsVerify();
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}