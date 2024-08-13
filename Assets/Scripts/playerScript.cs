using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float playerSpeed = 3;
    private bool is_dead = false;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        // If player is alive
        if (is_dead == false)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, playerSpeed, 0) * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-playerSpeed, 0, 0) * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, -playerSpeed, 0) * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(playerSpeed, 0, 0) * Time.deltaTime;
            }
        }
        
        // If player is not alive
        else
        { 
            // TODO
        }
    }
}
