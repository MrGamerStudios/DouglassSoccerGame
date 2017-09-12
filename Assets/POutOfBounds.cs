using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POutOfBounds : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "play")
        {
            var rigidbody = this.GetComponent<Rigidbody>();
            transform.position = GameObject.Find("PlayerPosition").transform.position;
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }
    }
}