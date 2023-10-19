using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = -1f;
    [SerializeField] float moveSpeed = 0.01f;
    void Start()
    {
    }

    void Update()
    {
       float steerAmpount = Input.GetAxis("Horizontal") * steerSpeed;
       float speedAmpount = Input.GetAxis("Vertical") * moveSpeed;
       transform.Rotate(0, 0, steerAmpount);
       transform.Translate(0,speedAmpount,0);
    }
}
