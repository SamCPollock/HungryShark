using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [Header("Gameplay Values")]
    public float speed;
    public float minimumSpeed;

    // References
    private Rigidbody rb;
    public GameManager gameManager; 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
      
        if (rb.velocity.magnitude < minimumSpeed)
        {
            rb.velocity = transform.forward * minimumSpeed;
        }

        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;
            Vector3 targetLocation;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                targetLocation = hit.point;

                targetLocation.y = transform.position.y;

                float angle = Vector3.Angle(targetLocation, transform.position);

                transform.LookAt(targetLocation);

                rb.velocity = transform.forward * speed;

            }
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            transform.localScale = new Vector3(transform.localScale.x * 1.1f, transform.localScale.y, transform.localScale.z * 1f);
            gameManager.AddScore(collision.gameObject.GetComponent<FishBehaviour>().pointValue);
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.CompareTag("Enemy"))
        {
            gameManager.TakeDamage(1);
            Destroy(collision.gameObject);
            transform.position = new Vector3(0, 0.4f, 0);
        }

    }
}
