using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActivateText : MonoBehaviour {
	
	Text onScreenText;
	AudioSource myAudio;
	public AudioClip selectSound;
	protected bool isActivated;
	public static int textNum = 0;
	public string[] Strings;
	public AudioSource clickySource;
	public AudioClip clicky;


	// Use this for initialization
	void Start () {
		onScreenText = GameObject.Find ("Canvas").GetComponentInChildren<Text>();
		myAudio = GetComponent<AudioSource>();
		isActivated = false;

	}
	
	// Update is called once per frame
	void Update () {
//		if(Input.GetKeyUp(KeyCode.Q)){
//			textNum++;
//			Debug.Log (textNum);
//		}
	
	}

	void OnTriggerEnter(Collider col){
		if(!isActivated){

			myAudio.PlayOneShot(selectSound, 1.0F);
			Debug.Log ("Sound is Playing");
			ShowText(textNum);
			isActivated = true;
			if(textNum >= 10){
			}else{	
				textNum++;
			}


		}
	}

	void ShowText(int textNum){
		StartCoroutine(WriteText(onScreenText,Strings[textNum],.09f));


	}

	
	IEnumerator WriteText(Text obj, string text, float speed) {
		//Debug.Log("sadlkfjaflkj");
		char[] singleChar = text.ToCharArray();
		for (int i = 0; i < singleChar.Length; i++) {
			obj.text += singleChar[i];
			if(singleChar[i]%5 == 0){
				clickySource.PlayOneShot(clicky);
			}
			yield return new WaitForSeconds(speed);
		}
		yield return new WaitForSeconds (3);
		obj.text = "";
	}
}


