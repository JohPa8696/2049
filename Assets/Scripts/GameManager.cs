using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Tile[] tiles = GameObject.FindObjectsOfType <Tile> ();
		foreach (Tile t in tiles) {
			t.Number = 0;
		}
			
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Move(MoveDirections md)
	{
		Debug.Log (md.ToString() + " move ");
	}
}
