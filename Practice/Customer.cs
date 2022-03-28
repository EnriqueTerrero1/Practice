using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public struct Customer:ICustomer,ICustomer2
    {
        void  ICustomer.Print()
        {
            Console.Write("Icustomer1");
        }
        void ICustomer2.Print()
        {
            Console.WriteLine("Icustomer2")
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
        public Customer(int Id,string Name)
        {
            this.id = Id;
            this.name = Name;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Your Id :{id} yor name is {name}");
        }
       
    }
}
