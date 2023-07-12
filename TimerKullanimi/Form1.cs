namespace TimerKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBoxempty.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();


            if (sayac == 30)
            {
                pictureBoxempty.Visible = false;
                pictureBoxred.Visible = true;
            }
            if (sayac == 80)
            {
                pictureBoxred.Visible = false;
                pictureBoxyellow.Visible = true;
            }
            if (sayac == 130)
            {
                pictureBoxyellow.Visible = false;
                pictureBoxgreen.Visible = true;
                sayac = 0;
            }

        }


    }
}