using UnityEngine;
using System.Collections;

public class Lava : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).loop = true; 
		((MovieTexture)GetComponent<Renderer> ().material.mainTexture).Play ();
	}
}
