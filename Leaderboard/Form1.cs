namespace Leaderboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Show();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //play
            if (textBox1.Text != "")
            {
                this.Hide();
                Game game = new Game();
                game.Show();
            }
            else {
                MessageBox.Show("Vyplò username");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        }
    }
}