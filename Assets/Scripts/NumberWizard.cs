using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;

	void Start () {
		StartGame();
	}
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		print ("++_+_+__+==================================================");
		print ("Welcome to NumberWizard!");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number you higher or lower than " + guess);
		print ("Up arrow for higher, down for lower, return for equal");
		max = max + 1;		
	}
	// Update is called once per frame
	void NextGuess (){
		guess = (min + max) / 2;
		print ("Higher or lower than " + guess);
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			// print ("UpArrow has been pressed");
			min = guess;
			NextGuess();
		}
		else if(Input.GetKeyDown(KeyCode.DownArrow)) {
			// print ("DownArrow has been pressed");
			max = guess;
			NextGuess();
		}
		else if(Input.GetKeyDown(KeyCode.Return)) {
			print ("I've solved it");
			StartGame();
		}
	}
}
