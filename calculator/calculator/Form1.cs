namespace calculator
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _clear;
        private int _Fnumber;
        private int _Snumber;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_clear == true)
            {
                label1.Text = "";
                _clear = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_clear == true)
            {
                label1.Text = "";
                _clear = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_clear == true)
            {
                label1.Text = "";
                _clear = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_clear == true)
            {
                label1.Text = "";
                _clear = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_clear == true)
            {
                label1.Text = "";
                _clear = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_clear == true)
            {
                label1.Text = "";
                _clear = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_clear == true)
            {
                label1.Text = "";
                _clear = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_clear == true)
            {
                label1.Text = "";
                _clear = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_clear == true)
            {
                label1.Text = "";
                _clear = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (_clear == true)
            {
                label1.Text = "";
                _clear = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _clear = true;
            _Fnumber = Convert.ToInt32(label1.Text);



        }

        private void button15_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _clear = true;
            _Fnumber = Convert.ToInt32(label1.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _clear = true;
            _Fnumber = Convert.ToInt32(label1.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _clear = true;
            _Fnumber = Convert.ToInt32(label1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int _Snumber;
            _Snumber = Convert.ToInt32(label1.Text);
            int ANS;
            if (_islem == '+')
            {

                ANS = _Fnumber + _Snumber;
                label1.Text = Convert.ToString(ANS);
            }
            if (_islem == '-')
            {

                ANS = _Fnumber - _Snumber;
                label1.Text = Convert.ToString(ANS);
            }
            if (_islem == '/')
            {

                ANS = _Fnumber / _Snumber;
                label1.Text = Convert.ToString(ANS);
            }
            if (_islem == '*')
            {

                ANS = _Fnumber * _Snumber;
                label1.Text = Convert.ToString(ANS);

            }


        }

        private void button12_Click(object sender, EventArgs e)
        {

            label1.Text = "";
        }
    }
}