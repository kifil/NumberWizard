using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	//declare global variables
	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		//only happens at the very beginning of the program
		StartGame();	
	}
	
	//set up a new game
	void StartGame(){
		max = 1000;
		min = 1;
		guess = 500;
		
		print ("========================");
		print("Welcome to number wizard!");
		print ("Pick a number in your head, but don't tell me...");
		
		print("the highest number you can pick is " + max);
		print("the lowest number you can pick is " + min);
		
		print("Is your number higher or lower than " + guess + "?");
		
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update (){
		
		//get player input
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			min = guess;
			NextGuess();
		}else if(Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			NextGuess();
		}else if(Input.GetKeyDown(KeyCode.Return)){
			print("I won! Restarting the game");
			StartGame();
		}
	}
	
	//update after every guess
	void NextGuess(){
		guess = ((max + min) / 2);
		print("higher or lower than " + guess + "?");
		print("Up = higher, down = lower, return = equal");
	}
}
