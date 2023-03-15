using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add2Num
{
    public class MyBigNumber
    {
        public static void Main(string[] args)
        {

        }

        public int[] GetNumbers(string str, int maxLength)
        {
            int[] numberList = new int[maxLength];
            for (int i = 0; i < str.Length; i++)
            {
                numberList[maxLength - str.Length + i] = int.Parse(str[i].ToString());
            }
            return numberList;
        }

        public String sum(String stn1, String stn2)
        {
            int maxLength;
            if (stn1.Length > stn2.Length)
            {
                maxLength = stn1.Length + 1;
            }
            else
            {
                maxLength = stn2.Length + 1;
            }

            int[] number1 = GetNumbers(stn1, maxLength);
            int[] number2 = GetNumbers(stn2, maxLength);
            int[] resultNumber = new int[maxLength];
            string finalResult = "";

            int temp = 0;
            int result = 0;
  
            for (int i = maxLength - 1; i > -1; i--)
            {
                result = number1[i] + number2[i] + temp;
                resultNumber[i] = result % 10;
                temp = result / 10;
                if (i == maxLength - 1)
                {
                    if (temp > 0)
                    {
                        Console.WriteLine(number1[i] + " + " + number2[i] + " = " + result + " ghi " + resultNumber[i] + " nho " + temp);

                    }
                    else
                    {
                        Console.WriteLine(number1[i] + " + " + number2[i] + " = " + result + " ghi " + resultNumber[i]);
                    }
                }
                else
                {
                    if (temp > 0)
                    {
                        Console.WriteLine(number1[i] + " + " + number2[i] + " + " + temp + " = " + result + " ghi " + resultNumber[i] + " nho " + temp);

                    }
                    else
                    {
                        Console.WriteLine(number1[i] + " + " + number2[i] + " = " + result + " ghi " + resultNumber[i]);
                    }
                }

                if (!(i == 0 && resultNumber[i] == 0))
                {
                    finalResult = resultNumber[i] + finalResult;
                }
                
                Console.WriteLine("Duoc: " + finalResult + "\n");
            }

            Console.WriteLine("KET QUA: " + finalResult);

            return finalResult;
        }
    }
}
