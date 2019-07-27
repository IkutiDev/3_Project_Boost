using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffStoryPanel : MonoBehaviour
{
    [SerializeField] private GameObject otherPanelToTurnOn;

    public void TurnOff()
    {
        otherPanelToTurnOn.SetActive(true);
        gameObject.SetActive(false);
    }
}
