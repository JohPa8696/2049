﻿using UnityEngine;
using System.Collections;

[System.Serializable ]
public class TileStyle
{
	public int number;
	public Color32 tileColor;
	public Color32 textColor;

}

public class TileStyleHolder : MonoBehaviour {

	public static TileStyleHolder instance;

	public TileStyle[] tileStyles;

	void Awake()
	{
		instance = this;
	}
}
