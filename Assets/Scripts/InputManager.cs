using UnityEngine;
using System.Collections;

[System.Serializable]
public enum MoveDirections
{
	Left, Right, Up, Down
}

public class InputManager : MonoBehaviour {

	private GameManager gm;

	void Awake()
	{
		gm = GameObject.FindObjectOfType<GameManager > ();

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			gm.Move (MoveDirections.Right);
		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			gm.Move (MoveDirections.Left);
		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			gm.Move (MoveDirections.Up);
		} else if (Input.GetKeyDown (KeyCode.DownArrow )) {
			gm.Move (MoveDirections.Down);
		}


			
	}
}
