namespace Persons
{
    //THIS IS THE MOTHERFUCKING BLUEPRINT FROM WHICH ALL FUCKING OBJECTS ARE CREATED!
    public class Person
    {
        //this is an empty constuctor, this was created so when a new instance was incitated it wouldnt error
        public Person()
        {

        }

        //this is the 2nd constructor for the template.. it provides a way of setting class props and defults.
        public Person(string firstName, string lastName, int age, bool happy)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Happy = happy;
       
        }

        //class is set up .. blueprinted out with properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool Happy { get; set; }
    
        


        //this is an additional method. this calc is based on the aboved given props
        public bool IsBurntOut()
        {
           if( Happy == true && Age >30 && Age <40)
            {
                return true;
            }

           if (Happy == false && Age >40)
            {
                return true;
            }
            return false;
        }

        //this explicity sets retrn value tostring over overrides the defult function
        public override string ToString()
        {
            //return string.Format("{0} {1} {2} {3}", FirstName, LastName, Age, IsBurntOut);

            return $"{FirstName} {LastName} {Age} {Happy} {IsBurntOut()}";

        }

        //public string DateOfBirth
        //{
         //   var dob = new Person();
   // }


        //These ( are params). when  setting they are params.. but when calling the method the values you pass are called arguments.
        public string FavouriteHobby(string hobbyName, int yearsOfPracrtice)
        {
            
            return $"I have had my hobby {hobbyName} for {yearsOfPracrtice} years";
        }
    }
}
