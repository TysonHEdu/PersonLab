using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLab
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColor;
        private bool isWorking;

        public Person(int personId, string firstName, string lastName, int age, string favoriteColor, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.favoriteColor = favoriteColor;
            this.isWorking = isWorking;
        }

        public void DisplayPersonInfo()
        {
            string firstName = this.firstName;
            string lastName = this.lastName;
            string favoriteColor = this.favoriteColor;
            int personId = this.personId; 

            Console.WriteLine(firstName + " " + lastName + " " + personId + " " + firstName + "'s favorite color is " + favoriteColor );


        }
        /*
        public void DisplaypersonId()
        {
            string favoriteColor = this.favoriteColor;
            string firstName = this.firstName;

            Console.WriteLine(firstName + "'s favourite colour is " + favoriteColor);
        }
        */
        public void ChangeFavoriteColour()
        {
            string favoriteColor = "White";

            Console.WriteLine(favoriteColor);
        }

        public void GetAgeInTenYears()
        {
            int age = this.age;

            Console.WriteLine(age + 10);
        }
        
        /*
        public void ToString()
        {
            List<Person> persons = new List<>();

            persons.Add(person);

            foreach (Person person in persons)
            {
                int personId = person.personId;
                string firstName = person.firstName;
                string lastName = person.lastName;
                int age = person.age;
                string favoriteColor = person.favoriteColor;
                bool isWorking = person.isWorking;
                Console.Write(List<>);
            }
            
        }
        */
    }
}
