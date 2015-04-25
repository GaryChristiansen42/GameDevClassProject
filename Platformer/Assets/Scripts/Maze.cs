using UnityEngine;
using System.Collections;
using System.IO;

public class Maze : MonoBehaviour {
	//Author: Jonathan Moore
	public int sizeX, sizeY, sizeZ;
	public MazeCell cellPrefab;

	public float generationStepDelay;
	private MazeCell[,,] cells;
	private int[,,] cellPositions;

	public IEnumerator Generate (TextAsset worldFile) {
		WaitForSeconds delay = new WaitForSeconds(generationStepDelay);
		cells = new MazeCell[sizeX, sizeY ,sizeZ];

		StringReader reader = new StringReader (worldFile.text);
		string s = reader.ReadLine ();
		int posY=0;
		int posZ=0;
		while(s!=null){
			if(s!="-"){
				for(int x = 0; x<s.Length;x++){
					char c = s[x];
					if(c=='1'){
						yield return delay;
						CreateCell(x,posY,posZ);
					}
				}
				posZ++;
			}else{
				posY++;
				posZ=0;
			}
			s = reader.ReadLine();
		}
	}

	private void CreateCell (int x, int y,int z) {
		MazeCell newCell = Instantiate(cellPrefab) as MazeCell;
		cells[x, y ,z] = newCell;
		newCell.name = "Maze Cell " + x + ", " + y + ", " + z;
		newCell.transform.parent = transform;
		newCell.transform.localPosition = new Vector3(x - sizeX * 0.5f + 0.5f,  y - sizeY * 0.5f + 0.5f,z - sizeZ * 0.5f + 0.5f);
	}
	//End of Author: Jonathan Moore
}