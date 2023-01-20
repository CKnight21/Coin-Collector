using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public float bounce;
    public Rigidbody rb;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyHead"))
        {
            Destroy(other.gameObject);

            rb.velocity = new Vector2(rb.velocity.x, bounce);
        }

    }
}
