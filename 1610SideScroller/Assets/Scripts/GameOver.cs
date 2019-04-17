using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameOver : MonoBehaviour
{
    public UnityEvent DeathEvent;
    public FloatData Health;

    private void Update()
    {
        if (Health.Value <= 0)
        {
            DeathEvent.Invoke();
            print("Dead Boy");
        }
    }
}
