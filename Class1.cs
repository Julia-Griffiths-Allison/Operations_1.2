using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Operator
    {
        public static int Add(int A, int B)
        {
            return A + B;
        }

        public static int Subtract(int A, int B)
        {
            return B - A;
        }

        public static int Multiply(int A, int B)
        {
            return A * B;
        }

        public static int Divide(int A, int B)
        {
            return B / A;
        }

        public static int Module(int A, int B)
        {
            return B % A;
        }
    }
}
