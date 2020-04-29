using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        ShowMainMenu("Greetings Hacker");
    }
    
    void ShowMainMenu (){
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Select who's computer to hack");
        Terminal.WriteLine("1. Sports Journalist");
        Terminal.WriteLine("2. Movie Critic");
        Terminal.WriteLine("3. NASA Engineer");
        Terminal.WriteLine("Enter your selection");
    }

    void OnUserInput(string input)
    {
        if(input == 1){
            print("level 1")
        }
    }
    // Update is called once per frame
    void Update(){
        
    }
}
