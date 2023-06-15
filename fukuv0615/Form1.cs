namespace fukuv0615
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        int ans = rand.Next(0, 101);
        int count = 0;
        int guees;
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