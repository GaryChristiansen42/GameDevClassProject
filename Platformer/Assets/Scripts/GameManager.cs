using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	//Author: Jonathan Moore
	public Maze mazePrefab;
	private Maze mazeInstance;
	public Lava lavaPrefab;
	private Lava lavaInstance;
	//public Player playerPrefab;
	//private Player playerInstance;

	public TextAsset worldFile;

	private void Start () {
		BeginGame();
	}
	
	private void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			RestartGame();
		}else if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
	}

	private void BeginGame () {
		mazeInstance = Instantiate(mazePrefab) as Maze;
		StartCoroutine(mazeInstance.Generate(worldFile));
		lavaInstance = Instantiate (lavaPrefab) as Lava;
		//playerInstance = Instantiate (playerPrefab) as Player;
		//StartCoroutine (playerInstance.Generate());
	}

	private void RestartGame () {
		StopAllCoroutines();
		Destroy(mazeInstance.gameObject);
		//Destroy(playerInstance.gameObject);
		BeginGame();
	}
	//End Author of Jonathan Moore
}