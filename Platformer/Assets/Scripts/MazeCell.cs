using UnityEngine;

public class MazeCell : MonoBehaviour {
	public string blockType;

	private void Start(){
		//if(blockType=="Falling"){
		//	GetComponent<Rigidbody>().useGravity=true;
		//}
	}

	void OnCollisionEnter(Collision col){
		//Debug.Log ("I am being touched");
		//if(col.gameObject.tag=="Player"&&blockType=="Falling"){
		//	GetComponent<Rigidbody>().useGravity=true;
		//}
		// Destroy (this);
	}

	void OnTriggerEnter(Collider col){
		//Debug.Log ("I am being touched");
		//if(col.gameObject.tag=="Player"&&blockType=="Falling"){
		//	GetComponent<Rigidbody>().useGravity=true;
		//}
		// Destroy (this);
	}
}