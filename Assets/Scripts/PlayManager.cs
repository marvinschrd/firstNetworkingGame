using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour
{

    string otherPlayerAttack = null;
    string otherPlayerDefense = null;

    string playerAttack = null;
    string playerDefense = null;

    bool choicesMades = false;
    bool otherPlayerChoicesReceived = false;

    bool turnPlayed = false;

    [SerializeField] Player player;
    [SerializeField] OtherPlayer otherPlayer;

    enum State
    {
        IDLE,
        WAITINGFOREVERYCHOICES,
        PLAYINGTURN
    }
    State state = State.IDLE;


    void CheckIfChoicesWereMade()
    {
        if(playerAttack!=null&&playerDefense!=null)
        {
            choicesMades = true;
        }
        
        if(otherPlayerAttack!=null&&otherPlayerDefense!=null)
        {
            otherPlayerChoicesReceived = true;
        }
    }

    public void updateChoices(string choice)
    {
       
        if(choice == "FireAttack"|| choice == "IceAttack"|| choice == "PoisonAttack")
        {
            playerAttack = choice;
        }
        else
        {
            playerDefense = choice;
        }
    }
    public void updateOtherPlayerChoices(string choice)
    {
        if (choice == "FireAttack" || choice == "IceAttack" || choice == "PoisonAttack")
        {
            otherPlayerAttack= choice;
        }
        else
        {
            otherPlayerDefense = choice;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       switch (state)
        {
            case State.IDLE:
                break;
            case State.WAITINGFOREVERYCHOICES:
                CheckIfChoicesWereMade();
                if(choicesMades && otherPlayerChoicesReceived)
                {
                    state = State.PLAYINGTURN;
                    choicesMades = false;
                    otherPlayerChoicesReceived = false;
                }
                break;
            case State.PLAYINGTURN:
                if(turnPlayed)
                {
                    state = State.WAITINGFOREVERYCHOICES;
                }
                break;
        }



    }
}
