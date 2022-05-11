using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBehaviour : MonoBehaviour
{
    [Header("Gameplay Values")]
    public float speed;
    public int pointValue; 

    // References
    private Rigidbody rb;
    private float timeUntilSwitchDirection;
    private float timeSinceLastSwitch; 

    void Start()
    {
        timeUntilSwitchDirection = 0;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = transform.forward * speed;

        timeSinceLastSwitch += Time.deltaTime;

        if (timeSinceLastSwitch > timeUntilSwitchDirection)
        {
            SwitchDirection();
        }

        if (transform.position.y < 0)
        {
            transform.position = Vector3.Slerp(transform.position, new Vector3(transform.position.x, 0, transform.position.z), 1f * Time.deltaTime);
        }
    }

    void SwitchDirection()
    {
        timeSinceLastSwitch = 0;
        timeUntilSwitchDirection = Random.Range(2, 5);
        transform.eulerAngles = new Vector3(transform.rotation.x, Random.Range(0, 360), transform.rotation.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y -180f, transform.eulerAngles.z);
        }
    }
}
