namespace Butterfly_Catching_Game_MOO_ICT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameWindow game = new GameWindow();
            game.Show();
        }
    }
}