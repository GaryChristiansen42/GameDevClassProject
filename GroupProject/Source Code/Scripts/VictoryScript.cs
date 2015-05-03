using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VictoryScript : MonoBehaviour {
	public AudioClip myAudioSource;
	
	void Update(){
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).loop = false; 
		((MovieTexture)GetComponent<Renderer> ().material.mainTexture).Play ();
	}
}
