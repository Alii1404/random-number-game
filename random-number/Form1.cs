namespace random_number
{
    public partial class Form1 : Form
    {

        int num;
        int cehd = 0;
        bool oyunAktivdir = false;
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            num = r.Next(0, 101);
            cehd = 0;
            oyunAktivdir = true;

            textBox1.Clear();
            listBox1.Items.Clear();
            errorProvider1.SetError(textBox1, "");

            textBox1.Enabled = true;
            button1.Enabled = true;

            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!oyunAktivdir)
                return;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Ədəd daxil edin!");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int texmin))
            {
                errorProvider1.SetError(textBox1, "Tam ədəd daxil edin!");
                return;
            }

            if (texmin < 0 || texmin > 100)
            {
                errorProvider1.SetError(textBox1, "Ədəd 0-100 arasında olmalıdır!");
                return;
            }

            errorProvider1.SetError(textBox1, "");
            cehd++;

            if (texmin == num)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Oyunu qazandınız!");
                listBox1.Items.Add("Cəhd sayı: " + cehd);

                oyunAktivdir = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Daxil edilən ədəd yanlışdır.");

                if (texmin < num)
                    listBox1.Items.Add("Təsadüfi ədəddən kiçikdir.");
                else
                    listBox1.Items.Add("Təsadüfi ədəddən böyükdür.");

                listBox1.Items.Add("Cəhd sayı: " + cehd);
            }

            textBox1.Clear();
            textBox1.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Enabled = false;
            button1.Enabled = false;

        }
    }
}
