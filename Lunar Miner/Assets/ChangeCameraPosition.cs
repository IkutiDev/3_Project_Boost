using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraPosition : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (Camera.main != null) Camera.main.transform.position = new Vector3(1.3f, 30.16f, -56.78f);
        transform.GetComponent<ChangeCameraPosition>().enabled = false;
    }
}
