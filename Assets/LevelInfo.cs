using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInfo {
	private System.Random rnd = null;

	public class CellInfo {
		public GameObject ptr = null;	
	}

	public LevelInfo() {
		rnd = new System.Random ();
	}

	public void CreateObjects() {
		
		GameObject gRoot = GameObject.Find ("Root");
		Object wallTile = Resources.Load ("wall_tile");
		Object floorTile = Resources.Load ("floor_tile");

		for (int i = 0; i < 10; i++)
			for (int q = 0; q < 10; q++) {
				bool passable = rnd.Next(100) > 50;
				GameObject o = null;

				if(passable)
					o = GameObject.Instantiate (wallTile, new Vector3 (i * 1.2f, 0, q * 1.2f), Quaternion.identity, gRoot.transform) as GameObject;
				else
					o = GameObject.Instantiate (floorTile, new Vector3 (i * 1.2f, 0, q * 1.2f), Quaternion.identity, gRoot.transform) as GameObject;


			}
	}
}
