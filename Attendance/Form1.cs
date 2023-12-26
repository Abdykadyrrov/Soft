namespace Attendance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int attend = 0;
            int absent = 0;

            if (checkBox1.Checked == true)
            {
                attend++;
            }
            else if (checkBox2.Checked == true)
            {
                absent++;
            }

            if (checkBox3.Checked == true)
            {
                attend++;
            }
            else if (checkBox4.Checked == true)
            {
                absent++;
            }

            if (checkBox5.Checked == true)
            {
                attend++;
            }
            else if (checkBox6.Checked == true)
            {
                absent++;
            }

            if (checkBox7.Checked == true)
            {
                attend++;
            }
            else if (checkBox8.Checked == true)
            {
                absent++;
            }

            label6.Text = Convert.ToString(attend);
            label7.Text = Convert.ToString(absent);
        }
    }
}
