using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Calculator
{
    /// <summary>
    /// 
    /// Description: The calculator class manages the display and calculates all operations
    /// The calculator also has a status to tell the user if an error has occured or not
    /// Status:
    /// 0 = Good
    /// 1 = Divide by 0 error
    /// 
    /// Author: Calvin Truong
    /// 
    /// </summary>
    class Calculator
    {
        private ArrayList prevOperation;
        private Operation currentOperation;
        private int trailingZeros;

        /// <summary>
        /// Description: Constructor, creates a new operation and an empty arraylist to hold those operations,
        /// sets the number of trailingZeros to 0
        /// </summary>
        public Calculator()
        {
            currentOperation = new Operation();
            prevOperation = new ArrayList();
            trailingZeros = 0;
        }

        /// <summary>
        /// Description: Adds a number to the current operation, if there is already an
        /// operation type defined, then create a new operation and add the old operation
        /// to the arraylist prevOperation;
        /// If the number being added is a decimal number, determine which place that number goes to
        /// and if the number being added is 0, then increment the trailingzeros variable
        /// if a non-zero number is inputed afterwards, reset the trailingzeros variable to 0
        /// </summary>
        /// <param name="num">Adds the number to the current operation's value</param>
        public void addNumber(int num)
        {
            if (currentOperation.Type != 'V' && currentOperation.Value != 0)
            {
                prevOperation.Add(new Operation(currentOperation.Value, currentOperation.Type));
                currentOperation = new Operation();
                trailingZeros = 0;
            }

            if (!currentOperation.IsDecimal)
                currentOperation.Value = (currentOperation.Value * 10) + num;
            else
            {
                string[] str_decimals = currentOperation.Value.ToString().Split('.');
                Console.WriteLine("Decimal Length: " + str_decimals.Length);
                if (str_decimals.Length == 1)
                {
                    if (num != 0)
                    {
                        currentOperation.Value += (num / Math.Pow(10, 1 + trailingZeros));
                        trailingZeros = 0;
                    }
                    else
                        trailingZeros++;
                }
                else
                {
                    if (num != 0)
                    {
                        currentOperation.Value += (num / Math.Pow(10, str_decimals[1].Length + 1 + trailingZeros));
                        trailingZeros = 0;
                    }
                    else
                        trailingZeros++;
                }
            }
        }

        public void calculate()
        {
            double total = 0;
            char operation = 'V';

            if (prevOperation.Count <= 0)
                return;

            // Calculate all operations in the previous operation arraylist first
            foreach (Operation n in prevOperation.OfType<Operation>().ToArray())
            {
                if (operation == 'V')
                {
                    total = n.Value;
                    operation = n.Type;
                }
                else
                {
                    total = calculation(total, operation, n);
                    operation = n.Type;
                }
            }
            
            // calculate current operation now
             if( !(operation == '/' && currentOperation.Value == '0') )
                 total = calculation(total, operation, currentOperation);
            
            
            currentOperation = new Operation();
            currentOperation.Value = total;

            string[] str_decimalNums = currentOperation.Value.ToString().Split('.');
            if (str_decimalNums.Length > 1)
                currentOperation.IsDecimal = true;

            prevOperation.Clear();
            trailingZeros = 0;
        }

        /// <summary>
        /// Description: Perform calculations of the total with the value of the operation
        /// Input: double total - Total so far
        /// Input: char type - what type of operation
        /// Input: Operation n - the current operation
        /// </summary>
        /// <param name="total"></param>
        /// <param name="type"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private double calculation(double total, char type, Operation n)
        {
            switch (type)
            {
                case '+': return total + n.Value;
                case '-': return total - n.Value;
                case '*': return total * n.Value;
                default: return total / n.Value;
            }
        }

        /// <summary>
        /// Description: Adds the operation to the current operator
        /// </summary>
        /// <param name="operation">The operation such as +, -, *, /</param>
        public void addOperation(char operation)
        {
            currentOperation.Type = operation;
        }

        /// <summary>
        /// Description: Returns a string of the current operation and any operator
        /// Output: String
        /// </summary>
        /// <returns>Returns the value of the current operation and any operators</returns>
        public string getCurrentOperation()
        {
            string str_return;

            str_return = currentOperation.Value.ToString();

            if (trailingZeros > 0)
            {
                string[] str_decimalNum = currentOperation.Value.ToString().Split('.');

                if (str_decimalNum.Length == 1)
                    str_return += '.';

                for (int i = 0; i < trailingZeros; i++)
                    str_return += '0';
            }

            if (currentOperation.Type != 'V')
                str_return += ' ' + currentOperation.Type.ToString();

            return str_return;
        }

        /// <summary>
        /// Description: Returns the value of the previous operations and their operators
        /// Output: String
        /// </summary>
        /// <returns>Returns the value of the previous operations and their operators</returns>
        public string getPreviousOperation()
        {
            string operations = "";
            foreach( Operation n in prevOperation.OfType<Operation>().ToArray() )
            {
                operations += n.Value.ToString() + ' ' + n.Type + ' ';
            }

            return operations;
        }

        /// <summary>
        /// Description: Sets the next input to be decimal numbers
        /// </summary>
        public void makeDecimal()
        {
            currentOperation.IsDecimal = true;
        }
    }
}
