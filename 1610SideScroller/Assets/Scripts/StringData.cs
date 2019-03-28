using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StringData : ScriptableObject
{
    [SerializeField] private string output;

    public virtual string Output
    {
        get { return output;}
        set { this.output = output; }
    }
}
