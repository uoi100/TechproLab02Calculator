using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private Calculator calculator;
        private Boolean enabled;

        /// <summary>
        /// Description: Constructor, sets the calculator to disable by default
        /// </summary>
        public Form1()
        {
            enabled = false;
            InitializeComponent();
        }

        /// <summary>
        /// Description: A key listener that listens to when a key is pressed
        /// if a key is pressed, then check if the corresponding key matches the cases
        /// then call the appropriate functions depending on the case
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Key Presses</param>
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!enabled)
                return;

            // Numbers and enter
            switch ((Keys) e.KeyChar)
            {
                case Keys.D0: updatePanel(0); break;
                case Keys.D1: updatePanel(1); break;
                case Keys.D2: updatePanel(2); break;
                case Keys.D3: updatePanel(3); break;
                case Keys.D4: updatePanel(4); break;
                case Keys.D5: updatePanel(5); break;
                case Keys.D6: updatePanel(6); break;
                case Keys.D7: updatePanel(7); break;
                case Keys.D8: updatePanel(8); break;
                case Keys.D9: updatePanel(9); break;
            }

            switch (e.KeyChar)
            {
                case '+': updatePanel('+'); break;
                case '-': updatePanel('-'); break;
                case '*': updatePanel('*'); break;
                case '/': updatePanel('/'); break;
            }

            if (e.KeyChar == '.')
            {
                calculator.makeDecimal();
            }
        }

        /// <summary>
        /// Description: Calculate the numbers that were inputed into the calculator
        /// </summary>
        private void calculate()
        {
            calculator.calculate();
            updateText();
        }

        /// <summary>
        /// Description: Adds the number to the panel and then updates the text
        /// Input: num - integers such as 0,1,2,3,..,9
        /// </summary>
        /// <param name="num"></param>
        private void updatePanel(int num)
        {
            calculator.addNumber(num);
            updateText();
        }

        /// <summary>
        /// Description: Adds the operation to the panel and then updates the text
        /// Input: operation - operations such as +,-,*,/
        /// </summary>
        /// <param name="operation"></param>
        private void updatePanel(char operation)
        {
            calculator.addOperation(operation);
            updateText();
        }

        /// <summary>
        /// Description: Updates the currentOperation and previousOperation textboxes
        /// </summary>
        private void updateText()
        {
            text_currentOperation.Text = calculator.getCurrentOperation();
            text_currentOperation.Invalidate();
            text_PrevOperations.Text = calculator.getPreviousOperation();
            text_PrevOperations.Invalidate();
        }

        /// <summary>
        /// Description: Turns the calculator on or off when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_On_Click(object sender, EventArgs e)
        {
            if (!enabled)
            {
                panel1.Enabled = true;
                panel1.Visible = true;
                calculator = new Calculator();
                enabled = true;
                btn_On.Text = "Off";
                btn_equals.Focus();
            }
            else
            {
                panel1.Enabled = false;
                panel1.Visible = false;
                enabled = false;
                btn_On.Text = "On";
            }
        }

        /// <summary>
        /// Description: when the equals button is clicked, then execute the calculate function
        /// to calculate the numbers inputed into the calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_equals_Click(object sender, EventArgs e)
        {
            calculate();
        }

        /// <summary>
        /// When a number button is pressed, send the input to the calculator.
        /// Focus is then set to the equals button whenever the user decides to
        /// press the enter or return button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumClickEvent(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int num;

            if (int.TryParse(btn.Text.ToString(), out num))
            {
                //num = int.Parse(btn.Text.ToString());
                switch (num)
                {
                    case 0: SendKeys.Send("{0}"); break;
                    case 1: SendKeys.Send("{1}"); break;
                    case 2: SendKeys.Send("{2}"); break;
                    case 3: SendKeys.Send("{3}"); break;
                    case 4: SendKeys.Send("{4}"); break;
                    case 5: SendKeys.Send("{5}"); break;
                    case 6: SendKeys.Send("{6}"); break;
                    case 7: SendKeys.Send("{7}"); break;
                    case 8: SendKeys.Send("{8}"); break;
                    case 9: SendKeys.Send("{9}"); break;                
                }
            }

            btn_equals.Focus();
        }

        private void Operations_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            char c;

            if (char.TryParse(btn.Text.ToString(), out c))
            {
                //c = char.Parse(btn.Text.ToString());
                switch (c)
                {
                    case '+': SendKeys.Send("{ADD}"); break;
                    case '-': SendKeys.Send("{SUBTRACT}"); break;
                    case '*': SendKeys.Send("{MULTIPLY}"); break;
                    case '/': SendKeys.Send("{DIVISION}"); break;
                    case '.': SendKeys.Send("{.}"); break;
                }
            }

            btn_equals.Focus();
        }
        // end of class
    }
}
