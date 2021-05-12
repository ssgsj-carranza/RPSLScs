using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RPSLScs
{
    public class Gestures
    {
        List<string> Options = new List<string>();
            public Gestures()
        {
            Options.Add("rock");
            Options.Add("scissors");
            Options.Add("paper");
            Options.Add("lizard");
            Options.Add("spock");

        }

         public bool isValid(string correctValue) 
        {
            if (Options.Contains(correctValue)) 
            {
                return true;
       
            }
            else 
            {
                return false;
            }
        }
        public void showChoices() 
        {
            Console.WriteLine(Options);
        }
    }
}


//def is_valid(self, correct_value):
//        if correct_value in self.Gesture:
//            return True
//        else:

//            return False

//    def show_choices(self):
//        print(self.Gesture)
