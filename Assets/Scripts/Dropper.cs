using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer render;
    Rigidbody rigidBody;
    [SerializeField] float TimeToWait = 5f;
    void Start()
    {

        render = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
        render.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > TimeToWait)
        {
            rigidBody.useGravity = true;
            render.enabled = true;
        }
    }
   
}
