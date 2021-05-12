using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLScs
{
    class Human : Player
    {
        private string gesture;
        public Human() : base() 
        { 
        }
        public string getGesture() 
        {
            Console.WriteLine("Please choose gesture");
            return Console.ReadLine();        
        }
    }
}




//class Players :
//    def __init__(self, user_action, computer_action):
//        self.player = user_action
//        self.computer = computer_action

//    def user_choice(self):
//        user_action = input("Enter a choice")
//        return user_action


//    def comp_choice(self):
//        computer_action = input("Choose gesture")
//        return computer_action