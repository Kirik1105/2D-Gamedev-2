using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = -250;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    void Start()
    {
    }

    void Update()
    {
       float steerAmpount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
       float speedAmpount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
       transform.Rotate(0, 0, steerAmpount);
       transform.Translate(0,speedAmpount,0);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Boost" ){
            moveSpeed=boostSpeed;
        }
        
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        moveSpeed=slowSpeed;
    }
}
