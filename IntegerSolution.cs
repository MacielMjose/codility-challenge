using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityDemoTest
{
    public static class IntegerSolution
    {
        public static int Solution(int[] A)
        {
            //A = [1, 3, 6, 4, 1, 2], the function should return 5.
            // Implement your solution here
            //lenth maximo = 6 , vai ate o 5
            int minPositiveValue = 1;

            //primeiro descubro o menor positivo que tem no array
            for (int i = 0; i < A.Length; i++)
            {
                int currentNumber = A[i];
                minPositiveValue = currentNumber > 0 && currentNumber < minPositiveValue
                    ? currentNumber : minPositiveValue;
            }

            //depois descubro se o menor positivo +1 existe no array
            //se existir, continuo buscando
            //se não existir, eu retorno ele e encerro
            var maxValue = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int currentValue = A[i];
                maxValue = maxValue < currentValue ? currentValue : maxValue;
            }

            int count = 0;
            //determinar qual deveria ser o menor inteiro
            do
            {
                int expectedMinPositive = minPositiveValue + count;

                if (A.Contains(expectedMinPositive) == false)
                {
                    return expectedMinPositive;
                }

                count++;

            } while (count <= maxValue);

            return minPositiveValue; //o maior positivo que tenho no array
        }
    }
}
