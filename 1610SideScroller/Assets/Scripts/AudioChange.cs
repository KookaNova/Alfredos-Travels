using UnityEngine;
using System.Collections;
 
[RequireComponent(typeof(AudioSource))]
public class AudioChange : MonoBehaviour
{
    public AudioSource AudioIntro, AudioLoop;
    private bool _looping;

    private void FixedUpdate()
    {
        if (!AudioIntro.isPlaying && !_looping)
        {
            AudioLoop.Play();
            _looping = true;
        }
    }
    
    //adapted from Unity Answers
}