using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fire : MonoBehaviour
{
    public GameObject quad;
    public GameObject fire;
    public float shotTime;
    public float minShotTime;
    // Start is called before the first frame update
    void Start()
    {
        shotTime = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnFire(InputValue value)
    {
        Debug.Log("fire");
        if (Time.time - shotTime > minShotTime)
        {
            Debug.Log("trans" + transform.position);
            quad.transform.position = fire.transform.position;
            Instantiate(quad);
            Debug.Log("firep" + fire.transform.position);
            //quad.transform.position = fire.transform.position;
            Debug.Log(quad.transform.position);
            shotTime = Time.time;
        }
    }
}
