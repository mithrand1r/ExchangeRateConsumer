using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testVBAClass
{
    public class test
    {
        private int numberOne = 0;
        private int numberTwo = 0;

        public void SetNumberOne(int number)
        {
            numberOne = number;
        }
        public void SetNumberTwo(int number)
        {
            numberTwo = number;
        }
        public int Add()
        {
            return numberOne + numberTwo;
        }
    }
}
