using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    float damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GiveDamage()
    {
        return damage;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == gameObject.tag)
        {
            damage = 0.5f;
        }
        if(gameObject.tag=="IceBall"&&collision.gameObject.tag=="FireWall")
        {
            Destroy(gameObject);
        }
        if(gameObject.tag=="PoisonBall"&&collision.gameObject.tag=="IceWall")
        {
            Destroy(gameObject);
        }
        if(gameObject.tag=="FireBall"&&collision.gameObject.tag=="PoisonWall")
        {
            Destroy(gameObject);
        }
    }
}
