using UnityEngine;
using System.Collections;

public class rotateObj : MonoBehaviour {

	public float rotSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(Vector3.up,Time.deltaTime * rotSpeed,Space.World);
	}
}
