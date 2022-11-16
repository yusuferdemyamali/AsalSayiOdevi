namespace asalodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                long sayici = 0;
                for (long sayi = 2; sayi <= 100000; sayi++)
                {
                    long kontrolcu = 0;

                    for (long i = 2; i < sayi; i++)
                    {
                        if (sayi % i == 0)
                        {
                            kontrolcu = 1;
                            break;
                        }
                    }
                    if (kontrolcu == 0)
                    {
                        listBox1.Items.Add(sayi);
                        sayici++;
                    }
                }

            }
        }
    }
}