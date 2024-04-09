using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_script : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = -45;
    public logic_management logic; // add reference to the logic_management class

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_management>(); // get the logic_management component
    }

    // Update is called once per frame
    void Update()
    {
        if (!logic.gameOverScreen.activeSelf) 
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        }
        else
        {
            moveSpeed = 0; 
        }

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
