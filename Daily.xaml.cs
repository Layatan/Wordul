using Xamarin.Forms;

namespace Wordul
{
    public partial class Daily : ContentPage
    {
        public int y = 0;
        public int x = 0;
        public string[,] boardCell = new string[4, 5];

        public Daily()
        {
            InitializeComponent();
            
        }

        private void A_Clicked(object sender, System.EventArgs e)
        {
            Changer("A");
        }

        public void Changer(string letter) {
            
            if (x > 4)
            {
                y++;
                x = 0;
            }

            boardCell[y, x] = letter; x++;

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
    }
}
