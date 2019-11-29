using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public Rigidbody rb;
    private bool statusArrow= false;
    private int nextUpdate=2;
    public float forwardForce=20000f;
    public float sideForce=500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>=nextUpdate){
            //  Debug.Log(Time.time+">="+nextUpdate);
             // Change the next update (current second+1)
             nextUpdate=Mathf.FloorToInt(Time.time)+1;
             // Call your fonction
             UpdateEverySecond();
        }
    }

    // metod masih kacau
    // diimplementasi di level 9, bluesphere(1)
    void UpdateEverySecond(){
        statusArrow = !statusArrow;
        // curVector = rb.position;
        if(statusArrow== false) {

        }
        else {
            rb.AddForce(-sideForce,0,0);
            rb.AddForce(0,0,0);
        }
        
    }
}
