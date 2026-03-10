namespace cs_gui_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;

            try
            {
                a = int.Parse(this.textBoxA.Text);
                b = int.Parse(this.textBoxB.Text);
                c = int.Parse(this.textBoxC.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("введите корректные числа");
                return;
            }

            Properties.Settings.Default.saveA = textBoxA.Text;
            Properties.Settings.Default.saveB = textBoxB.Text;
            Properties.Settings.Default.saveC = textBoxC.Text;
            Properties.Settings.Default.Save();

            int res = CalculateProduct.Calculate(a, b, c);

            MessageBox.Show($"Произведение двух меньших чисел: {res}");
        }
    }
}

public class CalculateProduct
{
    public static int Calculate(int a, int b, int c)
    {
        int res = 0;
        if (a > b && a > c)
        {
            res = b * c;
            return res;
        }
        else if (b > a && b > c)
        {
            res = a * c;
            return res;
        }
        else
        {
            res = a * b;
            return res;
        }
    }

}