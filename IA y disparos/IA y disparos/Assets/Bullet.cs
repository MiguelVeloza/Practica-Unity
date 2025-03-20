using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bullet_damage;
    public Transform transform_;

    public void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void Update()
    {
        //float distancia = Vector3.Distance(transform.position, transform_.position);
        //if(distancia > 10)
        //{
        //    Destroy(gameObject);
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag.ToString());
        if (!collision.collider.CompareTag("Bot") || !collision.collider.CompareTag("Player"))
        {
            if(collision.gameObject.GetComponent<vida>()==true)
            {
            collision.gameObject.GetComponent<vida>().vida_ = collision.gameObject.GetComponent<vida>().vida_ - bullet_damage;

            }
        }
        if (!collision.collider.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
        
    }
}
