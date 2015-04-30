using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HowToScript : MonoBehaviour {
	
	public AudioClip sound1; 
	
	public Graphic text;

	void Start () {
		Screen.lockCursor = false;
	}

	public void OnMouseEnter(){
		text.color = Color.white;
	}
	
	public void OnMouseExit(){
		text.color = Color.black;
	}
	
	public void OnMouseUp(){
		Invoke ("PlaySound", 0);
		Invoke ("NewScene", 1); 
	}
	
	void PlaySound(){
		GetComponent<AudioSource>().PlayOneShot(sound1);
	}
	
	void NewScene(){
		Application.LoadLevel ("HowToPlay");
	}
	
	public void Update(){
		bool hovered = false;
		
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		foreach(RaycastHit hit in Physics.RaycastAll (ray))
		{
			if (hit.collider == GetComponent<Collider>())
			{
				hovered = true;
				break;
			}
		}
		if (hovered) {
		}
	}
}