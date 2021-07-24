using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalHolderKirmizi : MonoBehaviour
{
    public AudioSource crowd_audio;
    public static int kýrmýzýtakýmgol;
 
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            kýrmýzýtakýmgol++;
        crowd_audio.Play();
        }
        

    }
}
