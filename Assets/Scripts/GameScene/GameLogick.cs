using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameLogick : MonoBehaviour
{
    [Header("States")]
    public State startState;                                        // state - START state when game start
    public State startRandomCardsState;                             // state - assigning cards of random suits
    public State sortCardState;                                     // state - sorting cards
    public State cardsMovingdState;                                 // state - moving cards to a player's hand
    public State suitMovingdState;                                  // state - moving and spreading the cards in the player's hand
    public State movingCenterState;                                 // state - moving the card to the center of the table   
    public State movingOffAciveSuitState;                           // stete - moving and spreading off-active cards+

    [Header("Actual state")]
    [SerializeField] private State CurrentState;                    // state "ON" now  

    [Header("Variables")]
    public int suitRandom;                                          // random variable suit-cards now in game
    public List<int> possible;                                      // all random variables of the suits of the cards that were in the game

    public int pressedButtonNum;                                    // pressed button now variable
    public int playerScore;                                         // player score variable

    [Header("Suits")]
    [SerializeField] private int ClubsNum;                           // number cards - CLUBS on table 
    [SerializeField] private int DiamondsNum;                        // number cards - DIAMONDS on table 
    [SerializeField] private int HeartsNum;                          // number cards - HEARTS on table 
    [SerializeField] private int SpadesNum;                          // number cards - SPADES on table 

    [Header("Hand Header")]
    public Transform playerHanFirstdParent;                         // object HAND parent first
    public Transform playerHandSecondParent;                        // object HAND parent second

    [Header("Text")]   
    public TMP_Text playerScoreText;                                // TMP-Text - player score text 

    [Header("Buttons")]
    public Button startGameButton;                                  // button - start game 
    public List<Button> cards;                                      // buttons - list cards buttons

    [Header("Sprites")]
    public Sprite backCard;                                         // sprite - back card
    public Sprite[] suitdCards;                                     // sprites - all variants cards

    [Header("Image")]
    public Image[] playerHandCards;                                 // Images - all image cards on table

    public Vector3[] spreadingCardCords;                            // Vector3 cords for spreading cards


    private void Awake()
    {
        CheckResolution.instance.ChecPhonekResolution(); //Check resolution
    }

    void Start()
    {
       

        SetState(startState);       //set start current state
        

        startGameButton.onClick.AddListener(() => SetState(startRandomCardsState));
       
        //add Cards button Listeners 
        cards[0].onClick.AddListener(() => ButtonGetInt(0));
        cards[1].onClick.AddListener(() => ButtonGetInt(1));
        cards[2].onClick.AddListener(() => ButtonGetInt(2));
        cards[3].onClick.AddListener(() => ButtonGetInt(3));
        cards[4].onClick.AddListener(() => ButtonGetInt(4));
        cards[5].onClick.AddListener(() => ButtonGetInt(5));
        cards[6].onClick.AddListener(() => ButtonGetInt(6));
        cards[7].onClick.AddListener(() => ButtonGetInt(7));
        cards[8].onClick.AddListener(() => ButtonGetInt(8));
        cards[9].onClick.AddListener(() => ButtonGetInt(9));
        cards[10].onClick.AddListener(() => ButtonGetInt(10));
        cards[11].onClick.AddListener(() => ButtonGetInt(11));
        cards[12].onClick.AddListener(() => ButtonGetInt(12));
        
    }

    private void Update()
    {
        if (!CurrentState.isFineshed)
        {
            CurrentState.Run();
        }

        SuitsCheck(); // Check cards suits   
    }

    // State realization
    public void SetState(State state)
    {
        CurrentState = Instantiate(state);
        CurrentState.gameLogick = this;
        CurrentState.Init();
    }

    // set number desired card
    void ButtonGetInt(int buttonNum)
    {
        pressedButtonNum = buttonNum;
        SetState(movingCenterState); // start moving center state
    }

    // Suits check in player hand logic
    public void SuitsCheck()
    {
        if (ClubsNum != 9)
        {
            ClubsNum = 0;
            for (int i = 0; i < playerHandCards.Length; i++)
            {
                if (playerHandCards[i].sprite.name == "2C")
                {
                    ClubsNum++;
                }
            }
        }

        if (DiamondsNum != 9)
        {
            DiamondsNum = 0;
            for (int i = 0; i < playerHandCards.Length; i++)
            {
                if (playerHandCards[i].sprite.name == "2D")
                {
                    DiamondsNum++;
                }
            }
        }

        if (HeartsNum != 9)
        {
            HeartsNum = 0;
            for (int i = 0; i < playerHandCards.Length; i++)
            {
                if (playerHandCards[i].sprite.name == "2H")
                {
                    HeartsNum++;
                }
            }
        }

        if (SpadesNum != 9)
        {
            SpadesNum = 0;
            for (int i = 0; i < playerHandCards.Length; i++)
            {
                if (playerHandCards[i].sprite.name == "2S")
                {
                    SpadesNum++;
                }
            }
        }
 
      
            if (ClubsNum == 0)
            {
                suitRandom = Random.Range(0, 4);
                ClubsNum = 9;
            }

            if (DiamondsNum == 0 )
            {
                suitRandom = Random.Range(0, 4);
                DiamondsNum = 9;
            }

            if (HeartsNum == 0)
            {
                suitRandom = Random.Range(0, 4);
                HeartsNum = 9;
            }
  
            if (SpadesNum == 0 ) 
            {
                suitRandom = Random.Range(0, 4);
                SpadesNum = 9;
            }

            if (ClubsNum == 9 && suitRandom == 0)
            {
                ClubsNum = 0;
            }
            if (DiamondsNum == 9 && suitRandom == 1)
            {
                DiamondsNum = 0;
            }
            if (HeartsNum == 9 && suitRandom == 2)
            {
                HeartsNum = 0;
            }
            if (SpadesNum == 9 && suitRandom == 3)
            {
                SpadesNum = 0;
            }
      
    }

}
