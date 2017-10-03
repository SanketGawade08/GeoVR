using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text1 : MonoBehaviour {
	List<string> firstchoice = new List<string>(){"A.India","A.Paris","A.Sri-lanka","A.Assam","A.Maharashtra"};
	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = firstchoice[0];

	}

	// Update is called once per frame
	void Update () {
		if (testcontrol.randQuestion > -1) {
		
			GetComponent<TextMesh> ().text = firstchoice [testcontrol.randQuestion];
		}
	}
		void OnMouseDown()
		{
			testcontrol.selectedAnswer = gameObject.name;
			testcontrol.choiceSelected ="y";
 		}
		
}