namespace kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dakika = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label1.Text);
            sayi++;
            label1.Text = sayi.ToString();
            if (sayi == 60)
            {
                sayi = 0;
                label1.Text = sayi.ToString();
                dakika++;
                label2.Text = dakika.ToString();
            }
        }
    }
}