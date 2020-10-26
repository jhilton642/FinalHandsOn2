using System;

namespace FinalHandsOn2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 5;
            int num5 = 9;
            num1 = num2 + num3;
            Console.WriteLine(num2+" was added to "+num3+" and gave a result of "+num1);
            num1 = num2 * num3 * num4 / 5;
            Console.WriteLine(num2+" was multiplied by "+num3+" and "+num4+" and then devided by 5. this gave a result of " + num1);
            int answer = num5 + num2 * num3;
            Console.WriteLine(num5+" was added to the product of "+num2+" and "+num3+" to give a result of "+answer);
            int answer2 = (num5 + num2) * num3;
            Console.WriteLine(num5+" was added to "+num2+" and then multiplied by "+num3+" to give a result of "+answer2);
            int temp = num2;
            num2 = num2 * 2;
            Console.WriteLine(temp+" was doubled to give a result of "+num2);
            ++num3;
            Console.WriteLine("one was added to the third number to make it "+num3);
            num3++;
            Console.WriteLine("one was added to the third number to make it " + num3);
            num3 = num3 + 1;
            Console.WriteLine("one was added to the third number to make it " + num3);
            num5 += 11;
            Console.WriteLine("elevin was added to the fith number to make it " + num5);
            num5 -= 6;
            Console.WriteLine("six was subtracted from the fith number to make it "+num5);
            num2 = num2 / 2;
            Console.WriteLine("The second number was cut in half to make it "+num2);
            num4 = num4 / 3;
            Console.WriteLine("The fourth number was cut in thirds to make it " +num4);
            if (num1 % 8 == 0)
            {
                Console.WriteLine(num1 + " is divisible by 8");
            }
            else { Console.WriteLine(num1+" is not divisible by 8"); }
            string str1 = "Domino's Pizza, Inc., branded as Domino's, is an American multinational pizza restaurant chain founded in 1961.";
            string str2 = "The corporation is Delaware-domiciled and headquartered at the Domino's Farms Office Park in Ann Arbor, Michigan.";
            string str3 = "In 1961, Tom Monaghan and his brother, James, took over the operation of DomiNick's, an existing location of a small pizza restaurant chain that had been owned by Dominick DiVarti.";
            string str4 = "The deal was secured by a $500 down payment, and the brothers borrowed $900 to pay for the store.";
            string str5 = "The brothers planned to split the work hours evenly, but James did not want to quit his job as a full-time postman.";
            str1 += " the end";
            Console.WriteLine(str1);
            str2 = str2.Insert(str2.Length, " the end");
            Console.WriteLine(str2);
            str1 = str1.Insert(0, "in the beginning ");
            Console.WriteLine(str1);
            str1 = str1 + "-" + str2;
            Console.WriteLine(str1);
            str5 = str5.ToUpper();
            Console.WriteLine(str5);
            str3 = str2.Substring(str2.Length / 2);
            Console.WriteLine(str3);
            if (str3.Contains('a'))
            {
                Console.WriteLine("str3 contains 'a'");
            }
            else { Console.WriteLine("str3 does not contain 'a'"); }
            Console.WriteLine(str1.Substring(10,20));
            string temp1 = str4.Substring(0, str4.Length/2);
            string temp2 = str4.Substring(str4.Length / 2);
            str4 = temp2 + temp1;
            Console.WriteLine(str4);
            int totalLength = str1.Length + str2.Length + str3.Length + str4.Length + str5.Length;
            Console.WriteLine("The total length of all the strings is " + totalLength);
            bool stratsWith = str5.StartsWith("The");
            Console.WriteLine("str5 starts with \"The\": "+stratsWith);
        }
    }
}
