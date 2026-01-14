using System;
using System.Diagnostics.Metrics;
using System.Threading.Tasks.Dataflow;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //Console.WriteLine("Enter your first number");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter your second number");
        //int b = Convert.ToInt32(Console.ReadLine());
        //int sum = a + b; 
        //Console.WriteLine($"sum of {a} + {b} is ={sum} ");

        //Console.WriteLine("Enter Five numbers");
        //double a = Convert.ToInt32(Console.ReadLine());

        //double b = Convert.ToInt32(Console.ReadLine());

        //double c = Convert.ToInt32(Console.ReadLine());
        //double d = Convert.ToInt32(Console.ReadLine());
        //double e = Convert.ToInt32(Console.ReadLine());
        //double avg = (a + b + c + d + e) / 5;
        //Console.WriteLine($" Avarage of the number is{avg}");


        //Console.WriteLine("Enter a number");
        //int a = Convert.ToInt32(Console.ReadLine());
        //if (a % 2 == 0) 
        //    {
        //    Console.WriteLine($"{a} number is Even");

        //}
        //else
        //{
        //    Console.WriteLine($"{a} number is odd");
        //}

        //Console.WriteLine("Enter a year");
        //int year =Convert.ToInt32(Console.ReadLine());

        //if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) 
        //{
        //    Console.WriteLine($"{year} is leap year");

        //}
        //else {
        //    Console.WriteLine($"{year} is not leap year");
        //}

        //Console.WriteLine("Enter the area of the circle");
        //double radius = Convert.ToInt32(Console.ReadLine());
        //double area =  Math.PI * radius * radius;
        //Console.WriteLine($"area of the circle is {area}");

        //Console.WriteLine("Enter first number");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Second number");
        //int b = Convert.ToInt32(Console.ReadLine());
        //if (a > b)
        //{
        //    Console.WriteLine($"the biggest number is {a}");

        //}
        //else
        //{
        //    Console.WriteLine($"the biggest number is {b}");
        //}

        //Console.WriteLine("Enter first number");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Second number");
        //int b = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Third number");
        //int c = Convert.ToInt32(Console.ReadLine());
        //if (a > b && a > c)
        //{
        //    Console.WriteLine($"the biggest number is {a}");

        //}
        //else if(b>a && b > c) 
        //{
        //    Console.WriteLine($"the biggest number is {b}");
        //}
        //else if(c>a && c > b){
        //    Console.WriteLine($"the biggest number is {c}");

        //}


        //Console.WriteLine("Enter first number");
        //int a=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Second number");
        //int b=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"Before swapping a={a},b={b}");

        //int temp = a;
        //a=b; b = temp;
        //Console.WriteLine($"After swapping a={a},b={b}");



        //Console.WriteLine("Enter a String");
        //string len=Console.ReadLine();
        //int length = len.Length;
        //Console.WriteLine("Length of the string is {0}",length);


        //Console.WriteLine("Enter the marks of 6 subjects");
        //double a1=Convert.ToDouble(Console.ReadLine());
        //double a2=Convert.ToDouble(Console.ReadLine());
        //double a3=Convert.ToDouble(Console.ReadLine());
        //double a4=Convert.ToDouble(Console.ReadLine());
        //double  a5=Convert.ToDouble(Console.ReadLine());
        //double a6=Convert.ToDouble(Console.ReadLine());
        //double total=a1 + a2 + a3 + a4 + a5 + a6;
        //double prec = total / 6;
        //double cgpa = prec / 9.5;
        //Console.WriteLine("CGPA =" + Math.Round(cgpa, 2));

























        //Console.WriteLine("Enter the color");
        //string color = Console.ReadLine().ToLower();
        //switch (color)
        //{
        //    case "red":
        //        Console.WriteLine("You  Entered red color,stop the vehicle");
        //        break;
        //    case "yellow":
        //        Console.WriteLine("You  Entered yellow color,Ready to go");
        //        break;
        //    case "green":
        //        Console.WriteLine("You  Entered Green color,Go");
        //        break;
        //    default:
        //        Console.WriteLine("invalid color");
        //        break;
        //}

        //Console.WriteLine("Numbers");
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine(i);
        //}

        //Console.WriteLine("Enter the number");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Multipication table of {0} ",a);
        //for (int i = 1; i <=10; i++) 
        //{
        //    Console.WriteLine($"{a} x {i} = {a * i}");
        //}

        //Console.WriteLine("Numbers");
        //int  sum = 0;
        //for (int i = 1; i <= 50; i++)
        //{
        //    if(i % 2 == 0)
        //    {
        //        sum += i;
        //    }
        //}
        //Console.WriteLine("the sum of all even numbers " + sum);


        //Console.WriteLine("Numbers");

        //for (int i = 100; i >= 50; i--)
        //{
        //    Console.WriteLine(i);   
        //}

        //for (int i = 1; i <= 50; i++)
        //{
        //   if(i % 3 == 0 && i % 5 == 0) {
        //        Console.WriteLine("FizzBuzz");

        //}else if(i % 3 == 0)
        //    {
        //        Console.WriteLine("Fizz");
        //    }
        //   else if (i % 5 == 0){
        //        Console.WriteLine("Buzz");

        //    }
        //    else
        //    {
        //        Console.WriteLine(i);
        //    }


        //int n1 = 0, n2 = 1, n3;
        //Console.Write("Enter the number : ");
        //int n = Convert.ToInt32(Console.ReadLine());

        //Console.Write(n1 + " " + n2 + " ");

        //for (int i = 2; i < n; i++)
        //{
        //    n3 = n1 + n2;
        //    Console.Write(n3 + " ");
        //    n1 = n2;
        //    n2 = n3;
        //}

        //Console.WriteLine("Enter the number");
        //int num = Convert.ToInt32(Console.ReadLine());
        //int num1 = num;
        //int sum = 0;
        //int digit = num.ToString().Length;

        //for (int temp = num; temp > 0;  )
        //{
        //    int digits = temp % 10;
        //    sum = sum + (int)Math.Pow(digits, digit);
        //    temp = temp / 10;
        //}
        //if (num1 == sum)
        //{
        //    Console.WriteLine("{0} is an armstrong number", num1);

        //}
        //else
        //{
        //    Console.WriteLine("{0} is not an armstrong number", num1);
        //}



        //Console.WriteLine("Enter the number");
        //int num = Convert.ToInt32(Console.ReadLine());
        //int num1 = num;
        //int sum = 0;


        //for (int temp = num; temp > 0;)
        //{
        //    int digits = temp % 10;
        //    sum = sum * 10 + digits;
        //    temp = temp / 10;
        //}
        //if (num1 == sum)
        //{
        //    Console.WriteLine("{0} is an Palindrome number", num1);

        //}
        //else
        //{
        //    Console.WriteLine("{0} is not an Palindrome number", num1);
        //}

        //int bal = 1000;
        //Console.WriteLine("Your current balance is {0}",bal);


        ////int curr = Convert.ToInt32(Console.ReadLine());

        //while ( bal != 0)
        //{
        //    Console.WriteLine("Enter amount to withdraw");
        //    int curr = Convert.ToInt32(Console.ReadLine());


        //    if (curr < bal)
        //    {
        //        bal -= curr;
        //        Console.WriteLine("Transaction successfull! Your balance is: {0}", bal);

        //    }
        //    else {



        //        Console.WriteLine("Transaction is failed ");

        //    }

        //}

        //Console.WriteLine("User Login");
        //string cp = "vishnu@12345";
        //int attempt= 0;
        //int maxattempt = 4;

        //while (attempt < maxattempt)
        //{
        //    Console.WriteLine("\nEnter your password");
        //    string ep = Console.ReadLine();


        //    if (ep.Length < 8) {
        //        Console.WriteLine("password must be 8 characters at least");
        //        attempt++;
        //    }
        //    else if (ep == cp)
        //    {
        //        Console.WriteLine("Login Successfull");
        //        break;

        //    }
        //    else
        //    {
        //        attempt++;
        //        Console.WriteLine($"invalid password Attempt left {maxattempt- attempt}");
        //    }
        //}  

        //int num;
        //do
        //{   
        //    Console.Write("Enter a positive integer: ");
        //    num = Convert.ToInt32(Console.ReadLine());
        //    int n1 = 0;

        //    if (num <= 0)
        //    {
        //        Console.Write("Enter a valid positive number: ");
        //        n1 = Convert.ToInt32(Console.ReadLine());
        //        break;
        //    }
        //} while (num > 0);

        //double totalBill = 0;
        //string y = "";

        //do
        //{


        //    Console.WriteLine("Welcome to the shop");
        //    Console.WriteLine("1.Black Coffee $100");
        //    Console.WriteLine("2.Lattee $150");
        //    Console.WriteLine("3.cappucino $50");
        //    int choice = Convert.ToInt32(Console.ReadLine());
        //    double price = 0;
        //    string name;
        //    switch(choice){
        //        case 1:
        //            name = "Black Coffee";
        //            price = 100;
        //            break;
        //        case 2:
        //            name = "Lattee";
        //            price = 150;
        //            break;
        //        case 3:
        //            name = "cappucino";
        //            price = 50;
        //            break;
        //        default:
        //            Console.WriteLine(" Enter a valid option");
        //            continue;

        //    }
        //    Console.WriteLine($"Enter the quantity of{name}");
        //    int qty = Convert.ToInt32(Console.ReadLine());
        //    double total = price * qty;

        //    Console.WriteLine("\n would you like to add toppings?");
        //    Console.WriteLine("1. Milk ($10)");
        //    Console.WriteLine("2. Sugar ($5)");
        //    Console.WriteLine("3.  Whipped Cream($19)");
        //    Console.WriteLine("4.  No toppings");
        //    int toppingC = Convert.ToInt32(Console.ReadLine());

        //    switch(toppingC){
        //        case 1: toppingC = 100; break;
        //        case 2: toppingC = 150; break;
        //        case 3: toppingC = 50; break;
        //        default: Console.WriteLine("Inavalid toppinhg choice!"); break;
        //    }
        //    double totalCost = total + (toppingC * qty);
        //    totalBill += totalCost;
        //    Console.WriteLine($"total price {totalBill}");
        //    Console.WriteLine("Do you want to continue? Yes or No");
        //    y = Console.ReadLine().ToLower();


        //} while (y == "yes");


        //int rows = 3;

        //for (int i = 0; i <= rows; i++)
        //{

        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write(" * ");
        //    }
        //    Console.WriteLine();
        //}


        //int rows = 3;
        //for (int i = 0; i <= rows; i++)
        //{

        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write( j );
        //    }
        //    Console.WriteLine();
        //}

        //int rows = 3;
        //for (int i = 0; i <= rows; i++)
        //{

        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write(i);
        //    }
        //    Console.WriteLine();
        //}

        //int rows = 3;
        //for (int i = rows; i >= 1; i--)
        //{

        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write("* ");
        //    }
        //    Console.WriteLine();
        //}

        //int rows = 7;
        //int cols = 7;

        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        if (i == 0)  // top horizontal line
        //        {
        //            Console.Write("*");
        //        }
        //        else if (j == cols / 2) // vertical line in the middle
        //        {
        //            Console.Write("*");
        //        }
        //        else
        //        {
        //            Console.Write(" ");
        //        }
        //    }
        //    Console.WriteLine();
        //}

        //int n = 5;

        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
        //            Console.Write("* ");
        //        else
        //            Console.Write("  ");
        //    }
        //    Console.WriteLine();
        //}




        //int n = 5; 

        //for (int i = n; i >= 1; i--) 
        //{
        //    for (int j = 1; j <= i; j++)  
        //    {
        //        Console.Write("* ");
        //    }
        //    Console.WriteLine(); 
        //}

        //int n = 5; 

        //for (int i = 1; i <= n; i++) 
        //{

        //    for (int j = i; j < n; j++)
        //        Console.Write(" ");

        //    for (int k = 1; k <= i; k++)
        //        Console.Write("* ");

        //    Console.WriteLine(); 
        //}

        //int n = 5; 


        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = i; j < n; j++)
        //        Console.Write(" ");

        //    for (int k = 1; k <= i; k++) 
        //        Console.Write("* ");

        //    Console.WriteLine();
        //}

        //for (int i = n - 1; i >= 1; i--)
        //{
        //    for (int j = n; j > i; j--) 
        //        Console.Write(" ");

        //    for (int k = 1; k <= i; k++)
        //        Console.Write("* ");

        //    Console.WriteLine();
        //}



        //int n = 5; 

        //for (int i = 1; i <= n; i++)
        //{

        //    for (int j = i; j < n; j++)
        //        Console.Write(" ");


        //    for (int k = 1; k <= i; k++)
        //        Console.Write(k + " ");

        //    Console.WriteLine();
        //}

        //string[] jobs = new[] { "Manager" };
        //foreach (string job in jobs)
        //{
        //    Console.WriteLine(job);
        //}

        //int[] FixedArray = new int[3] { 1,3,5 };
        //foreach (int i in FixedArray)
        //{
        //    Console.WriteLine(i);
        //}

        //string[] roles = new string[4];
        //roles[0] = "company";
        //roles[1] = "company";
        //roles[2] = "job";
        //for (int i = 0; i < roles.Length; i++)
        //{
        //    Console.Write(roles[i]);
        //}

        //string[,] roles=new string[2,2];
        //roles[0, 0] = "Jobpro";
        //roles[0, 1] = "Admin";
        //roles[1, 0] = "jobs";
        //roles[1, 1] = "company";
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 2; j++)
        //    {
        //        Console.Write(roles[i, j] + " ");
        //    }
        //    Console.WriteLine();

        //}


        //String[][] roles = new string[2][];
        //roles[0] = new string[] { "jobs" };
        //roles[1] = new string[] { "seeker" };

        //for(int i=0; i<roles.Length; i++)
        //{
        //    for(int j=0; j<roles[i].Length; j++)
        //    {
        //        Console.Write(roles[i][j] + " ");

        //    }
        //    Console.WriteLine();
        //}


        //int[] num = { 30, 40, 50, 60, 70 };
        //int sum = 0;
        //for (int i = 0; i < num.Length; i++)
        //{
        //    sum += num[i];
        //}
        //Console.WriteLine("sum of array is="+sum);



        //int[] num = { 20, 30, 10, 15, 50, 55, 60 };
        //int max = 0;
        //for (int i = 0; i < num.Length; i++)
        //{
        //    max = num[i];
        //}
        //Console.WriteLine("Largest number is ="+ max);


        //int[] num = {1,3,4,5,6,7,8,9,10,11,12,13,14,15};
        //int even = 0, odd = 0;
        //for (int i = 0; i < num.Length; i++)
        //{
        //    if (num[i] % 2 == 0)
        //        even++;
        //    else
        //        odd++;

        //}
        //Console.WriteLine("Even numbers are=" + even);
        //Console.WriteLine("Odd numbers are=" + odd);

        //int[] num = {10, 20, 30};
        //Console.WriteLine("Array in reverse");
        //for(int i=num.Length -1;i>=0; i--)
        //{
        //    Console.Write(num[i] + " ");
        //}


        //int[] num = { 10, 20, 30, 40, 50 };
        //int search = 40;
        //bool found = false;

        //for (int i = 0; i < num.Length; i++)
        //{
        //    {
        //        if (num[i] == search)
        //            found = true;
        //    }

        //    if (found)
        //    {
        //        Console.WriteLine("Element found");
        //    }

        //    else
        //    {
        //        Console.WriteLine("Element not found");
        //    }


        //}

        //int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        //int[,] b = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
        //int[,] sum = new int[3, 3];

        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        sum[i, j] = a[i, j] + b[i, j];
        //        Console.Write(sum[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //} 

        //int[,] a = { { 1, 2 }, { 3, 4 } };
        //int[,] b = { { 5, 6 }, { 7, 8 } };
        //int[,] c = new int[2, 2];

        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 2; j++)
        //    {
        //        c[i, j] = 0;
        //        for (int k = 0; k < 2; k++)
        //            c[i, j] += a[i, k] * b[k, j];

        //        Console.Write(c[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}

        //int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        //for (int i = 0; i < 3; i++)
        //{
        //    int r = 0, c = 0;
        //    for (int j = 0; j < 3; j++)
        //    {
        //        r += a[i, j];
        //        c += a[j, i];
        //    }
        //    Console.WriteLine("Row " + (i + 1) + " = " + r + ", Col " + (i + 1) + " = " + c);
        //}

        //int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        //Console.WriteLine("Transpose of the matrix:");
        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Console.Write(a[j, i] + " ");

        //    }

        //    Console.WriteLine();
        //}


        //int[,] a = new int[3, 3];
        //Console.WriteLine("Enter 9 elements:");

        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        a[i, j] = Convert.ToInt32(Console.ReadLine());

        //    }

        //}



        //Console.Write("Main diagonal: ");
        //for (int i = 0; i < 3; i++)
        //{
        //    Console.Write(a[i, i] + " ");
        //}


        //Console.Write("\nSecondary diagonal: ");
        //for (int i = 0; i < 3; i++)
        //{
        //    Console.Write(a[i, 2 - i] + " ");
        //}

        //int[][] marks = new int[3][];
        //marks[0] = new int[] { 80, 75, 90 };          // 3 marks
        //marks[1] = new int[] { 60, 70, 80, 85, 90 };  // 5 marks
        //marks[2] = new int[] { 95, 85 };              // 2 marks

        //for (int i = 0; i < marks.Length; i++)
        //{
        //    int total = 0;
        //    for (int j = 0; j < marks[i].Length; j++)
        //    {
        //        total += marks[i][j];
        //    }


        //    Console.WriteLine("Student " + (i + 1) + " Total = " + total);
        //}



        //int[][] days = new int[12][];
        //days[0] = new int[31]; // January
        //days[1] = new int[28]; // February
        //days[2] = new int[31]; // March
        //days[3] = new int[30]; // April
        //days[4] = new int[31]; // May
        //days[5] = new int[30]; // June
        //days[6] = new int[31]; // July
        //days[7] = new int[31]; // August
        //days[8] = new int[30]; // September
        //days[9] = new int[31]; // October
        //days[10] = new int[30]; // November
        //days[11] = new int[31]; // December

        //for (int i = 0; i < 12; i++)
        //{
        //    Console.WriteLine("Month " + (i + 1) + " has " + days[i].Length + " days.");
        //}



        //int[][] marks = new int[3][];
        //marks[0] = new int[3];
        //marks[1] = new int[4]; 
        //marks[2] = new int[2]; 

        //for (int i = 0; i < marks.Length; i++)
        //{
        //    Console.WriteLine("Enter marks for student " + (i + 1) + ":");
        //    for (int j = 0; j < marks[i].Length; j++)
        //    {
        //        marks[i][j] = Convert.ToInt32(Console.ReadLine());

        //    }

        //}

        //for (int i = 0; i < marks.Length; i++)
        //{
        //    int total = 0;
        //    for (int j = 0; j < marks[i].Length; j++)
        //    {
        //        total += marks[i][j];
        //    }


        //    double avg = (double)total / marks[i].Length;
        //    Console.WriteLine("Student " + (i + 1) + " Average = " + avg);
        //}



        //char[][] star = new char[4][];
        //star[0] = new char[1];
        //star[1] = new char[2];
        //star[2] = new char[3];
        //star[3] = new char[4];

        //for (int i = 0; i < star.Length; i++)
        //{
        //    for (int j = 0; j < star[i].Length; j++)
        //    {
        //        Console.Write("* ");
        //    }
               
        //    Console.WriteLine();
        //}

        //int[] a = { 10, 25, 7, 90, 56 };
        //int max = a[0];
        //for (int i = 1; i < a.Length; i++)
        //{
        //    if (a[i] > max) max = a[i];
        //}

        //Console.WriteLine("Largest = " + max);

        //int[] a = { 5, 2, 8, 1, 9 };
        //Array.Sort(a);
        //foreach (int n in a)
        //{
        //    Console.Write(n + " ");

        //}

        //int[] a = { 10, 15, 22, 33, 40 };
        //int e = 0, o = 0;
        //foreach (int n in a)
        //{
        //    if (n % 2 == 0) e++; else o++;
        //}
        //;
        //Console.WriteLine("Even = " + e + ", Odd = " + o);


        //int[] a = { 5, 10, 15, 20 };
        //int sum = 0;
        //foreach (int n in a)
        //{
        //    sum += n;
        //}
        //Console.WriteLine("Sum = " + sum);



        //int[] a = { 1, 2, 3, 4, 5 };
        //for (int i = a.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(a[i] + " ");
        //}


        //int[] a = { 1, 2, 3 }, b = { 4, 5, 6 };
        //int[] c = new int[a.Length + b.Length];
        //a.CopyTo(c, 0);
        //b.CopyTo(c, a.Length);
        //foreach (int n in c)
        //{
        //    Console.Write(n + " ");
        //}


        //int[] a = { 2, 4, 2, 6, 4, 8 };
        //for (int i = 0; i < a.Length; i++)
        //{
        //    for (int j = i + 1; j < a.Length; j++)
        //    {
        //        if (a[i] == a[j])
        //        {
        //            Console.WriteLine("Duplicate: " + a[i]);

        //        }
        //    }
        //}

        //int[] a = { 10, 45, 20, 30 };
        //Array.Sort(a);
        //Console.WriteLine("Second Largest = " + a[a.Length - 2]);   





    }






}

















