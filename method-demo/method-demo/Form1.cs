using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace method_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            SayHello();

            bool IsIcyHot = IcyHot(-1, 120);
            MessageBox.Show(IsIcyHot.ToString());

            bool checkIcyHot = IcyHot();
            MessageBox.Show(checkIcyHot.ToString());

            int answer = IntMax(4, 4, 23);
            MessageBox.Show(answer.ToString());

            bool AreWeInTrouble = MonkeyTrouble(false, false);
            MessageBox.Show(AreWeInTrouble.ToString());

            double diff = Diff21(19);
            MessageBox.Show(diff.ToString());
        }


        /// <summary>Set text property of labels to Hello and World</summary>
        /// <returns>void</returns>
        private void SayHello()
        {
            LblHello.Text = "Hello";
            LblWorld.Text = "World";
        }


        /// <summary>Check if it is icy hot</summary>
        /// <param name="temp1">Temperature 1</param>
        /// <param name="temp2">Temperature 2</param>
        /// <returns>bool</returns>
        private bool IcyHot(int temp1, int temp2)
        {
            if ((temp1 < 0 && temp2 > 100) || (temp1 > 100 && temp2 < 0))       // error here
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IcyHot()
        {
            int temp1, temp2;

            int.TryParse(textBoxTemp1.Text, out temp1);
            int.TryParse(textBoxTemp2.Text, out temp2);

            if (temp1 < 0 && temp2 > 100)       // error here
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int IntMax(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;

            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        private bool MonkeyTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile == true ^ bSmile == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private double Diff21(int n)
        {
            if (n > 21)
            {
                return Math.Abs(2 * (n - 21));
            }
            else
            {
                return Math.Abs(n - 21);
            }
        }
    }
}
