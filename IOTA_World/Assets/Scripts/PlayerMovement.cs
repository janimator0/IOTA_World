using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Vector3 move = Vector3.zero;
        // move.x = Input.GetAxis("Horizontal");
        // move.z = Input.GetAxis("Vertical");

        Vector3 move =
            Input.GetAxis("Vertical") * Camera.main.transform.forward.Flattened().normalized + 
            Input.GetAxis("Horizontal") * Camera.main.transform.right.Flattened().normalized;

        controller.Move(move * moveSpeed * Time.deltaTime);
    }
    
    
}
