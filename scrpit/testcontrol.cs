using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testcontrol : MonoBehaviour {
	List<string> questions = new List<string>(){"Beijing is the capital of which country?","What is the capital of Italy? ","Delhi is the capital of which country? ","Which state in India that produces Coffee ","The state having a largest production of sugarcane "};

	List<string> correctAnswer = new List<string>(){"4","3","2","2","1"};

	public Transform resultObj;

	public static string selectedAnswer;

	public static string choiceSelected="n";

	public static int randQuestion=-1;

	// Use this for initialization

	void Start () {
		//GetComponent<TextMesh> ().text = questions [0];

	}
	
	// Update is called once per frame
	void Update () {
		if (randQuestion ==-1)
		{
			randQuestion = Random.Range (0,5);
		}
		if (randQuestion>-1)
		{
			GetComponent<TextMesh> ().text = questions [randQuestion];
		}

		if (choiceSelected == "y") { 

			choiceSelected = "n";

			if (correctAnswer [randQuestion] == selectedAnswer) {

				resultObj.GetComponent<TextMesh> ().text = "Correct";
			}
			else
			{

				resultObj.GetComponent<TextMesh> ().text = "Incorrect";
			}
		}
		
	}
}
