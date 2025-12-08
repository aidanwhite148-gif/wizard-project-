using System;
using UnityEngine;

public class hehe : MonoBehaviour
{
    public GameObject cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("hello world");

    }

    // Update is called once per frame
    void Update()
    {

        {
            if (Input.GetKeyDown(KeyCode.E))

                Debug.Log("You pressed E");
            if (Input.GetKey(KeyCode.W))
            {

                cube.transform.Translate(0, 1, 0);
            }
        }
    }
}







