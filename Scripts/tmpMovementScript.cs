using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tmpMovement : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = 25;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;
    if (transform.position.x > deadZone)
    {
        Debug.Log("Pipe Deleted");
        Destroy(gameObject);
    }
    }

}
