using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public struct Customer:ICustomer,ICustomer2
    {
        public enum gender
        {
            unknow,male,female
        }

        public void getGender()
        {
            string [] names = Enum.GetNames(typeof(gender));
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        public gender Gender { get; set; }
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

        public static string GetGender(gender gender)
        {
            switch(gender)
            { 
                case gender.unknow:
                    return " UnKnow";
                case gender.male:
                    return "Male";
                case gender.female:
                    return "Female";
                default:
                    return " Invalid data detected";

            }    
        }
        public Customer(int Id,string Name,gender gender)
        {
            this.id = Id;
            this.name = Name;
            this.Gender = gender;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Your Id :{id} your name is {name} your gender is {GetGender(gender)}");
        }
       
    }
}
