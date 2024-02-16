using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("This is the player speed. This is a float.")]
    public float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {

        #region Player Movement

        if (Input.GetKey(KeyCode.W)) // Moving player up 
        {
            transform.position += new Vector3(0, playerSpeed * Time.deltaTime, 0); // Might need to .nomarlize to keep diagonals at same speed as cardinals.
        }

        if (Input.GetKey(KeyCode.S)) // Moving player down
        {
            transform.position += new Vector3(0, -playerSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D)) // Moving player right
        {
            transform.position += new Vector3(playerSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A)) // Moving Player left
        {
            transform.position += new Vector3(-playerSpeed * Time.deltaTime, 0, 0);
        }

        #endregion

    }
}
