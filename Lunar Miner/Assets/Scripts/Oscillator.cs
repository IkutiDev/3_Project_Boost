using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour
{
    [SerializeField] private Vector3 movementVector3 = new Vector3(10,10,10);

    [SerializeField] private float period = 2f;
    // Start is called before the first frame update
    private const float Tau = Mathf.PI * 2; // about 6.28
    //todo remove from inspector later
    private float movementFactor;

    private Vector3 startingPos;
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (period <= Mathf.Epsilon)
            return;
        float cycles = Time.time / period; // grows continually from 0
        float rawSinWave = Mathf.Sin(cycles * Tau);

        Debug.Log(rawSinWave);
        movementFactor = rawSinWave / 2f+0.5f;
        Vector3 offset = movementVector3 * movementFactor;
        transform.position = startingPos + offset;
    }
}
