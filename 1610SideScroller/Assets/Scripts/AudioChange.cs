using UnityEngine;
using System.Collections;
 
[RequireComponent(typeof(AudioSource))]
public class AudioChange : MonoBehaviour
{
    public AudioSource AudioSource1, AudioSource2;
    private bool _switchingAudio;

    private void FixedUpdate()
    {
        if (!AudioSource1.isPlaying && !_switchingAudio)
        {
            AudioSource2.Play();
            _switchingAudio = true;
        }
    }
    
    //adapted from Unity Answers
}