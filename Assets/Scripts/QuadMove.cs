using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static System.IO.Enumeration.FileSystemEnumerable<TResult>;

public class QuadMove : MonoBehaviour
{
    public Vector3 position;
    public float speed;
    //public GameObject fire;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("quad" + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;
        position.z = position.z + speed * Time.fixedDeltaTime;
        transform.position = position;
    }
    //void OnTriggerEnter(UnityEngine.Collider collision)
    //{
    //    Debug.Log("col"+transform.position);
    //    GameObject.Destroy(this.gameObject);
    //}
}
