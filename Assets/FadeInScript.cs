using UnityEngine;
using System.Collections;

public class FadeInScript : MonoBehaviour {

	TextMesh thisText;
	protected bool isFading;
	float alpha;
	Vector4 color;
	AudioSource mySource;
	public AudioClip creepySound;
	bool hasPlayed = false;

	// Use this for initialization
	void Start () {
		thisText = GetComponent<TextMesh>();
		isFading = false;
		mySource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	

		if(!hasPlayed && isFading && thisText.color.a < 255){
//			Debug.Log("is this happening?");
			mySource.PlayOneShot(creepySound);
			alpha+=Time.deltaTime*10;
			//alpha = Mathf.Lerp (0,100, Time.deltaTime/10);
			hasPlayed =true;
			}
		color = new Vector4(thisText.color.r,thisText.color.g,thisText.color.b,alpha);
		thisText.color = color;

	}

	void OnTriggerEnter(Collider coll){
//		Debug.Log ("THIS IS HAPPENING");
		if(!isFading){
			isFading = true;
		}
	}

}
