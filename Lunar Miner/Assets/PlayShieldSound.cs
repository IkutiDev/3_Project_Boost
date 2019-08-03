using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayShieldSound : MonoBehaviour
{
    public void PlayGainShieldSound()
    {
        GetComponent<AudioSource>().Play();
    }
}
