using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1_TP
{
    public partial class Calculator : Form
    {
        const double MAXpositive = 400000;
        const double MINnegative = -200000;
        //Fields
        Double result = 0;
        public string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;
        public Calculator()
        {
            InitializeComponent();
        }
        // Метод для обработки кнопок математических операций
        public void BtnMathOperations_Click(object sender, EventArgs e)
        {
            if (result != 0) BtnEquals.PerformClick();
            else result = Double.Parse(TextDisplay1.Text);

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            if (TextDisplay1.Text != "0")
            {
                TextDisplay2.Text = fstNum = $"{result}{operation}";
                TextDisplay1.Text = string.Empty;
            }

        }
        //Метод для вывода результата
        public void BtnEquals_Click(object sender, EventArgs e)
        {
            secNum = TextDisplay1.Text;
            TextDisplay2.Text = $"{TextDisplay2.Text} {TextDisplay1.Text}=";
            if (TextDisplay1.Text != string.Empty)
            {
                if (TextDisplay1.Text != "0") TextDisplay2.Text = string.Empty;
            }
            //Выбор операции между числами
            switch (operation)
            {
                case "+":
                    TextDisplay1.Text = (result + Double.Parse(TextDisplay1.Text)).ToString();
                    RtBoxDisplayHistory.AppendText($"{fstNum}{secNum} = {TextDisplay1.Text}\n");
                    break;
                case "-":
                    TextDisplay1.Text = (result - Double.Parse(TextDisplay1.Text)).ToString();
                    RtBoxDisplayHistory.AppendText($"{fstNum}{secNum} = {TextDisplay1.Text}\n");
                    break;
                case "×":
                    TextDisplay1.Text = (result * Double.Parse(TextDisplay1.Text)).ToString();
                    RtBoxDisplayHistory.AppendText($"{fstNum}{secNum} = {TextDisplay1.Text}\n");
                    break;
                case "÷":
                    TextDisplay1.Text = (result / Double.Parse(TextDisplay1.Text)).ToString();
                    RtBoxDisplayHistory.AppendText($"{fstNum}{secNum} = {TextDisplay1.Text}\n");
                    break;
                default:
                    TextDisplay2.Text = $"{TextDisplay1.Text}=";
                    break;
            }
            result = Double.Parse(TextDisplay1.Text);
            operation = string.Empty;
        }
        //Метож для вывода истории оперций между числами
        public void BtnHistory_Click(object sender, EventArgs e)
        {
            PnlHistory.Height = (PnlHistory.Height == 5) ? PnlHistory.Height = 465 : 5;
        }
        //Метод очистки историю ввода
        public void BtnClearHistory_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistory.Clear();
            if (RtBoxDisplayHistory.Text == string.Empty)
                RtBoxDisplayHistory.Text = "There`s no history yet\n";

        }
        //Метод для удаления одиного символа
        public void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (TextDisplay1.Text.Length > 0)
                TextDisplay1.Text = TextDisplay1.Text.Remove(TextDisplay1.Text.Length - 1, 1);
            if (TextDisplay1.Text == string.Empty) TextDisplay1.Text = "0";
        }
        //Метод для очистки поля ввода
        public void BtnC_Click(object sender, EventArgs e)
        {

            TextDisplay1.Text = "0";
            TextDisplay2.Text = string.Empty;
            result = 0;
        }
        //Метож для удаления последнего введённого числа
        public void BtnCE_Click(object sender, EventArgs e)
        {
            TextDisplay1.Text = "0";
        }
        //Метод для выбора оперции
        public void BtnOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            switch (operation)
            {
                case "√x":
                    TextDisplay2.Text = $"√({TextDisplay1.Text})";
                    TextDisplay1.Text = Convert.ToString(Math.Sqrt(Double.Parse(TextDisplay1.Text)));
                    break;
                case "1/x":
                    TextDisplay2.Text = $"1/({TextDisplay1.Text})";
                    TextDisplay1.Text = Convert.ToString(1.0 / (Double.Parse(TextDisplay1.Text)));
                    break;
                case "cos(x)":
                    TextDisplay2.Text = $"cos({TextDisplay1.Text})";
                    TextDisplay1.Text = Convert.ToString(Math.Cos(Double.Parse(TextDisplay1.Text)));
                    break;
                case "%":
                    TextDisplay2.Text = $"%({TextDisplay1.Text})";
                    TextDisplay1.Text = Convert.ToString(Convert.ToDouble(TextDisplay1.Text) / Convert.ToDouble(100));
                    break;
                case "+/-":
                    TextDisplay1.Text = Convert.ToString(-1 * Convert.ToDouble(TextDisplay1.Text));
                    break;
            }
            RtBoxDisplayHistory.AppendText($"{TextDisplay2.Text} = {TextDisplay1.Text}\n");
        }
        //Метод для выхода из приложения
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Метод для ввода чисел
        public void BtnNum_Click(object sender, EventArgs e)
        {
            if (TextDisplay1.Text == "0" || enterValue) TextDisplay1.Text = string.Empty;

            enterValue = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!TextDisplay1.Text.Contains(","))
                {
                    // проверка максимальной длины числа
                    if (TextDisplay1.Text.Length <= 10)
                        TextDisplay1.Text = TextDisplay1.Text + button.Text;
                }
            }
            else
            {
                // проверка максимальной длины числа
                if (TextDisplay1.Text.Length <= 10)
                    TextDisplay1.Text = TextDisplay1.Text + button.Text;
            }

            // предотвращение ввода чисел, которые превышают максимальное значение
            if (TextDisplay1.Text.Contains("-"))
            {
                if (Convert.ToDouble(TextDisplay1.Text) < MINnegative)
                    TextDisplay1.Text = Convert.ToString(MINnegative);
            }
            else
            {
                if (Convert.ToDouble(TextDisplay1.Text) > MAXpositive)
                    TextDisplay1.Text = Convert.ToString(MAXpositive);
            }
        }


    }
}

