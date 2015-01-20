using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// 
    /// Description: Operation class that holds the value of the number and what operation will manipulate it
    /// such as addition, subtraction, multiplication, division.
    /// Author: Calvin Truong
    /// </summary>
    class Operation
    {
        private double value;
        private char type;
        private Boolean isDecimal;

        /// <summary>
        /// Description: Constructor, initializes the value as 0, the type of operation it has is set to
        /// V for void, and if its adding a decimal number or not.
        /// </summary>
        public Operation()
        {
            value = 0;
            type = 'V';
        }

        public Operation(double value, char type)
        {
            this.value = value;
            this.type = type;
            this.isDecimal = false;
        }

        public double Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public char Type
        {
            get { return type; }
            set { this.type = value; }
        }

        public Boolean IsDecimal
        {
            get { return isDecimal; }
            set { this.isDecimal = value; }
        }
    }
}
