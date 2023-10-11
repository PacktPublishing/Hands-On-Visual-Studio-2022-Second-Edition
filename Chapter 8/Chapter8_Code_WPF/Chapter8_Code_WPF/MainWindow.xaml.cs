using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chapter8_Code_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool turn = true; // true = X turn, false = O turn

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (turn)
                btn.Content = "X";
            else
                btn.Content = "O";

            btn.IsEnabled = false;
            turn = !turn;
            CheckWinner();
        }

        private void CheckWinner()
        {
            string winner = null;

            // Check rows for winner
            for (int row = 0; row < 3; row++)
            {
                if (Equals(GetButtonContent(row, 0), GetButtonContent(row, 1)) && Equals(GetButtonContent(row, 1), GetButtonContent(row, 2)))
                {
                    winner = GetButtonContent(row, 0);
                    break;
                }
            }

            // Check columns for winner
            for (int col = 0; col < 3 && winner == null; col++)
            {
                if (Equals(GetButtonContent(0, col), GetButtonContent(1, col)) && Equals(GetButtonContent(1, col), GetButtonContent(2, col)))
                {
                    winner = GetButtonContent(0, col);
                    break;
                }
            }

            // Check diagonals for winner
            if (winner == null)
            {
                if (Equals(GetButtonContent(0, 0), GetButtonContent(1, 1)) && Equals(GetButtonContent(1, 1), GetButtonContent(2, 2)) ||
                    Equals(GetButtonContent(0, 2), GetButtonContent(1, 1)) && Equals(GetButtonContent(1, 1), GetButtonContent(2, 0)))
                {
                    winner = GetButtonContent(1, 1);
                }
            }

            // Announce winner
            if (winner != null)
            {
                winnerText.Text = winner + " Wins!";
                DisableButtons();
            }
        }

        private string GetButtonContent(int row, int col)
        {
            // Retrieve content of button at specified grid position
            return ((Button)this.FindName("btn" + (row * 3 + col))).Content?.ToString();
        }

        private void DisableButtons()
        {
            // Disable all buttons (effectively ending the game)
            for (int i = 0; i < 9; i++)
            {
                ((Button)this.FindName("btn" + i)).IsEnabled = false;
            }
        }
    }
}
