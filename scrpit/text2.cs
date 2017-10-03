using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text2 : MonoBehaviour {
	List<string> secondchoice = new List<string>(){"B.New Guyana","B.New york","B.India","B.Kerala","B.Haryana"};
	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = firstchoice[0];

	}

	// Update is called once per frame
	void Update () {
		if (testcontrol.randQuestion > -1) {

			GetComponent<TextMesh> ().text = secondchoice [testcontrol.randQuestion];
		}


	}
		void OnMouseDown()
		{
		testcontrol.selectedAnswer = gameObject.name;
		testcontrol.choiceSelected ="y";
		}
			
}