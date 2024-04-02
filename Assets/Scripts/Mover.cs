using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
   
    // Start is called before the first frame update
    void Start()
    {
        Print();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();


    }

    void Print()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit a wall");
    }

    void MovePlayer()
    {
        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;


        transform.Translate(xvalue, 0, zvalue);
    }
}
