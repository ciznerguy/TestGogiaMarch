using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGogiaMarch
{
    internal class Cake
    {
        private string name;   // שם העוגה
        private string[] arr; // מרכיבי העוגה
        private int n;        // מספר מרכיבי העוגה
        private double price; // מחיר
        private bool tzilak;  // האם העוגה מתאימה לחולי צליאק (אין מרכיב מסוכן)

        public Cake(string name, string[] arr, int n, double price, bool tzilak)
        {
            this.name = name;
            this.arr = arr;
            this.n = n;
            this.price = price;
            this.tzilak = tzilak;
        }
        public Cake(string name, double price)
        {
            this.name = name;
            this.arr = new string[20];
            this.n = 0;
            this.price = price;
            this.tzilak = true;
        }
        public Cake ()
        {

        } 
        public Cake ( Cake other)
        {
            this.name = other.name;
            this.arr = other.arr;
            this.n = other.n;
            this.price =other.price;
            this.tzilak = other.tzilak;

        }

       


        public string GetName()
        {
            return name;
        }

        public string[] GetArr()
        {
            return arr;
        }

        public int GetN()
        {
            return n;
        }

        public double GetPrice()
        {
            return price;
        }

        public bool GetTzilak()
        {
            return tzilak;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetArr(string[] arr)
        {
            this.arr = arr;
        }

        public void SetN(int n)
        {
            this.n = n;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public void SetTzilak(bool tzilak)
        {
            this.tzilak = tzilak;
        }


        // פעולה המקבלת מרכיב נוסף לעוגה
        // אם אין מקום להוספה תחזיר שקר
        // אם יש תוסיף למקום המתאים במערך
        // תעדכן את מספר המרכיבים ותחזיר אמת

        public bool Add (string  markiv)
        {
            if (n>20)
            {
                return false;
            }

            this.arr[n] = markiv;
            if (markiv =="regular flour" || markiv =="rising dough")
            {
                tzilak = false;
            }
            n++;
            return true;
        }
    
        public override string ToString()
        {
            string markivim = "";
            for (int i=0;i<arr.Length;i++)
            {
                markivim += arr[i] + "\n";
            }   
            
            
            return $"Name: {name}\nArr: {markivim}\nN: {n}\nPrice: {price}\nTzilak: {tzilak}";
        }

    }
}
