using System;

namespace L9_2_CheerleaderShout
{
    /*In this program: the user inputs their name into the program,
    //the program then outputs the name in the from of a cheerleader chant.*/
    class Program
    {
        static void CheerleaderShout(string pName)
        {
            char[] nameArray = pName.ToCharArray(); //Char array of the user's input

            for(int i = 0; i < nameArray.Length; i++)
            {
                Console.WriteLine("Gimme a " + nameArray[i]);
            }

            Console.WriteLine("What have you got?");
            Console.WriteLine(pName + "!");
        }
        // add your cheerleader shout method here

        static void Main(string[] args)
        {
            Console.WriteLine("Cheerleader's Shout!");
            Console.WriteLine("Input your name:");
            string name = Console.ReadLine();

            CheerleaderShout(name);

        }
    }
}

