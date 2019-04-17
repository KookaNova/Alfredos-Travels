using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAnims : MonoBehaviour
{
    public float Speed;
    private Animator _anims;

    private void Start()
    {
        _anims = GetComponent<Animator>();
    }

    private void Update()
    {
        _anims.SetFloat("Speed", Speed);
    }
}

    
