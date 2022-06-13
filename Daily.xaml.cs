using Xamarin.Forms;

namespace Wordul
{
    public partial class Daily : ContentPage
    {
        public int y = 0;
        public int x = 0;
        public string[,] boardCell = new string[4, 5];
        public string ans = "STRAW";

        public Daily()
        {
            InitializeComponent();

        }

        public void Changer(string input)
        {
            if (x > 4)
            {
                return;
            }

            boardCell[y, x] = input; x++;

            Slot1.Text = boardCell[0, 0];
            Slot2.Text = boardCell[0, 1];
            Slot3.Text = boardCell[0, 2];
            Slot4.Text = boardCell[0, 3];
            Slot5.Text = boardCell[0, 4];

            Slot6.Text = boardCell[1, 0];
            Slot7.Text = boardCell[1, 1];
            Slot8.Text = boardCell[1, 2];
            Slot9.Text = boardCell[1, 3];
            Slot10.Text = boardCell[1, 4];

            Slot11.Text = boardCell[2, 0];
            Slot12.Text = boardCell[2, 1];
            Slot13.Text = boardCell[2, 2];
            Slot14.Text = boardCell[2, 3];
            Slot15.Text = boardCell[2, 4];

            Slot16.Text = boardCell[3, 0];
            Slot17.Text = boardCell[3, 1];
            Slot18.Text = boardCell[3, 2];
            Slot19.Text = boardCell[3, 3];
            Slot20.Text = boardCell[3, 4];
        }

        private void Clear_Clicked(object sender, System.EventArgs e)
        {
            x = 4;
            for (int i = 0; i < 5; i++)
            {
                boardCell[y, x] = "";
                x--;
            }
            x = 0;

            Slot1.Text = boardCell[0, 0];
            Slot2.Text = boardCell[0, 1];
            Slot3.Text = boardCell[0, 2];
            Slot4.Text = boardCell[0, 3];
            Slot5.Text = boardCell[0, 4];

            Slot6.Text = boardCell[1, 0];
            Slot7.Text = boardCell[1, 1];
            Slot8.Text = boardCell[1, 2];
            Slot9.Text = boardCell[1, 3];
            Slot10.Text = boardCell[1, 4];

            Slot11.Text = boardCell[2, 0];
            Slot12.Text = boardCell[2, 1];
            Slot13.Text = boardCell[2, 2];
            Slot14.Text = boardCell[2, 3];
            Slot15.Text = boardCell[2, 4];

            Slot16.Text = boardCell[3, 0];
            Slot17.Text = boardCell[3, 1];
            Slot18.Text = boardCell[3, 2];
            Slot19.Text = boardCell[3, 3];
            Slot20.Text = boardCell[3, 4];
        }
        private void Enter_Clicked(object sender, System.EventArgs e)
        {
            if (x < 4) return;

            for (int i = 0; i < 5; i++)
            {
                if (ans.Substring(i, 1) == boardCell[y, i])
                {
                }
                else if (ans.Contains(boardCell[y, i]))
                {
                    Slot9.BackgroundColor = Color.Pink;
                }
            }
        }
        private void Q_Clicked(object sender, System.EventArgs e)
        {
            Changer("Q");
        }

        private void W_Clicked(object sender, System.EventArgs e)
        {
            Changer("W");
        }

        private void E_Clicked(object sender, System.EventArgs e)
        {
            Changer("E");
        }

        private void R_Clicked(object sender, System.EventArgs e)
        {
            Changer("R");
        }

        private void T_Clicked(object sender, System.EventArgs e)
        {
            Changer("T");
        }

        private void U_Clicked(object sender, System.EventArgs e)
        {
            Changer("U");
        }

        private void I_Clicked(object sender, System.EventArgs e)
        {
            Changer("I");
        }

        private void O_Clicked(object sender, System.EventArgs e)
        {
            Changer("O");
        }

        private void P_Clicked(object sender, System.EventArgs e)
        {
            Changer("P");
        }

        private void S_Clicked(object sender, System.EventArgs e)
        {
            Changer("S");
        }

        private void D_Clicked(object sender, System.EventArgs e)
        {
            Changer("D");
        }

        private void F_Clicked(object sender, System.EventArgs e)
        {
            Changer("F");
        }

        private void H_Clicked(object sender, System.EventArgs e)
        {
            Changer("H");
        }

        private void J_Clicked(object sender, System.EventArgs e)
        {
            Changer("J");
        }

        private void K_Clicked(object sender, System.EventArgs e)
        {
            Changer("K");
        }

        private void L_Clicked(object sender, System.EventArgs e)
        {
            Changer("L");
        }

        private void Z_Clicked(object sender, System.EventArgs e)
        {
            Changer("Z");
        }

        private void X_Clicked(object sender, System.EventArgs e)
        {
            Changer("X");
        }

        private void C_Clicked(object sender, System.EventArgs e)
        {
            Changer("C");
        }

        private void V_Clicked(object sender, System.EventArgs e)
        {
            Changer("V");
        }

        private void B_Clicked(object sender, System.EventArgs e)
        {
            Changer("B");
        }

        private void N_Clicked(object sender, System.EventArgs e)
        {
            Changer("N");
        }

        private void M_Clicked(object sender, System.EventArgs e)
        {
            Changer("M");
        }

        private void Y_Clicked(object sender, System.EventArgs e)
        {
            Changer("Y");
        }

        private void A_Clicked(object sender, System.EventArgs e)
        {
            Changer("A");
        }

        private void G_Clicked(object sender, System.EventArgs e)
        {
            Changer("Y");
        }
    }
}
