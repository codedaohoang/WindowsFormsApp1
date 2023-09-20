using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m, n;
            if (int.TryParse(txtsom.Text, out m) && int.TryParse(txtson.Text, out n))
            {
               
                string selectedFunction = GetSelectedFunction();

                string result = string.Empty;

                switch (selectedFunction)
                {
                    case "Tổng dãy số":
                        int sum = 0;
                        for (int i = n; i <= m; i++)
                        {
                            sum += i;
                        }
                        result = "Tổng dãy số là: " + sum;
                        break;
                    case "Tích dãy số":
                        int product = 1;
                        for (int i = n; i <= m; i++)
                        {
                            product *= i;
                        }
                        result = "Tích dãy số là: " + product;
                        break;
                    case "Liệt kê số chẵn":
                        List<int> evenNumbers = new List<int>();
                        for (int i = n; i <= m; i++)
                        {
                            if (i % 2 == 0)
                            {
                                evenNumbers.Add(i);
                            }
                        }
                        result = "Số chẵn trong dãy là: " + string.Join(", ", evenNumbers);
                        break;
                    case "Liệt kê số chia hết cho 2 và 3":
                        List<int> divisibleBy2And3 = new List<int>();
                        for (int i = n; i <= m; i++)
                        {
                            if (i % 2 == 0 && i % 3 == 0)
                            {
                                divisibleBy2And3.Add(i);
                            }
                        }
                        result = "Số chia hết cho 2 và 3 trong dãy là: " + string.Join(", ", divisibleBy2And3);
                        break;
                    case "Liệt kê số nguyên tố":
                        List<int> primeNumbers = new List<int>();
                        for (int i = n; i <= m; i++)
                        {
                            if (IsPrime(i))
                            {
                                primeNumbers.Add(i);
                            }
                        }
                        result = "Số nguyên tố trong dãy là: " + string.Join(", ", primeNumbers);
                        break;
                    case "Đếm số nguyên tố":
                        int primeCount = 0;
                        for (int i = n; i <= m; i++)
                        {
                            if (IsPrime(i))
                            {
                                primeCount++;
                            }
                        }
                        result = "Số lượng số nguyên tố trong dãy là: " + primeCount;
                        break;
                    case "Liệt kê số chính phương":
                        List<int> perfectSquares = new List<int>();
                        for (int i = n; i <= m; i++)
                        {
                            if (IsPerfectSquare(i))
                            {
                                perfectSquares.Add(i);
                            }
                        }
                        result = "Số chính phương trong dãy là: " + string.Join(", ", perfectSquares);
                        break;
                    case "Đếm số chính phương":
                        int perfectSquareCount = 0;
                        for (int i = n; i <= m; i++)
                        {
                            if (IsPerfectSquare(i))
                            {
                                perfectSquareCount++;
                            }
                        }
                        result = "Số lượng số chính phương trong dãy là: " + perfectSquareCount;
                        break;
                    default:
                        result = "Vui lòng chọn chức năng.";
                        break;
                }

                textBoxResult.Text = result; 
            }
            else
            {
                textBoxResult.Text = "Vui lòng nhập số nguyên hợp lệ cho m và n.";
            }
        }

        private string GetSelectedFunction()
        {
            if (radioButtonSum.Checked) return "Tổng dãy số";
            if (radioButtonProduct.Checked) return "Tích dãy số";
            if (radioButtonEven.Checked) return "Liệt kê số chẵn";
            if (radioButtonDivisible.Checked) return "Liệt kê số chia hết cho 2 và 3";
            if (radioButtonPrime.Checked) return "Liệt kê số nguyên tố";
            if (radioButtonCountPrime.Checked) return "Đếm số nguyên tố";
            if (radioButtonPerfectSquare.Checked) return "Liệt kê số chính phương";
            if (radioButtonCountPerfectSquare.Checked) return "Đếm số chính phương";
            return string.Empty;
        }

        private bool IsPrime(int num)
        {
            if (num <= 1)
                return false;
            if (num <= 3)
                return true;
            if (num % 2 == 0 || num % 3 == 0)
                return false;
            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                    return false;
            }
            return true;
        }

        private bool IsPerfectSquare(int num)
        {
            int sqrt = (int)Math.Sqrt(num);
            return sqrt * sqrt == num;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
