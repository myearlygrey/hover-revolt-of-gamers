using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public Transform kartModel;
    public Transform kartNormal;
    public Rigidbody sphere;

    float speed, currentSpeed;
    float rotate, currentRotate;

    public float acceleration = 30f;
    public float steering = 80f;
    public float gravity = 10f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Hint: The global static variable "Terrain.activeTerrain" 
        // may be helpful or have useful methods for user here or in
        // other scripts.
        //Terrain terrain = Terrain.activeTerrain;
        transform.position = sphere.transform.position; //- new Vector3(0, .2f, 0);
        
        if (Input.GetKey (KeyCode.W))
            { 
                speed = acceleration;
            }
            
        if (Input.GetAxis("Horizontal") != 0)
        {
            int dir = Input.GetAxis("Horizontal") > 0 ? 1 : -1;
            float amount = Mathf.Abs((Input.GetAxis("Horizontal")));
            Steer(dir, amount);

        }
        currentSpeed = Mathf.SmoothStep(currentSpeed, speed, Time.deltaTime * 12f); //speed = 0f;
        currentRotate = Mathf.Lerp(currentRotate, rotate, Time.deltaTime * 4f); rotate = 0f;

    }
    private void FixedUpdate()
    {
        //forward accel
        sphere.AddForce(kartModel.transform.forward * currentSpeed, ForceMode.Acceleration);
        //gravity
        sphere.AddForce(Vector3.down * gravity, ForceMode.Acceleration);
        //steering
        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, transform.eulerAngles.y + currentRotate, 0), Time.deltaTime * 5f);

        RaycastHit hitOn;
        RaycastHit hitNear;

        Physics.Raycast(transform.position, Vector3.down, out hitOn, 1.1f);
        Physics.Raycast(transform.position, Vector3.down, out hitNear, 2.0f);

        kartModel.parent.up = Vector3.Lerp(kartModel.parent.up, hitNear.normal, Time.deltaTime * 8.0f);
        kartModel.parent.Rotate(0, transform. eulerAngles.y,0);


    }
    public void Steer(int direction, float amount)
    {
        rotate = (steering * direction) * amount;
    }
}
