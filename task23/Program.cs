 Console.WriteLine("enter your number");
 int num = Convert.ToInt32(Console.ReadLine());
 int[] a = new int[num];
 for (int i = 1;i <= num;  i++)
 {
    a[i - 1] = i * i * i;
    Console.WriteLine(a[i - 1]);
 }
