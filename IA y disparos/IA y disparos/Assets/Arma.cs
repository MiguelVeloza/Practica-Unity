using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject bullet;
    public GameObject canyon;
    public float bullet_speed;
    public float bullet_damage;
    public bool is_player;
    public float shooting_time = 2f;
    float wait_time;

    private void Update()
    {
        if (is_player)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                BulletInvocation();
            }
        }
        else
        {
            wait_time -= Time.deltaTime;
            if(wait_time < 1)
            {
                BulletInvocation();
                wait_time = shooting_time;
            }
        }
    }
    public void BulletInvocation()
    {
        GameObject instantiatedBullet = Instantiate(bullet, canyon.transform.position, canyon.transform.rotation);
        instantiatedBullet.GetComponent<Bullet>().bullet_damage = bullet_damage;
        instantiatedBullet.GetComponent<Bullet>().transform_ = transform;
        instantiatedBullet.GetComponent<Rigidbody>().AddForce(canyon.transform.forward * bullet_speed);
             
    }        
}
