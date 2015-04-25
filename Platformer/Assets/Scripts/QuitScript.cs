using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuitScript : MonoBehaviour {
	
	public AudioClip sound1;
	
	public Graphic text;
	
	
	public void OnMouseEnter(){
		text.color = Color.white;
	}
	
	public void OnMouseExit(){
		text.color = Color.black;
	}
	
	public void OnMouseUp(){
		Invoke ("PlaySound", 0);
		Invoke ("NewScene", 2); 
	}
	
	void PlaySound(){
		GetComponent<AudioSource>().PlayOneShot(sound1);
	}
	
	void NewScene(){
		Application.Quit ();
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
