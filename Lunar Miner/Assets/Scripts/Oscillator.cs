using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour
{
    enum transformVector
    {
        Position,
        Rotation,
        Scale
    }
    [SerializeField] private Vector3 movementVector3 = new Vector3(10,10,10);
    [SerializeField] private transformVector oscillatorVectorType;
    [SerializeField] private float period = 2f;
    // Start is called before the first frame update
    private const float Tau = Mathf.PI * 2; // about 6.28
    //todo remove from inspector later
    private float movementFactor;

    private Vector3 startingPos;
    void Start()
    {
        switch (oscillatorVectorType)
        {
            case transformVector.Position:
                startingPos = transform.position;
                break;
            case transformVector.Rotation:
                startingPos = new Vector3(transform.rotation.x,transform.rotation.y,transform.rotation.z);
                break;
            case transformVector.Scale:
                startingPos = transform.localScale;
                break;
        }
        
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
        switch (oscillatorVectorType)
        {
            case transformVector.Position:
                transform.position = startingPos + offset;
                break;
            case transformVector.Rotation:
                Vector3 v3 = startingPos + offset;
                Quaternion rot = Quaternion.Euler(v3.x,v3.y,v3.z);
                transform.rotation = rot;
                break;
            case transformVector.Scale:
                transform.localScale= startingPos + offset;
                break;
        }
        
    }
}
