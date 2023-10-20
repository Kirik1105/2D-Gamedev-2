using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = -250;
    [SerializeField] float moveSpeed = 5;
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
}
