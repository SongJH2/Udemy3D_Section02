using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstrunctions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    void PrintInstrunctions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Use W A S D to Move");
        Debug.Log("Don't hit the wall!");
    }

    void MovePlayer()
    { 
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);        
    }

}
