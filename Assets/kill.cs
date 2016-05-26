using UnityEngine;
using System.Collections;

public class kill : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("dead",5.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void dead(){
		ActivateText.textNum = 0;
		Application.LoadLevel(0);
	}
}
