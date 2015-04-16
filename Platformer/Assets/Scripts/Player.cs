using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public PlayerBody bodyPrefab;
	public Camera cameraPrefab;
	/*public IEnumerator Generate(){
		CreateBody ();
		CreateCamera ();
	}*/
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKeyDown(KeyCode.A)){
			Debug.Log("You pressed A");
		}else if(Input.GetKeyDown(KeyCode.W)){
			Debug.Log("You pressed W");
		}else if(Input.GetKeyDown(KeyCode.D)){
			Debug.Log("You pressed D");
		}else if(Input.GetKeyDown(KeyCode.S)){
			Debug.Log("You pressed S");
		}
		if(Input.GetKeyDown(KeyCode.Space)){
			Debug.Log("You pressed Space");
		}
	}
	private void CreateBody(){
		PlayerBody newBody = Instantiate (bodyPrefab) as PlayerBody;
		newBody.transform.parent = transform;
		newBody.transform.localPosition = new Vector3(0f,  0f,0f);
	}
	private void CreateCamera(){
		Camera newCamera = Instantiate (cameraPrefab) as Camera;
		newCamera.transform.parent = transform;
		newCamera.transform.localPosition = new Vector3(0f, 0f,0.5f);
	}
}
