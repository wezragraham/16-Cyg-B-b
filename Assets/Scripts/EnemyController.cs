using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    [SerializeField]
    float speed;

    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);


        if (player.GetComponent<PlayerController>().isMoving  == true)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
    }
}
