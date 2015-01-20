using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;
// Assembly marked as compliant
[assembly: CLSCompliant(true)]

namespace Calculator
{
    /// <summary>
    /// The front-end controller of the calculator
    /// the user is able to interact with the calculator via button and keyboard presses
    /// the front-end controller will then send data to the internal calculator class to do
    /// the calculations
    /// </summary>
    /// 
    
    // Class marked as compliant
    [CLSCompliant(true)]
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
            calculator = new Calculator();
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
                case Keys.Back: backSpace(); break;
            }

            switch (e.KeyChar)
            {
                case '+': updatePanel('+'); break;
                case '-': updatePanel('-'); break;
                case '*': updatePanel('*'); break;
                case '/': updatePanel('/'); break;
                case '.': calculator.makeDecimal(); break;
            }
        }

        private void backSpace()
        {
            if (enabled)
            {
                calculator.backSpace();
                updateText();
            }
        }


        /// <summary>
        /// Description: Calculate the numbers that were inputed into the calculator,
        /// after the calculations are done a check will be done if an error occured during calculations,
        /// if no error occurs, update the text, else, output an error text instead.
        /// </summary>
        private void calculate()
        {
            calculator.calculate();

            if (calculator.isGood())
                updateText();
            else
                outputError();
        }

        /// <summary>
        /// Description: Adds the number to the panel and then updates the text
        /// Input: num - integers such as 0,1,2,3,..,9
        /// </summary>
        /// <param name="num"></param>
        private void updatePanel(int num)
        {
            calculator.addNumber(num);
            if (calculator.isGood())
                updateText();
            else
                outputError();
        }

        /// <summary>
        /// Description: Adds the operation to the panel and then updates the text
        /// Input: operation - operations such as +,-,*,/
        /// </summary>
        /// <param name="operation"></param>
        private void updatePanel(char operation)
        {
            calculator.addOperation(operation);
            if (calculator.isGood())
                updateText();
            else
                outputError();
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
        /// Description: Updates the currentOperation textbox to display an error.
        /// </summary>
        private void outputError()
        {
            text_currentOperation.Text = calculator.getError();
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
                enabled = true;
                btn_On.Text = "Off";
                updateText();
                btn_equals.Focus();
            }
            else
            {
                panel1.Enabled = false;
                panel1.Visible = false;
                enabled = false;
                btn_On.Text = "On";
                calculator.clearAll();
                calculator.memoryClear();
                btn_equals.Focus();
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
            if(enabled)
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
            if (enabled)
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
            }

            btn_equals.Focus();
        }

        /// <summary>
        /// Description: When an operations button is clicked send a key input
        /// of the corresponding button clicked. The equals button is then
        /// focused again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operations_Click(object sender, EventArgs e)
        {
            if (enabled)
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
                        case '/': SendKeys.Send("{DIVIDE}"); break;
                        case '.': SendKeys.Send("{.}"); break;
                    }
                }
            }

            btn_equals.Focus();
        }

        /// <summary>
        /// Description: When the Pos / Neg button is clicked
        /// invert the number from positive to negative and vice versa.
        /// The equals button is then focused again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PosNeg_click(object sender, EventArgs e)
        {
            if (enabled)
            {
                calculator.setPosNeg();
                updateText();
            }

            btn_equals.Focus();
        }

        /// <summary>
        /// Description: When the CE button is clicked, clear the
        /// current operand. And then focuses back onto the focus button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CE_Click(object sender, EventArgs e)
        {
            if (enabled)
            {
                calculator.clearCurrent();
                updateText();
            }

            btn_equals.Focus();
        }

        /// <summary>
        /// Description: When the C button is clicked, clear all the operands.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_C_Click(object sender, EventArgs e)
        {
            if (enabled)
            {
                calculator.clearAll();
                updateText();
            }

            btn_equals.Focus();
        }

        private void btn_BackSpace_Click(object sender, EventArgs e)
        {
            if (enabled)
            {
                SendKeys.Send("{BACKSPACE}");
            }

            btn_equals.Focus();
        }

        private void btn_Memory_Click(object sender, EventArgs e)
        {
            if (Enabled)
            {
                Button btn = (Button)sender;
                string name = btn.Text.ToString();

                switch (name)
                {
                    case "M+": calculator.memoryAdd(); updateText(); break;
                    case "MR": calculator.memoryRecall(); updateText(); break;
                    case "MC": calculator.memoryClear(); updateText(); break;
                    case "MS": calculator.memoryStore(); updateText(); break;
                }
            }

            btn_equals.Focus();
        }

        
        // end of class
    }
}
