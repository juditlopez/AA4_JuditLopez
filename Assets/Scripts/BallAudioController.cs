using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAudioController : MonoBehaviour
{ 
    AudioSource[] sources;
	Rigidbody rb;
	float speed;

    void Start()
    {
        sources = GetComponents<AudioSource>();
		rb = GetComponent<Rigidbody>();
		sources[0].Play();
    }
    void Update()
    {
		sources[0].pitch = (float)(rb.velocity.magnitude * rb.mass);
		speed = rb.velocity.magnitude;

    }

    void OnCollisionEnter(Collision collision)
    {
        sources[1].Play();
    }
}
