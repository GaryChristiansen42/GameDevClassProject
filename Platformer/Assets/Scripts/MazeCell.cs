using UnityEngine;

public class MazeCell : MonoBehaviour {
	string blockType = "Fixed";

	void OnCollisionEnter(Collision col){
		if(blockType!="Fixed"){}
	}
}