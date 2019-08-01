using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRocket : MonoBehaviour
{
    [SerializeField] private GameObject rocket;
    // Update is called once per frame
    void Update()
    {
        transform.position =new Vector3(rocket.transform.position.x,rocket.transform.position.y,transform.position.z);
    }
}
