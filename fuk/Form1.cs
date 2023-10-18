namespace fuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void rjButton3_Click(object sender, EventArgs e)
        {
            rjButton3.Visible = false;
            rjButton4.Visible = false;
            rjButton5.Visible = false;
            rjButton6.Visible = false;

            pictureBox4.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = "I need help fixing my broadband";

            await Task.Delay(1000);

            pictureBox5.Visible = true;
            textBox3.Visible = true;
            textBox3.Text = "Enter a fix";
        }

        private async void rjButton4_Click(object sender, EventArgs e)
        {
            rjButton3.Visible = false;
            rjButton4.Visible = false;
            rjButton5.Visible = false;
            rjButton6.Visible = false;

            pictureBox4.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = "I need help connecting devices";

            await Task.Delay(1000);

            pictureBox5.Visible = true;
            textBox3.Visible = true;
            textBox3.Text = "Enter a fix";
        }

        private async void rjButton5_Click(object sender, EventArgs e)
        {
            rjButton3.Visible = false;
            rjButton4.Visible = false;
            rjButton5.Visible = false;
            rjButton6.Visible = false;

            pictureBox4.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = "I need help setting up a hub";

            await Task.Delay(1000);

            pictureBox5.Visible = true;
            textBox3.Visible = true;
            textBox3.Text = "Enter a fix";
        }

        private async void rjButton6_Click(object sender, EventArgs e)
        {
            rjButton3.Visible = false;
            rjButton4.Visible = false;
            rjButton5.Visible = false;
            rjButton6.Visible = false;


            pictureBox4.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = "I need help reseting my hub";

            await Task.Delay(1000);

            pictureBox5.Visible = true;
            textBox3.Visible = true;
            textBox3.Text = "Enter a fix";
        }
    }
}