using System.Data;

namespace jago_da_velha_com_Windows_form
{
    public partial class Form1 : Form
    {
        private string player1;
        private string player2;
        private bool turnodoplayer1 = true;
        private Button[] gameButtons;
        public Form1()
        {
            InitializeComponent();
            gameButtons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            DisableGameButtons();
        }

        private void Comecarjogo()
        {
            player1 = textBox1.Text.Trim();
            player2 = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(player1) || string.IsNullOrEmpty(player2))
            {
                MessageBox.Show("Por favor coloque ambos os nomes");
                return;
            }

            EnabledGameButtons();

        }

        private void Buttons_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text != "") return;

            btn.Text = turnodoplayer1 ? "X" : "O";
            btn.Enabled = false;

            if (Ganhador())
            {
                string ganhador = turnodoplayer1 ? player1 : player2;
                MessageBox.Show($"(ganhador) ganhou!");
                DisableGameButtons();
                return;
            }

            turnodoplayer1 = !turnodoplayer1;
        }

        private bool Ganhador()
        {
            string[,] board = new string[3, 3];
            for (int i = 0; i < 9; i++)
                board[i / 3, i % 3] = gameButtons[i].Text;

            for (int i = 0; i < 3; i++)
            {
                if (!string.IsNullOrEmpty(board[i, 0]) && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2]) return true;
                if (!string.IsNullOrEmpty(board[0, i]) && board[0, i] == board[1, i] && board[1, i] == board[2, i]) return true;
            }

            if (!string.IsNullOrEmpty(board[0, 0]) && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) return true;
            if (!string.IsNullOrEmpty(board[0, 2]) && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]) return true;

            return false;
        }

        private void Limparboard()
        {
            foreach (var btn in gameButtons)
            {
                btn.Text = "";
                btn.Enabled = true;
            }

            turnodoplayer1 = true;
        }

        private void EnabledGameButtons()
        {
            foreach (var btn in gameButtons)
                btn.Enabled = true;
        }

        private void DisableGameButtons()
        {
            foreach (var btn in gameButtons)
                btn.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limparboard();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Limparboard();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Comecarjogo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
