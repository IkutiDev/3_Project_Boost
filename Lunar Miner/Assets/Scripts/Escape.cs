using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[DisallowMultipleComponent]
public class Escape : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (PlayerPrefs.GetInt("EndingZero") != 1)
        {
            SceneManager.LoadScene("Level 0 Go Farming");
            PlayerPrefs.SetInt("EndingZero", 1);
        }
    }
}
