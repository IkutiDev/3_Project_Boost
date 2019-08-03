using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayShieldSound : MonoBehaviour
{
    private bool hasPlayed;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") && !hasPlayed)
        {
            GetComponent<AudioSource>().Play();
            hasPlayed = true;
        }
    }
}
