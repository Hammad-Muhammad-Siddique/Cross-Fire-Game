using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject player; // holds the player gameobject
    Rigidbody rb; // stores the rigidbody component of the player
    public float rotateSpeed = 50; // the rotation speed of the player
    public float moveSpeed = 500; // the movement speed of the player

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) // checks if the left arrow key is pressed
        {
            player.transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime); // rotates the player to the left
        }
        else if (Input.GetKey(KeyCode.D)) // checks if the right arrow key is pressed
        {
            player.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime); // rotates the player to the right
        }
        else if (Input.GetKey(KeyCode.W)) // checks if the up arrow key is pressed
        {
            player.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); // moves the player forward
        }
        else if (Input.GetKey(KeyCode.S)) // checks if the down key is pressed
        {
            player.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * -1); // moves the player backward
        }
    }
}
