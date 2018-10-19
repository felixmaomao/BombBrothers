using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("you hit me trigger");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("you hit me colloision");
    }
}
    