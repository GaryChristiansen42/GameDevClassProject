using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	public Texture[] frames;
	public int framesPerSecond = 7;
	// public Texture texture;

	public Camera foregroundCamera;

	public Vector2 drawPosition;

	/*public void Update() {
		// Debug.Log ("1");
		int index = (int)(Time.time * framesPerSecond) % frames.Length;
		// image.sprite = frames[index];
		texture = frames[index];
	}*/

	void OnGUI()
	{
		GUI.depth = 0;
		GUI.DrawTexture(new Rect(drawPosition.x, drawPosition.y, frames[0].width*4, frames[0].height*4), frames[(int)(Time.time * framesPerSecond) % frames.Length]);
		//GUI.depth = 1;


		if (Event.current.type == EventType.Repaint){
			foregroundCamera.Render();
		}
	}
}
