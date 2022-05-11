using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrimpBehaviour : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))   // Shrimp eats enemies
        {
            Destroy(collision.gameObject);
        }
    }
}
