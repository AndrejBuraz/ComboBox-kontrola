namespace ComboBoxKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                txtBox.Text = "Algoritmi i programiranje";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                txtBox.Text = "Napredno i objektno programiranje";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                txtBox.Text = "Fizika";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                txtBox.Text = "Računalne mreže";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                txtBox.Text = "Matematika";
            }

        }
    }
}