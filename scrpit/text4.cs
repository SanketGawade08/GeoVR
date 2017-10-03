using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text4 : MonoBehaviour {
	List<string> fourthchoice = new List<string>(){"D.China","D.London","D.Kuwait","D.Meghalaya","D.Assam"};
	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = firstchoice[0];

	}

	// Update is called once per frame
	void Update () {
		if (testcontrol.randQuestion > -1) {

			GetComponent<TextMesh> ().text = fourthchoice [testcontrol.randQuestion];
		}

	}
		void OnMouseDown()
		{
		testcontrol.selectedAnswer = gameObject.name;
		testcontrol.choiceSelected ="y";
		}


}