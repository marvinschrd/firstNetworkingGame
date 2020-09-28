using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] Client client;
    [SerializeField] PlayManager playManager;
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
        switch(state)
        {
            case State.CONNECTING:
                break;
            case State.CHECKINGTURN:
                break;
            case State.ATTACK:
                break;
            case State.DEFENSE:
                break;
            case State.PLAYING:
                break;
            case State.WAITING:
                break;
            case State.WAITINGFORTWOPPLAYERS:
                break;

        }
    }

    void SendChoices(string choice)
    {
        client.SendChoice(choice);
        playManager.updateChoices(choice);
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
