using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {
	public AudioClip myAudioSource;

	void Update(){
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).loop = true; 
		((MovieTexture)GetComponent<Renderer> ().material.mainTexture).Play ();
	}
}
