using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mammals : Animal
{
	public int FurCount = 10000;
	public float EatingSpeed = 0.4f;
	public bool CanEat = true;
	public UnityEvent Event;
	

	void Start()
	{
		Event.Invoke();
	}
	
	void Update() 
	{
		
	}
}
