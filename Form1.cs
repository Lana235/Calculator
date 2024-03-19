namespace calculatorBliaaaa
{
    public partial class Form1 : Form
    {
        double a, b, c;
        string d;

        public Form1()
        {
            InitializeComponent();
        }
        public void process(string s)
        {
            if (T.Text.Contains("-"))
                T2.Text = T.Text;
            d = s;
            if (d == "/")
            {
                T2.Text += "÷";
            }
            if (d == "*")
            {
                T2.Text += "×";
            }
            if (d == "+")
            {
                T2.Text += "+";
            }
            if (d == "-")
            {
                T2.Text += "-";
            }
            a = Convert.ToDouble(T.Text);
            T.Clear();
        }
        private void zero_Click(object sender, EventArgs e)
        {
            KeyEnter(0);
        }
        private void KeyEnter(int i)
        {
            if (T.Text == "0")
            {
                T.Text = i.ToString();
                T2.Text = i.ToString();
            }
            else
            {
                T.Text += i.ToString();
                T2.Text += i.ToString();
            }
        }
        private void b1_Click(object sender, EventArgs e)
        {
            KeyEnter(1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            KeyEnter(2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            KeyEnter(3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            KeyEnter(4);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            KeyEnter(5);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            KeyEnter(6);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            KeyEnter(7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            KeyEnter(8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            KeyEnter(9);
        }

        private void AC_Click(object sender, EventArgs e)
        {
            T.Clear();
            T.Text = "0";
        }

        private void gayofa_Click(object sender, EventArgs e)
        {
            process("/");
        }

        private void gamravleba_Click(object sender, EventArgs e)
        {
            process("*");
        }

        private void mimateba_Click(object sender, EventArgs e)
        {
            process("+");
        }

        private void gamokleba_Click(object sender, EventArgs e)
        {
            process("-");
        }

        private void toloba_Click(object sender, EventArgs e)
        {
            T2.Clear();
            b = Convert.ToDouble(T.Text);
            switch (d)
            {
                case "/":
                    c = a / b;
                    break;
                case "*":
                    c = a * b;
                    break;
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
            }
            T.Text = c.ToString();
        }

        private void factoriali_Click(object sender, EventArgs e)
        {
            double h = Convert.ToDouble(T.Text);
            T2.Text = h + "!";
            double fact = 1;
            for (; h > 0.0; h--)
            {
                fact = fact * h;
            }
            T.Text = fact.ToString();
        }

        private void pi_Click(object sender, EventArgs e)
        {
            //T.Text = Math.PI();
            T.Text = "3.141592653589793238462643383279";
        }

        private void fesvi_Click(object sender, EventArgs e)
        {
            double h = Convert.ToDouble(T.Text);
            T2.Text = "?" + h;
            h = Convert.ToDouble(System.Math.Sqrt(h));
            T.Text = h.ToString();
        }

        private void ertiIqstan_Click(object sender, EventArgs e)
        {
            double h = Convert.ToDouble(T.Text);
            T2.Text = "INV(" + h + ")";
            h = 1 / h;
            T.Text = h.ToString();
        }

        private void kubi_Click(object sender, EventArgs e)
        {
            double h = Convert.ToDouble(T.Text);
            T2.Text = "Cube(" + h + ")";
            h = h * h * h;
            T.Text = h.ToString();
        }

        private void kvadrati_Click(object sender, EventArgs e)
        {
            double h = Convert.ToDouble(T.Text);
            T2.Text = "Sqrt(" + h + ")";
            h = h * h;
            T.Text = h.ToString();
        }

        private void pliusMinusi_Click(object sender, EventArgs e)
        {
            if (!T.Text.Contains("-"))
            {
                T.Text = "-" + T.Text.Trim('+');
            }
            else
            {
                T.Text = "" + T.Text.Trim('-');
            }
        }

        private void wertili_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}