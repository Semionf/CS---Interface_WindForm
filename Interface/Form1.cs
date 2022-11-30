namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        private static int num1 = 0;
        private static int num2 = 0;
        private  int index = 0;
        Item[] arr = new Item[5];
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cola c = new Cola();
            label7.Text = c.getPrice().ToString();
            label9.Text = (Convert.ToInt32(label9.Text) + c.getPrice()).ToString();
            label10.Text = "X";
            num1++;
            if (label13.Text.Length == 0)
            {
                label13.Text = "1";
            }
            else
            {
                label13.Text = (Convert.ToInt32(label13.Text) + 1).ToString();
            }
            arr[index] = new Cola();
            index++; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kinli k = new Kinli();
            label6.Text = k.getPrice().ToString();
            label9.Text = (Convert.ToInt32(label9.Text) + k.getPrice()).ToString();
            label11.Text = "X";
            num2++;
            if(label12.Text.Length == 0)
            {
                label12.Text = "1";
            }
            else
            {
                label12.Text = (Convert.ToInt32(label12.Text) + 1).ToString();
            }
            arr[index] = new Kinli();
            index++;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label14.Text = "";
            if(index > 0)
            {
                for (int i = 0; i < index; i++)
                {
                    label14.Text += (arr[i].getPrice() + "\n");
                    MessageBox.Show(arr[i].Name());
                }
            }
        }
    }
}
