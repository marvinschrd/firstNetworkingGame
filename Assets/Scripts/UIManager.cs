using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIManager : MonoBehaviour
{
    [SerializeField] Client client;
    [SerializeField] PlayManager playManager;
    string attackChoice;
    string defenseChoice;

    [SerializeField] GameObject ConnectingPanel;
    [SerializeField] GameObject WaitingPanel;
    [SerializeField] GameObject AttackPanel;
    [SerializeField] GameObject DefensePanel;


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

    public void Connect()
    {
        client.SetupSocket();
        ConnectingPanel.SetActive(false);
    }

   void SendChoices(string choice)
    {
        client.SendChoice(choice);
        playManager.updateChoices(choice);
    }

     public void FireAttack()
    {
        attackChoice = "FireAttack";
        SendChoices(attackChoice);
        AttackPanel.SetActive(false);
    }
     public void IceAttack()
    {
        attackChoice = "IceAttack";
        SendChoices(attackChoice);
        AttackPanel.SetActive(false);
    }
    public void PoisonAttack()
    {
        attackChoice = "PoisonAttack";
        SendChoices(attackChoice);
        AttackPanel.SetActive(false);
    }
   public void FireWall()
    {
        defenseChoice = "FireWall";
        SendChoices(defenseChoice);
        DefensePanel.SetActive(false);
    }
    public void IceWall()
    {
        defenseChoice = "IceWall";
        SendChoices(defenseChoice);
        DefensePanel.SetActive(false);
    }
   public void PoisonWall()
    {
        defenseChoice = "PoisonWall";
        SendChoices(defenseChoice);
        DefensePanel.SetActive(false);
    }
}
