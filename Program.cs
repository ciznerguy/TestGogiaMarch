using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGogiaMarch
{
    internal class Program
    {
        
        // פעולה המקבלת מערך של עוגות
        // מדפיסה את כל העוגות העונות לתנאי בשאלה
        // הפעולה לא מחזירה כלום

       public static bool HasSugar ( string[] myMarkivim)
        {
            for (int i=0;i<myMarkivim.Length;i++)
            {
                if (myMarkivim[i]=="sugar")
                {
                    return true;
                }
            }
            return false;
        }
        
        public static void PrintCakes (Cake[] arrCakes)
        {
            for (int i=0;i<arrCakes.Length;i++) 
            {
                bool hasSugar = false;
                for (int j = 0; j < arrCakes[i].GetArr().Length;j++) 
                {
                    if (arrCakes[i].GetArr()[j] == "sugar")
                         {
                        hasSugar = true;
                    }
                }
                
                if (arrCakes[i].GetTzilak() && arrCakes[i].GetPrice()<50 && !hasSugar)
                {
                    Console.WriteLine(arrCakes[i].GetName();
                }
            }
        }
        
        static void Main(string[] args)
        {
            
            string[] arrMarkivim = new string[] { "flour", "sugar", "cocoa", "butter", "eggs" };
            Cake myCake = new Cake("Chocolate",  arrMarkivim , 5, 50.5, true);
            Console.WriteLine(myCake);

        }
    }
}
