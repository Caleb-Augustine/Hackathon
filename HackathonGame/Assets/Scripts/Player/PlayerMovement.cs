using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("This is the player speed. This is a float.")]
    public float playerSpeed;

    public Vector3 mousePos;

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


        Vector2 mouseScreenPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = (mouseScreenPos - (Vector2)transform.position).normalized;

        transform.up = -direction;

        /*
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Quaternion rot = Quaternion.LookRotation(transform.position - mousePos, Vector3.down);
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);

        */

    }
}
