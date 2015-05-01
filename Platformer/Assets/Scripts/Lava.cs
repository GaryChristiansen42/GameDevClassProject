using UnityEngine;
using System.Collections;

public class Lava : MonoBehaviour {
	public float lavaTimeStart;
	float lavaTimer = 0.0f;
	public float lavaSpeed;
	void Update () {
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).loop = true; 
		((MovieTexture)GetComponent<Renderer> ().material.mainTexture).Play ();
		if(lavaTimer>lavaTimeStart){
			this.transform.localPosition = new Vector3(this.transform.position.x,
			                                           (lavaSpeed*Time.deltaTime+this.transform.position.y),
			                                           this.transform.position.z); 
		}
		if(lavaTimer<=lavaTimeStart){
			lavaTimer += Time.deltaTime;
		}
	}

	void OnCollisionEnter(Collision col){
		Debug.Log ("Hitting something");
		if(col.gameObject.tag == "Player"){
			Debug.Log ("You are hitting the player");
			Application.LoadLevel("GameOver");
		}
	}
}