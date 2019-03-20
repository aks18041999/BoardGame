using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rigidbody;
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        position = rigidbody.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collide");
        if(other.gameObject.tag == "Goal")
        {
            Debug.Log("CollideFGoal");
            rigidbody.position = position;
            rigidbody.velocity = new Vector3(0, 0, 0);
        }
    }

}
