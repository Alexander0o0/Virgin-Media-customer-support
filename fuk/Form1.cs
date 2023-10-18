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
            textBox3.Text = "Okay, to further assist you with your Broadband pick a category";

            await Task.Delay(500);
            rjButton7.Visible = true;
            rjButton8.Visible = true;
            rjButton9.Visible = true;
            rjButton10.Visible = true;
            rjButton11.Visible = true;

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

        private void rjButton7_Click(object sender, EventArgs e)
        {
            rjButton7.Visible = false;
            rjButton8.Visible = false;
            rjButton9.Visible = false;
            rjButton10.Visible = false;
            rjButton11.Visible = false;
        }

        private async void rjButton10_Click(object sender, EventArgs e)
        {
            rjButton7.Visible = false;
            rjButton8.Visible = false;
            rjButton9.Visible = false;
            rjButton10.Visible = false;
            rjButton11.Visible = false;

            pictureBox6.Visible = true;
            textBox4.Visible = true;
            textBox4.Text = "I need to reset my password of the hub";

            await Task.Delay(1000);
            pictureBox7.Visible = true;
            textBox5.Visible = true;
            textBox5.Text = "For a quick change please select what kind of hub you have";

            await Task.Delay(500);
            rjButton12.Visible = true;
            rjButton13.Visible = true;
            rjButton14.Visible = true;
            rjButton15.Visible = true;
        }

        private void rjButton11_Click(object sender, EventArgs e)
        {
            rjButton7.Visible = false;
            rjButton8.Visible = false;
            rjButton9.Visible = false;
            rjButton10.Visible = false;
            rjButton11.Visible = false;
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            rjButton7.Visible = false;
            rjButton8.Visible = false;
            rjButton9.Visible = false;
            rjButton10.Visible = false;
            rjButton11.Visible = false;
        }

        private void rjButton8_Click(object sender, EventArgs e)
        {
            rjButton7.Visible = false;
            rjButton8.Visible = false;
            rjButton9.Visible = false;
            rjButton10.Visible = false;
            rjButton11.Visible = false;
        }

        private void rjButton12_Click(object sender, EventArgs e)
        {
            rjButton12.Visible = false;
            rjButton13.Visible = false;
            rjButton14.Visible = false;
            rjButton15.Visible = false;
        }

        private void rjButton13_Click(object sender, EventArgs e)
        {

        }

        private void rjButton14_Click(object sender, EventArgs e)
        {

        }

        private void rjButton15_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}