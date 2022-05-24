using Xamarin.Forms;

namespace Wordul
{
    public partial class Daily : ContentPage
    {

        public Daily()
        {
            InitializeComponent();
            string[,] Cells = new string[,] {
                {Slot1.Text,Slot2.Text,Slot3.Text,Slot4.Text,Slot5.Text},
                {Slot6.Text,Slot7.Text,Slot8.Text,Slot9.Text,Slot10.Text},
                {Slot11.Text,Slot12.Text,Slot13.Text,Slot14.Text,Slot15.Text},
                {Slot16.Text,Slot17.Text,Slot18.Text,Slot19.Text,Slot20.Text}
            }; //putting all the labels text into arrays

            //Cells[0] = A;
        }
        private void boxesToArrays() {

        }

        private void A_Clicked(object sender, System.EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (Slot1.Text == "")
                {
                    Slot1.Text = "A";
                }

            }
        }
    }
}
