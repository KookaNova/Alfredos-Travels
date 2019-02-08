using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
	public string Name;
	public Color MainColor;
	void Start()
	{
		GetComponent<SpriteRenderer>().color = MainColor;
	}

	void Update() 
	{
		transform.Rotate(0,1,0);
	}
}
