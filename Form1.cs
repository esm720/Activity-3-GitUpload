namespace Hello_World
{
    public partial class Form1 : Form
    {
        private const String HELLO_STRING = "hi"; //variable that can not be changed during execution using "const"
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked the first button!");
            label1.Text = ("Good Morning");
        }
        private void buttonTwoo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You click on the Second Button!");
            label1.Text = ("Buenos Dias");
        }


        private void ThirdButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked the third button!");
            label1.Text = ("Buengiorno");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LIGHT!");

        }

        private void hideLightButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
            }
        }

        private void aceFrontButt_Click(object sender, EventArgs e)
        {
            aceFront.Visible = false;
            aceBack.Visible = true;
        }

        private void aceBackButt_Click(object sender, EventArgs e)
        {
            aceFront.Visible=true;
            aceBack.Visible=false;
            

        }

        private void exitButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void readInputButt_Click(object sender, EventArgs e)
        {
            try
            {
                int ageInput = int.Parse(textBox2.Text); //turning string to int

                String userFullName = textBox1.Text + " " + lastNameTextBox.Text + " Age: ";
                outputLabel.Text = userFullName + ageInput.ToString(); //turning int back to string *"c" converts to money.
                                                                          // "c" : Money, "f" fix point scientific not, "e" Exponential scientific, "p" percent ** add a # to declare resolution, it rounds too. EX: "f3"
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong input, enter # for age and first/last name");
                MessageBox.Show(ex.Message);
                textBox1.Clear();
                lastNameTextBox.Clear();
                textBox2.Clear();
                textBox1.Focus();

                //use && for button to show "&" 
            }
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}