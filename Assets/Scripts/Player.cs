using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float Forwardspeed = -0.5f;
    [SerializeField] private float speed = 10f;

    [Header("Objenin Ölçeði (Inspector'dan Deðiþtir)")]
    public Vector3 vector3 = new Vector3(1f, 1f, 1f); 

    [SerializeField] private float rotationSpeed = 500f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.localScale = vector3; 
    }

    private void FixedUpdate()
    {
        Vector3 newPosition = rb.position + new Vector3(0, 0, Forwardspeed * Time.fixedDeltaTime);
        rb.MovePosition(newPosition);

        Vector3 rotationAxis = Vector3.left;
        rb.AddTorque(rotationAxis * rotationSpeed * Time.fixedDeltaTime);

        PlayerMove();
    }

    void PlayerMove()
    {
       

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x > Screen.width / 2)
            {
                rb.velocity = new Vector3(-speed, rb.velocity.y, rb.velocity.z);
            }
            else
            {
                rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);
            }
        }
        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obs1"))
        {
            Debug.Log("Önceki Ölçek: " + transform.localScale);

            vector3 += new Vector3(0.1f, 0.1f, 0.1f);
            transform.localScale = vector3;

            Debug.Log("Yeni Ölçek: " + transform.localScale);
        }

        if (other.gameObject.CompareTag("Obs2"))
        {
            Debug.Log("Önceki Ölçek: " + transform.localScale);

            vector3 += new Vector3(-0.1f, -0.1f, -0.1f);
            transform.localScale = vector3;

            Debug.Log("Yeni Ölçek: " + transform.localScale);
        }
    }
}
