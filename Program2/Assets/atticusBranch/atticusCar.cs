using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class atticusCar : MonoBehaviour
{
    public AudioSource woowooTurnSound;
    public Rigidbody turnCar;
    public GameObject attCar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (attCar.activeSelf)
            {

            float speed = turnCar.velocity.magnitude;
            float pitch = speed;
            woowooTurnSound.pitch = pitch;

            }

    }
}
