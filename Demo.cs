using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{

    abstract public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public void Show(float a, int b)
        {
        }

        //abstract methods
        abstract public void Display();

        //non-abstract method
        virtual public void GetData()
        {
        }

        public void PutData()
        {

        }

    }



    public class Teacher : Person
    {
        public string Degree { get; set; }

        //Method Overloading
        public void Show(int a, float b)
        {
        }


        //Method Overriding
        public override void GetData()
        {
        }

        //abstrct Method implementation
        public override void Display()
        {
        }


        public new void PutData()                //1. Method overloading
        {                                        //2. Method Overriding 
        }                                        //3. Abstract method implementation
                                                 //4. Method Hiding/showding  use of new keyword
    }
    public class Student : Person
    {
        public double AggregateMarks { get; set; }
        public override void Display()
        {

        }
    }
    public class Employee : Person
    {
        public int Bonus { get; set; }
        public override void Display()
        {

        }
    }
    public class Doctor : Person
    {
        public int NoOfSurgeriesPerformed { get; set; }
        public override void Display()
        {

        }



        public void DemoOfReferenceCall(Person person)
        {
            person.Display();
        }
    }
}
