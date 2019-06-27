using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public GameObject bullet;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Bullet"){
            health -= 50;
        }
    }
    private void Update()
    {
        if(health < 0){
            Destroy(gameObject);
        }
    }

}
