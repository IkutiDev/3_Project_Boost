using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] private float rcsThrust = 100f;
    [SerializeField] private float mainThrust = 600f;
    private Rigidbody _rigidBody;
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Thrust();
        Rotate();
    }

    private void Thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidBody.AddRelativeForce(Vector3.up* mainThrust);
            if (!_audioSource.isPlaying)
            {
                _audioSource.Play();
            }
        }
        else
        {
            _audioSource.Stop();
            //StartCoroutine(VolumeFade(_audioSource, 0f, soundFadeLength));
        }
    }
    private void Rotate()
    {

        _rigidBody.freezeRotation = true;
        float rotationThisFrame = rcsThrust * Time.deltaTime;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * rotationThisFrame);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward * rotationThisFrame);
        }
        _rigidBody.freezeRotation = false;
    }

    private IEnumerator VolumeFade(AudioSource audioSource,float endVolume,float fadeLength)
    {
        float startVolume = audioSource.volume;
        float startTime = Time.time;
        while (Time.time < startTime+fadeLength)
        {
            audioSource.volume = startVolume + (endVolume - startVolume) * ((Time.time - startTime) / fadeLength);
            yield return null;
        }

        if (endVolume <= 0)
        {
            audioSource.Stop();
        }
    }
}
