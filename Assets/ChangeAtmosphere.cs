using UnityEngine;
using System.Collections;

public class ChangeAtmosphere : MonoBehaviour {

	AudioSource myAudioSource;
	public AudioClip[] music;
	ParticleSystem Fog;
	public GameObject Obelisk;

	// Use this for initialization
	void Start () {
		Fog = GameObject.Find ("Fog").GetComponent<ParticleSystem>();
		myAudioSource = GetComponent<AudioSource>();
		myAudioSource.clip = music[0];
		myAudioSource.Play();

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Alpha1)){
			ActivateText.textNum++;
			Debug.Log(ActivateText.textNum);
			
		}

		if(ActivateText.textNum > 9){

			for(int i=0;i<GameObject.FindGameObjectsWithTag("Finish").Length;i++){
				GameObject obj = GameObject.FindGameObjectsWithTag("Finish")[i] as GameObject;
				obj.GetComponent<MeshRenderer>().enabled = false;
			}

			myAudioSource.clip = music[1];
			myAudioSource.volume = 1.0f;
			myAudioSource.Play();
			Fog.loop = false;
			Obelisk.SetActive(true);
		}
	
	}
}
