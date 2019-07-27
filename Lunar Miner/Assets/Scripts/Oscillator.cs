using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour
{
    [SerializeField] private Vector3 movementVector3;
    // Start is called before the first frame update

    //todo remove from inspector later
    [Range(0,1)]
    [SerializeField]private float movementFactor;

    private Vector3 startingPos;
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = movementVector3 * movementFactor;
        transform.position = startingPos + offset;
    }
}
