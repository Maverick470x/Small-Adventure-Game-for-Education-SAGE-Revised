using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Adventure_Game_for_Education__SAGE__Revised
{
    internal class Program
    {

        static void DialogueText(string dialogueMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(dialogueMessage);
            Console.ResetColor();
        }

        static void BattleSequence(string playerName)
        {
            //bool playerDefend = false;
            int dragonHealth = 100;
            int playerHealth = 100;
            //string combatChoice = "";
            


            while(playerHealth >= 1 || dragonHealth >= 1)
            {
                Random random = new Random();
                
                int playerDamage = random.Next(0, 30);
                dragonHealth -= playerDamage;
                Console.WriteLine("You attack the beast! Its health is: " + dragonHealth);
                Console.ReadLine();

                if (dragonHealth <= 0)
                {
                    Console.WriteLine("You won!");
                    Console.ReadLine();
                    Console.WriteLine("After battling the beast, you see the wise Sage approach you.");
                    Console.ReadLine();
                    DialogueText("Congrats, " + playerName + "!");
                    Console.ReadLine();
                    DialogueText("You have indeed done a great justice to us!");
                    Console.ReadLine();
                    DialogueText("Please proceed onward to freedom.");
                    Console.ReadLine();
                    EscapeRoom();
                }

                int enemyDamage = random.Next(0, 35);
                playerHealth -= enemyDamage;
                Console.WriteLine("The beast attacks you! Your health is: " + playerHealth);
                Console.ReadLine();

                if (playerHealth <= 0)
                {
                    GameOver();
                }
            }
        }

           
        public static void StartMenu()
        {
            //Initialize Variables
            string playerName = "";
            
            
            string text = @" __      __       .__                                    
/  \    /  \ ____ |  |   ____  ____   _____   ____       
\   \/\/   // __ \|  | _/ ___\/  _ \ /     \_/ __ \      
 \        /\  ___/|  |_\  \__(  <_> )  Y Y  \  ___/      
  \__/\  /  \___  >____/\___  >____/|__|_|  /\____>     
  __   \/       \_________  \_____    ___________________
_/  |_  ____    /   _____/  /  _  \  /  _____/\_   _____/
\   __\/  _ \   \_____  \  /  /_\  \/   \  ___ |    __)_ 
 |  | (  <_> )  /        \/    |    \    \_\  \|        \
 |__|  \____/  /_______  /\____|__  /\______  /_______  /
                       \/         \/        \/        \/ ";

            Console.WriteLine(text);
            Console.WriteLine("Welcome to Small Adventure Game for Education (Sage)! Please enter your name.");

            //Assign player input to variable
            playerName = Console.ReadLine();

            
            //Get player name length
            //int checkName = playerName.Length;

            if (string.IsNullOrEmpty(playerName))
            {
                StartMenu();
            }
            Console.WriteLine("Welcome " + playerName + "! " + "Please press enter to continue.");
            Console.ReadLine();
            RoomOne(playerName);
            
        }

        public static void RoomOne(string playerName)
        {
            string choice = "";

            Console.WriteLine("You awaken in a dark cavern. Standing in front of you, there appears to be a wise Sage. What do you do?");
            Console.WriteLine("Verb choice: Approach or Attack");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "Approach":
                    
                        DialogueText("Hello, " + playerName + "!");
                        Console.ReadLine();
                        DialogueText("Unbenownst to you, there lives a dangerous creature within these caverns.");
                        Console.ReadLine();
                        DialogueText("Ahead of you, are two routes. One will lead you to the creature while the other is unknown to even myself. Choose wisely!");
                        Console.ReadLine();
                    //CHOICES:
                    do
                    {
                        Console.WriteLine("Choices: Left or Right?");
                        choice = Console.ReadLine();

                        if (choice == "Left")
                        {
                            DragonRoom(playerName);
                        }
                        else if (choice == "Right")
                        {
                            TrapRoom();
                        }
                    } while (string.IsNullOrEmpty(choice));
                    break;
                
                case "Attack":
                    Console.WriteLine("You attack the Sage.");
                    Console.ReadLine();
                    DialogueText("You fool! How dare you attack me!");
                    Console.ReadLine();
                    Console.Write("The Sage attacks you with a tremendous amount of energy");
                    Console.ReadLine();
                    GameOver();
                    break;

                    default:
                    RoomOne(playerName);
                    break;
            }
        }
        
        public static void DragonRoom(string playerName)
        {
            //Initialize Variables
            //bool playerDefend = false;
            string combatChoice = "";

            Console.WriteLine("You slowly enter the left path when you suddenly realize that staring you right in the face, is the dangerous creature!");
            Console.ReadLine();
            DialogueText("Who dares disturb my slumber?");
            Console.ReadLine();
            DialogueText("Oh, a human, huh? Prepare yourself, mortal being!");
            Console.ReadLine();
            Console.WriteLine("The beast and you begin to battle it out.");
            Console.ReadLine();
            Console.WriteLine("Press Enter to perform a strike.");
            Console.ReadLine();
            do
            {
                BattleSequence(playerName);
               

            } while (string.IsNullOrEmpty(combatChoice));
        }
        public static void TrapRoom()
        {
            Console.WriteLine("You slowly walk into the right path. As you are walking, the path behind you seals shut and the room fills with a poisonous gas.");
            Console.ReadLine();
            GameOver();
        }

        public static void EscapeRoom()
        {
            string text = @"_________                                     __         ._.
\_   ___ \  ____   ____    ________________ _/  |_  _____| |
/    \  \/ /  _ \ /    \  / ___\_  __ \__  \\   __\/  ___/ |
\     \___(  <_> )   |  \/ /_/  >  | \// __ \|  |  \___ \ \|
 \______  /\____/|___|  /\___  /|__|  (____  /__| /____  >__
_____.___.            \//_____/            \._.        \/ \/
\__  |   | ____  __ __  __  _  ______   ____| |             
 /   |   |/  _ \|  |  \ \ \/ \/ /  _ \ /    \ |             
 \____   (  <_> )  |  /  \     (  <_> )   |  \|             
 / ______|\____/|____/    \/\_/ \____/|___|  /_             
 \/                                        \/\/ ";

            Console.WriteLine("You slowly take precise steps on the cloister which leads you to freedom.");
            Console.ReadLine();
            Console.WriteLine("You wonder what other adventures await you in this strange world.");
            Console.ReadLine();
            Console.WriteLine(text);
            Console.ReadLine();
            Console.WriteLine("Press Enter to restart");
            Console.ReadLine();
            StartMenu();

        }

        public static void GameOver()
        {
            Console.WriteLine("You Died!");
            Console.ReadLine();
            StartMenu();
        }

        static void Main(string[] args)
        {
            StartMenu();
        }
    }
}