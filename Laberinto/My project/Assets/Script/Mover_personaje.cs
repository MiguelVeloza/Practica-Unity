using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover_personaje : MonoBehaviour
{
    public float speed = 5f;
    public float sensitivity = 50f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0f, vertical) * speed * Time.deltaTime;
        transform.Translate(movement);

        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        transform.Rotate(Vector3.up * mouseX);
    }
}
