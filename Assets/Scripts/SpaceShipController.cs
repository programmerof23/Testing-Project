using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    public float thrust = 1.0f;
    public Rigidbody2D rb;
    public float rotationSpeed = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Input.GetAxis("Horizontal") * rotationSpeed);
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.up * thrust * Input.GetAxis("Vertical"));
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("You Hit An Enemy");
            Destroy(collision.gameObject);
        }
    }
}
