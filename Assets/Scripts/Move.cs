using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    public Vector2 moveValue;
    public float speed;
    public Vector3 position;
    public float sVelocity;
    //public GameObject quad;
    //public GameObject fire;
    //public float shotTime;
    //public float minShotTime;

    // Start is called before the first frame update
    void Start()
    {
        if (this.tag == "Asteroids")
        {
            moveValue = new Vector2(0, 1);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMove(InputValue value)
    {
        moveValue = value.Get<Vector2>();
    }

    public void FixedUpdate()
    {
        Vector3 oldPosition = position;
        Vector3 movement = new Vector3(moveValue.x, 0.0f, moveValue.y);

        transform.position = transform.position + speed * Time.fixedDeltaTime * movement;
        position = transform.position;
        position.x = Mathf.Clamp(transform.position.x, (float)-4.7, (float)4.7);
        position.z = Mathf.Clamp(transform.position.z, (float)-1.9, (float)12.2);
        transform.position = position;

        sVelocity = (oldPosition.x- position.x) / Time.fixedDeltaTime;

            transform.rotation = Quaternion.Euler(new Vector3(0, 0, sVelocity * 3));
   
        

     

    }

    //public void OnFire(InputValue value)
    //{
    //    Debug.Log("fire");
    //    if(Time.time-shotTime> minShotTime)
    //    {
    //        Debug.Log("trans" + transform.position);
    //        quad.transform.position = fire.transform.position;
    //        Instantiate(quad);
    //        Debug.Log("firep"+fire.transform.position);
    //        //quad.transform.position = fire.transform.position;
    //        Debug.Log(quad.transform.position);
    //        shotTime = Time.time;
    //    }
    //}

}
