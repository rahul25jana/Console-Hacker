using UnityEngine;

public class Hacker : MonoBehaviour
{

    string[] Level1_passwordsBank = { "Systems","Cameras","BankVault","Locker","ATM" };
    string[] Level2_passwordsAirport = {"Pilots","CrewControl","BookTickets","FlightDatabase","LightSignal"  };
    string[] Level3_passwordsSpaceX = { "MuskBankAccount","SatelliteSignal","Tesla","RocketControl","Connections" };

    const string Hint_Menu = "Type Menu if you are afraid";
    int level;
    string password1, password2, password3;
    public enum GameScreen {MainMenu, PassKey, Win };
    GameScreen CurrScreen = GameScreen.MainMenu;
	// Use this for initialization
	void Start () 
    {
        MainMenu("Hello Anonymous,");
	}

    void MainMenu(string welcome)

    {
        Terminal.ClearScreen();
        Terminal.WriteLine(welcome);
        Terminal.WriteLine("There is only one way,hack and escape or get caught");
        Terminal.WriteLine("\nPress 1 for the Bank ");
        Terminal.WriteLine("Press 2 for the Airport ");
        Terminal.WriteLine("Press 3 for the SpaceX ");
        Terminal.WriteLine("Enter your choice: ");  
    }

     void OnUserInput(string input)  // outer messages
    {
        if (input == "menu")

        {
            CurrScreen = GameScreen.MainMenu;
            level = 0;
            MainMenu("Hello Again, Stranger");
        }

        else if (input=="exit" ||input == "close"||input == "quit")
        {
            Application.Quit();
        }

        else if (CurrScreen == GameScreen.MainMenu)
        {
            NewRunMenu(input);
        }

        else if(CurrScreen == GameScreen.PassKey)
        {
            KeyRun(input);
        }

    }

    void NewRunMenu(string input)
    {
        if (input == "1")
            
        {
            level = 1;
            password1 = Level1_passwordsBank[Random.Range(0,Level1_passwordsBank.Length)];
            CurrScreen = GameScreen.PassKey;
            Terminal.WriteLine("Enter your Password - Hint : " + password1.Anagram());
            Terminal.WriteLine(Hint_Menu);
      //      Gamestart();
        }
        else if (input == "2")

        {
            level = 2;
            password2 = Level2_passwordsAirport[Random.Range(0,Level2_passwordsAirport.Length)];
            CurrScreen = GameScreen.PassKey;
            Terminal.WriteLine("Enter your Password - Hint : " + password2.Anagram());
            Terminal.WriteLine(Hint_Menu);

            //Gamestart();
        }
        else if (input == "3")

        {
            level = 3;
            password3 = Level3_passwordsSpaceX[Random.Range(0,Level3_passwordsSpaceX.Length)];
            CurrScreen = GameScreen.PassKey;
            Terminal.WriteLine("Enter your Password - Hint : " + password3.Anagram());
            Terminal.WriteLine(Hint_Menu);

           // Gamestart();
        }

        else
        {
            Terminal.WriteLine("Enter the valid level!");
        }
    }

    //void Gamestart()
    //{
    //    //Terminal.WriteLine("you have selected level :  " + level);
    //    //Terminal.ClearScreen();
    //    Terminal.WriteLine("Enter your Password - Hint : " + password1.Anagram());
    //    Terminal.WriteLine("Enter your Password - Hint : " + password2.Anagram());
    //    Terminal.WriteLine("Enter your Password - Hint : " + password3.Anagram());

    //}

    void KeyRun(string input)
    {
        if(input == password1 )
        {
            Terminal.WriteLine("good job");
            ScreenWin_1();
        }
        else if (input == password2)
        {
            Terminal.WriteLine("very good job");
            ScreenWin_2();
        }
        else if  (input == password3)
        {
            Terminal.WriteLine("excellent job");
            ScreenWin_3();
        }
        else
        {
            Terminal.WriteLine("Try again:");
        }

    }

    void ScreenWin_1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Congrats");
        Terminal.WriteLine(@" 
   _______________          
  |  ___________  |        
  | |           | |        
  | |   0   0   | |        
  | |     -     | |        
  | |   \___/   | |       
  | |___     ___| |        
  |_____|\_/|_____|       
    _|__|/ \|_|_.....
   / ********** \         
 /  ************  \  ");

        CurrScreen = GameScreen.Win;

    }

    void ScreenWin_2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Congrats, Very Good");
        Terminal.WriteLine(@" 
 __  _
 \ `/ |
  \__`!
  / ,' `-.__________________
 '-'\_____                LI`-.
    <____()-=O=O=O=O=O=[]====--)
      `.___ ,-----,_______...-'
           /    .'
          /   .'
         /  .'         
         `-'
");

        CurrScreen = GameScreen.Win;

    }

    void ScreenWin_3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Congrats, you did excellent job");
        Terminal.WriteLine(@" 
           ___
     |     | |
    / \    | |
   |--o|===|-|
   |---|   |S|
  /     \  |P|
 |       | |A|
 |       |=|C|
 |       | |E|
 |_______| |_|
  |@| |@|  | |
___________|_|_
");

        CurrScreen = GameScreen.Win;

    }

 

}




