using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject FireBall;
    [SerializeField] GameObject IceBall;
    [SerializeField] GameObject PoisonBall;
    [SerializeField] GameObject FireWall;
    [SerializeField] GameObject IceWall;
    [SerializeField] GameObject PoisonWall;
    // Start is called before the first frame update

    float health = 2;

    Collider2D collider;


    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void LaunchAttack(string attack)
    {
        if(attack == "FireAttack")
        {

        }
        else if(attack == "IceAttack")
        {

        }
            else
                {

                }
    }

    public void LaunchDefense(string defense)
    {
        if(defense == "FireWall")
        {

        }
        else if(defense == "IceWall")
        {

        }
        else
        {

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Attacks attack = collision.gameObject.GetComponent<Attacks>();
        health -= attack.GiveDamage();
    }
}
