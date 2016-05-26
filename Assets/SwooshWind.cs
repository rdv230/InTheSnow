using UnityEngine;
using System.Collections;

public class SwooshWind : MonoBehaviour {

	AudioSource myAudio;
	public AudioClip Swoosh;
	float timeToSwoosh;
	float timer;

	// Use this for initialization
	void Start () {
		myAudio = GetComponent<AudioSource>();
		timeToSwoosh = 5.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		timer+= Time.deltaTime;

		if(timer >= timeToSwoosh){
			timer = 0;
			WindSound ();
			timeToSwoosh = Random.Range (9.5f,15.0f);
		}
	


	}

	void WindSound(){
		myAudio.PlayOneShot(Swoosh);
//		Debug.Log ("IS playing?");
	}

}
