/*

    class Palindr
     {
        public static bool Palindromtest (string s)
        {
               for (int i = 0, j = s.Length - 1; i < j; i++, j--)
 
                    if (s[i] != s[j])
                        return false;
                       return true;
 
        }
     
    static void Main()
        {
        string s;
            Console.WriteLine("Анализ палиндромов\n\nВведите строку:");
          s = Console.ReadLine();
           if (Palindromtest(s))
       Console.WriteLine("Эта строка - палиндром");
       else Console.WriteLine("Эта строка - не палиндром");
        }
}
*/

public class PalindromeExample  
   {  
     public static void Main(string[] args)  
      {  
          int n,r,sum=0,temp;    
          Console.Write("Введи число: ");   
          n = int.Parse(Console.ReadLine());  
          temp = n;      
          while (n > 0)      
          {      
           r = n%10;      
           sum =(sum * 10) + r;      
           n = n/10;      
          }      
          if(temp == sum)      
           Console.Write("Число палиндром");      
          else      
           Console.Write("Число не палиндром");     
    }  
  }  
