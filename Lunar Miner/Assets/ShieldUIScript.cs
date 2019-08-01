using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldUIScript : MonoBehaviour
{

    private void Start()
    {
        ChangeShield(PlayerPrefs.GetInt("Shield"));
    }

    public void ChangeShield(int newShieldValue)
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<Image>().enabled = false;
        }

        foreach (Transform child in transform)
        {
            if (newShieldValue > 0)
            {
                newShieldValue--;
                child.GetComponent<Image>().enabled=true;
            }
        }
    }

}
