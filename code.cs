using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendingmachined6
{
    internal class code
    {
		public class vendingmachine
		{

			static int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };

			public static void main(String[] args)
			{
                Scanner scanner2 = new(System.in);
                Scanner scanner1 = scanner2;
                Scanner scanner = scanner1;
				int money;
				Console.WriteLine("Enter amount to dispense: ");
				money = scanner.nextInt();
				AlgorithmUtility.vendingmachine(money, notes);
				scanner.close();
			}

		}
	}

    internal class Scanner
    {
        private object a;
        private object b;

        public Scanner(object a, in object b)
        {
            this.a = 1;
            this.b = 2;
        }

        internal int nextInt()
        {
            throw new NotImplementedException();
        }

        internal void close()
        {
            throw new NotImplementedException();
        }
    }

    internal class AlgorithmUtility
    {
        internal static void vendingmachine(int money, int[] notes)
        {
            throw new NotImplementedException();
        }
    }
}
