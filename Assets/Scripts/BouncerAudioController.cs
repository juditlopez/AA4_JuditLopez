using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncerAudioController : MonoBehaviour
{ 
    AudioSource[] sources;
	Rigidbody rb;
	float speed;

    void Start()
    {
        sources = GetComponents<AudioSource>();
		rb = GetComponent<Rigidbody>();
		sources[1].pitch = 0.5f;
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
