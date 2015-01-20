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
    /// 

    class Calculator
    {
        private ArrayList prevOperation;
        private Operation currentOperation;
        private int trailingZeros;
        private int status;
        private double memory;

        /// <summary>
        /// Description: Constructor, creates a new operation and an empty arraylist to hold those operations,
        /// sets the number of trailingZeros to 0
        /// </summary>
        public Calculator()
        {
            currentOperation = new Operation();
            prevOperation = new ArrayList();
            trailingZeros = 0;
            status = 0;
            memory = 0;
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
            if (status != 0)
                return;

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

        /// <summary>
        /// Performs calculations starting from the left operation to the right
        /// </summary>
        public void calculate()
        {
            double total = 0;
            char operation = 'V';

            if (prevOperation.Count <= 0 || status != 0)
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
                    if (operation == '/' && n.Value == 0)
                    {
                        status = 1;
                        prevOperation.Clear();
                        return;
                    }
                    total = calculation(total, operation, n);
                    operation = n.Type;
                }
            }
            
            // calculate current operation now
            if (operation == '/' && currentOperation.Value == 0)
            {
                status = 1;
                prevOperation.Clear();
                return;
            }
            else
            {
                total = calculation(total, operation, currentOperation);


                currentOperation = new Operation();
                currentOperation.Value = total;

                string[] str_decimalNums = currentOperation.Value.ToString().Split('.');
                if (str_decimalNums.Length > 1)
                    currentOperation.IsDecimal = true;

                prevOperation.Clear();
                trailingZeros = 0;
            }
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
            if (status != 0)
                return;
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

        /// <summary>
        /// Description: checks if the calculator's status is good and returns true if it is
        /// </summary>
        /// <returns>Returns if the status of the calculator is good or not</returns>
        public Boolean isGood() { return status == 0; }

        /// <summary>
        /// Description: Returns a string of the error status of the calculator
        /// </summary>
        /// <returns>Returns the error status of the calculator</returns>
        public string getError()
        {
            if (status == 1)
                return "Divide by Zero error";
            else
                return "No error has occured";
        }

        /// <summary>
        /// Description: set the current operend's value from positive to negative and vice versa
        /// </summary>
        public void setPosNeg()
        {
            currentOperation.Value *= -1;
        }

        /// <summary>
        /// Description: Sets the current operand to 0;
        /// </summary>
        public void clearCurrent()
        {
            currentOperation = new Operation();
            trailingZeros = 0;
            status = 0;
        }

        /// <summary>
        /// Description: Clear all the operands
        /// </summary>
        public void clearAll()
        {
            currentOperation = new Operation();
            trailingZeros = 0;
            status = 0;
            prevOperation.Clear();
        }

        /// <summary>
        /// Description: Deletes the last character that would have been outputed onto the textbox.
        /// The first character that would be deleted would be the type of operation if any,
        /// the next character that would be deleted would be any trailing zeros
        /// the last would be any numbers.
        /// </summary>
        public void backSpace()
        {

            if (currentOperation.Type != 'V')            // if the operation type isn't void, set it to void
            {
                currentOperation.Type = 'V';
            }
            else if (trailingZeros > 0)                 // if there are trailing zeros decrement the trailingzero variable
            {
                trailingZeros--;
            }
            else
            {
                string str_operand = currentOperation.Value.ToString();
                string temp = str_operand.Substring(0, str_operand.Length - 1);
                char[] c = temp.ToCharArray();

                int i = c.Length;

                if (i == 0)
                {
                    currentOperation.Value = 0;
                }
                else
                {
                    // If there are trailing zeros after the deleted number, count them all
                    trailingZeros = 0;
                    while (c[i - 1] == '0')
                    {
                        trailingZeros++;
                        i--;
                        if (i <= 0)
                            break;
                    }
                }

                if (i != 0)
                {
                    // parse the string back into a double
                    currentOperation.Value = double.Parse(temp);
                    // Check if there are still decimal numbers
                    string[] str_decimalNums = currentOperation.Value.ToString().Split('.');
                    if (str_decimalNums.Length <= 1)
                        currentOperation.IsDecimal = false;
                }
            }    
        }

        public void memoryAdd()
        {
            memory += currentOperation.Value;
        }

        public void memoryRecall()
        {
            if (currentOperation.Type == 'V')
                currentOperation.Value = memory;
            else
            {
                prevOperation.Add(currentOperation);
                currentOperation = new Operation();
                trailingZeros = 0;
                currentOperation.Value = memory;
            }
        }

        public void memoryClear()
        {
            memory = 0;
        }

        public void memoryStore()
        {
            memory = currentOperation.Value;
        }

        // end of class
    }
}
