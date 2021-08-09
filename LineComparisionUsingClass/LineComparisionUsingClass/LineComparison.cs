using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisionUsingClass
{
    
    public class LineComparison
    {

        public int x1, x2, y1, y2, x3, y3, x4, y4 ;
        public int diffInLength=0;
        public double len1;
        public double len2;





        public  void ParaMeter()
    {
            Console.WriteLine("Enter value for line 1  x1 ,x2 ,y1,y2 =");
            Console.WriteLine("Enter value for line 2 x3, x4, y3, y4  =");
        x1 = Convert.ToInt32(Console.ReadLine());
        x2 = Convert.ToInt32(Console.ReadLine());
        y1 = Convert.ToInt32(Console.ReadLine());
        y2 = Convert.ToInt32(Console.ReadLine());
        x3 = Convert.ToInt32(Console.ReadLine());
        x4 = Convert.ToInt32(Console.ReadLine());
        y3 = Convert.ToInt32(Console.ReadLine());
        y4 = Convert.ToInt32(Console.ReadLine());
        
    }


    public  double Calculation(int x1, int y1, int x2, int y2)
    {
        
        
            
             len1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                

              
                return len1;



        
    }
        public double Calculation1(int x3, int y3, int x4, int y4)
        {



            len2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));



            return len2;




        }
        public void Comparsion()
        {
            double len1 = Calculation(x1, x2, y1, y2);
            double len2 = Calculation1(x3, x4, x4, y4);
            Console.WriteLine("value of len1 " + len1);
            Console.WriteLine("value of len2" + len2);
           int diffInLength = len1.CompareTo(len2);
                 if (diffInLength == 0)
                {
                    Console.WriteLine("Lines are equal in length");
                }
                else if (diffInLength > 0)
                {
                    Console.WriteLine("Line1 is greater in length than Line2");
                }
                else
                {
                    Console.WriteLine("Line1 is smaller in length than Line2");
                }
                
                
        }
    }
        
}

