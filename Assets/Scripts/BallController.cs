using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rigidbody;
    public Vector3 position;
    public GameObject player1;
    public Vector3 playerPosition1;

    public GameObject player2;
    public Vector3 playerPosition2;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        position = rigidbody.position;
        playerPosition1 = player1.GetComponent<Rigidbody>().position;
        playerPosition2 = player2.GetComponent<Rigidbody>().position;

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collide");
        if(other.gameObject.tag == "Goal")
        {
            Debug.Log("CollideFGoal");
            rigidbody.position = position;
            rigidbody.velocity = new Vector3(0, 0, 0);
            player1.GetComponent<Rigidbody>().position = playerPosition1;
            player1.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0); ;
            player2.GetComponent<Rigidbody>().position = playerPosition2;
            player2.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0); ;


        }

    }
    

}
