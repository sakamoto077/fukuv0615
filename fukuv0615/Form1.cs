namespace fukuv0615
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        int ans = rand.Next(0, 101);
        int count = 0;
        int guees;
        private string countTostring;

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
            MessageBox.Show(countTostring + "âÒñ⁄ÇÃíßêÌ");
            int guees = int.Parse(textBox1.Text);

            if (ans == guees)
            {
                MessageBox.Show("Bingo!!");
                count = 0;
                ans = rand.Next(101);
            }
            if (ans < guees)
            {
                MessageBox.Show("Less");
            }
            if (ans > guees)
            {
                MessageBox.Show("Greater");
            }
        }

    }
}