using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max = 1000;
	int min = 1;
	int guess = 500;

	void Start () {
		max = max + 1;
		print ("Welcome to NumberWizard!");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number you higher or lower than " + guess);
		print ("Up arrow for higher, down for lower, return for equal");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			// print ("UpArrow has been pressed");
			min = guess;
			guess = (min + max) / 2;
			print ("Higher or lower than " + guess);
		}
		else if(Input.GetKeyDown(KeyCode.DownArrow)) {
			// print ("DownArrow has been pressed");
			max = guess;
			guess = (min + max) / 2;
			print ("Higher or lower than " + guess);
		}
		else if(Input.GetKeyDown(KeyCode.Return)) {
			print ("I've solved it");
		}
	}
}
