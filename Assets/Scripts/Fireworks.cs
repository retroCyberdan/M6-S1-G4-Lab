using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireworks : MonoBehaviour
{
    [SerializeField] private ParticleSystem _pS1;
    [SerializeField] private ParticleSystem _pS2;
    [SerializeField] private ParticleSystem _pS3;

    void Awake()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && _pS1.isStopped)
        {
            _pS1.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && _pS2.isStopped)
        {
            _pS2.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && _pS3.isStopped)
        {
            _pS3.Play();
        }
    }
}
