using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public struct Customer:ICustomer,ICustomer2
    {

        public int gender { get; set; }
        void  ICustomer.Print()
        {
            Console.Write("Icustomer1");
        }
        void ICustomer2.Print()
        {
            Console.WriteLine("Icustomer2");
        }
        private int id;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id;}
            set { id = value; }
        }

        public static string GetGender(int gender)
        {
            switch(gender)
            { 
                case 0:
                    return " UnKnow";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return " Invalid data detected";

            }    
        }
        public Customer(int Id,string Name,int gender)
        {
            this.id = Id;
            this.name = Name;
            this.gender = gender;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Your Id :{id} your name is {name} your gender is {GetGender(gender)}");
        }
       
    }
}
