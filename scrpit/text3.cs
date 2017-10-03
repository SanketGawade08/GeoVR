using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text3 : MonoBehaviour {
	List<string> thirdchoice = new List<string>(){"C.Kuwait","C.Rome","C.New Guyana","C.Jammu and Kashmir","C.Madhya Pradesh"};
	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = firstchoice[0];

	}

	// Update is called once per frame
	void Update () {
		if (testcontrol.randQuestion > -1) {

			GetComponent<TextMesh> ().text = thirdchoice [testcontrol.randQuestion];
		}

	}
		void OnMouseDown()
		{
		testcontrol.selectedAnswer = gameObject.name;
		testcontrol.choiceSelected ="y";
		}

}