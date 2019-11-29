using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WalkingBlock : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce;

    void FixedUpdate(){
        rb.AddForce(0,0, -forwardForce * Time.deltaTime);
    }

}
