namespace fukuv0615
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        int ans = $ "{rand.Next(0, 100)}";
        int count = rand.Next(0);

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            MessageBox.Show("{count}âÒñ⁄ÇÃíßêÌ");
            int guees;

            if (ans == guees)
            {
                MessageBox.Show("Bingo!!");
            }
            if (ans <= guees)
            {
                MessageBox.Show("Less");
            }
            if (ans >= guees)
            {
                MessageBox.Show("Greater");
            }
        }

    }
}