using LemonWayBusiness.CustomException;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace LemonWayBusiness
{
    public static class Mathematic
    {
        private static void CheckIfValidNumber(int n)
        {
            if (n < 1 || n > 100)
            {
                throw new FibonnaciException(n);
            }
        }

        /// <summary>
        /// Get the fibonnaci number regarding the parameter
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fibonnaci(int n)
        {
            try
            {
                CheckIfValidNumber(n);
                int previousNumberA = 0;
                int previousNumberB = 1;

                for (int i = 0; i < n; i++)
                {
                    int tmp = previousNumberA;
                    previousNumberA = previousNumberB;
                    previousNumberB = tmp + previousNumberB;
                }
                return previousNumberA;
            }
            catch (FibonnaciException)
            {
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
