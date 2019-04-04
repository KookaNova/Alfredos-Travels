using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameOver : MonoBehaviour
{
    public UnityEvent DeathEvent;
    public FloatData Health;

    public void Death()
    {
        if (Health.Value <= 0f)
        {
            DeathEvent.Invoke();
            print("Dead Boy");
        }
    }
}
