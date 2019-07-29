using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public GameObject Ball;
    public GameObject PlayerCamera;
    public float BallDistance = 2.5f;
    public float BallThrowingForce = 500f;

    public bool holdingball = true;
    // Start is called before the first frame update
    void Start()
    {
        Ball.GetComponent<Rigidbody>().useGravity = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (holdingball)
        {
            Ball.transform.position = PlayerCamera.transform.position + PlayerCamera.transform.forward * BallDistance;
        }

            if (Input.GetMouseButton(0))
            {
                holdingball = false;
            Ball.GetComponent<Rigidbody>().useGravity = true;
            Ball.GetComponent<Rigidbody>().AddForce (PlayerCamera.transform.forward * BallThrowingForce);
            }
    }
}
