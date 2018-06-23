using UnityEngine;

public class Hacker : MonoBehaviour
{

    string[] Level1_passwordsBank = { "Systems","Cameras","BankVault","Locker","ATM" };
    string[] Level2_passwordsAirport = {"Pilots","CrewControl","BookTickets","FlightDatabase","LightSignal"  };
    string[] Level3_passwordsSpaceX = { "MuskBankAccount","SatelliteSignal","Tesla","RocketControl","Connections" };

     int level;
    string password;
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
            password = Level1_passwordsBank[Random.Range(0,Level1_passwordsBank.Length)];
            CurrScreen = GameScreen.PassKey;
            Gamestart();
        }
        else if (input == "2")

        {
            level = 2;
            password = Level2_passwordsAirport[Random.Range(0,Level2_passwordsAirport.Length)];
            CurrScreen = GameScreen.PassKey;
            Gamestart();
        }
        else if (input == "3")

        {
            level = 3;
            password = Level3_passwordsSpaceX[Random.Range(0,Level3_passwordsSpaceX.Length)];
            CurrScreen = GameScreen.PassKey;
            Gamestart();
        }

        else
        {
            Terminal.WriteLine("Enter the valid level!");
        }
    }

    void Gamestart()
    {
        Terminal.WriteLine("you have selected level :  " + level);
        Terminal.ClearScreen();
        Terminal.WriteLine("Enter your Password : ");

        
    }

    void KeyRun(string input)
    {
        if(input == password )
        {
            Terminal.WriteLine("good job");
        }
        else if (input == password)
        {
            Terminal.WriteLine("very good job");
        }
        else if  (input == password)
        {
            Terminal.WriteLine("excellent job");
        }

        else
        {
            Terminal.WriteLine("Try again:");
        }

    }
 
}




