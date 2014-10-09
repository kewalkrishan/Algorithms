using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Euclidean
    {
        public int CalculateGCD(int firstNumber,int secondNumber)
        {
            while (secondNumber != 0) 
            {
                int temp = secondNumber;
                secondNumber = firstNumber % secondNumber;
                firstNumber = temp;
            }

            return firstNumber;
        }

        public int CalculateLCM(int firstNumber, int secondNumber)
        {
            return (firstNumber * secondNumber) / CalculateGCD(firstNumber, secondNumber);
        }
    }
}
