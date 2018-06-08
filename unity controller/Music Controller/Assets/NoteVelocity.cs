using UnityEngine;
using System.Collections;

public class NoteVelocity : MonoBehaviour
{
    // The Velocity (can be set from Inspector)
    public Vector3 velocity;

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = velocity;
    }
}
