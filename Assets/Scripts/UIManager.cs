using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] Client client;
    string attackChoice;
    string defenseChoice;

    enum Choices
    {
        FIRE,
        ICE,
        POISON,
        FIREWALL,
        ICEWALL,
        POISONWALL
    }
   

    enum State
    {
        IDLE,
        CONNECTING,
        WAITINGFORTWOPPLAYERS,
        CHECKINGTURN,
        ATTACK,
        DEFENSE,
        PLAYING,
        WAITING
    }
    State state = State.IDLE;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SendChoices(string choice)
    {
        client.SendChoice(choice);
    }

    void FireAttack()
    {
        attackChoice = "FireAttack";
    }
    void IceAttack()
    {
        attackChoice = "IceAttack";
    }
    void PoisonAttack()
    {
        attackChoice = "PoisonAttack";
    }
    void FireWall()
    {
        defenseChoice = "FireWall";
    }
    void IceWall()
    {
        defenseChoice = "IceWall";
    }
    void PoisonWall()
    {
        defenseChoice = "PoisonWall";
    }
}
