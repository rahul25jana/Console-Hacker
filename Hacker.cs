using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{


    public int level;

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
            MainMenu("Hello Again");
        }

        else if (input == "1")
            
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
                Terminal.WriteLine("please choose valid level !");
        }

    }

     void Gamestart()
    {
        Terminal.WriteLine("you have chosen " + level);
        Terminal.WriteLine("Enter your Password");
    }
}
