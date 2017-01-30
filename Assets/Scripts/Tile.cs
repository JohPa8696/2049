using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Tile : MonoBehaviour {

	private int number;
	private Text tileText;
	private Image tileImage;



	public int Number
	{
		get
		{ return number;
		}
		set{ 
			number =value;
			if (number == 0) {
				SetEmpty ();
			} else {
				ApplyStyle (number);
				SetVisible ();
			}
		}

	}
	void Awake()
	{
		tileText = GetComponentInChildren<Text> ();
		tileImage = transform.Find ("Panel").GetComponent<Image>();
	}

	private void ApplyStyleFromHolder( int index) 
	{
		tileText.text = TileStyleHolder.instance.tileStyles [index].number.ToString();
		tileText.color = TileStyleHolder.instance.tileStyles [index].textColor;
		tileImage.color = TileStyleHolder.instance.tileStyles [index].tileColor;

	}

	private void ApplyStyle(int num)
	{
		switch (num) {
		case 2: 
			ApplyStyleFromHolder (0);
			break;
		case 4: 
			ApplyStyleFromHolder (1);
			break;
		case 8: 
			ApplyStyleFromHolder (2);
			break;
		case 16: 
			ApplyStyleFromHolder (3);
			break;
		case 32: 
			ApplyStyleFromHolder (4);
			break;
		case 64: 
			ApplyStyleFromHolder (5);
			break;
		case 128: 
			ApplyStyleFromHolder (6);
			break;
		case 256: 
			ApplyStyleFromHolder (7);
			break;
		case 512: 
			ApplyStyleFromHolder (8);
			break;
		case 1024: 
			ApplyStyleFromHolder (9);
			break;
		case 2048: 
			ApplyStyleFromHolder (10);
			break;
		case 4096: 
			ApplyStyleFromHolder (11);
			break;
		default:
			Debug.Log ("Invalid number : " + num.ToString());
			break;
		}

	}

	private void SetVisible()
	{
		tileImage.enabled = true;
		tileText.enabled = true;

	}

	private void SetEmpty() {
		tileImage.enabled = false;
		tileText.enabled = false;	
	}


}
