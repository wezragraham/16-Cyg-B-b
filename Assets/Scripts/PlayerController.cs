using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 direction;
    private Vector3 angle;

    [SerializeField]
    float speed;

    public bool isMoving;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.D)))
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        //forward
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        //backward
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }
        //left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        //right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-Vector3.right * speed * Time.deltaTime);
        }


        //yaw
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(transform.up * speed *Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-transform.up * speed *Time.deltaTime);
        }

        //roll
        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.Rotate(-transform.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.Rotate(transform.right * speed * Time.deltaTime);
        }

        //pitch
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(transform.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(-transform.forward * speed * Time.deltaTime);
        }
    }
}
