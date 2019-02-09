using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatyRoller : RollerEnemy
{
    public Color MeatColor;

    void Start()
    {
        GetComponent<SpriteRenderer>().color = MeatColor;
    }
}