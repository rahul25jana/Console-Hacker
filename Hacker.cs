using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{


     int level;
    private string password1 = "1bank4";
    private string password2 = "1airport7";
    private string password3 = "1spaceX6";

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
            CurrScreen = GameScreen.PassKey;
            Gamestart();
        }
        else if (input == "2")

        {
            level = 2;
            CurrScreen = GameScreen.PassKey;
            Gamestart();
        }
        else if (input == "3")

        {
            level = 3;
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
        Terminal.WriteLine("Enter your Password : ");

      
    }

    void KeyRun(string input)
    {
        if(input == password1)
        {
            Terminal.WriteLine("good job");
        }
        else if (input == password2)
        {
            Terminal.WriteLine("very good job");
        }
        else if  (input == password3)
        {
            Terminal.WriteLine("excellent job");
        }

        else
        {
            Terminal.WriteLine("Try again:");
        }

    }
 
}




