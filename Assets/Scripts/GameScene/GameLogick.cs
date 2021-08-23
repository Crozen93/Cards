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
    [Header("Actual state")]
    [SerializeField] private State CurrentState;                    // state "ON" now  

    [Header("Variables")]
    public int suitRandom;                                          // random variable suit-cards now in game
    public List<int> possible;                                      // all random variables of the suits of the cards that were in the game

    public int pressedButtonNum;                                    // pressed button now variable
    public int playerScore;                                         // player score variable

    [Header("Suits")]
    [SerializeField] private int C;                                 // number cards - CLUBS on table 
    [SerializeField] private int D;                                 // number cards - DIAMONDS on table 
    [SerializeField] private int H;                                 // number cards - HEARTS on table 
    [SerializeField] private int S;                                 // number cards - SPADES on table 

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
        if (C != 9)
        {
            C = 0;
            for (int i = 0; i < playerHandCards.Length; i++)
            {
                if (playerHandCards[i].sprite.name == "2C")
                {
                    C++;
                }
            }
        }

        if (D != 9)
        {
            D = 0;
            for (int i = 0; i < playerHandCards.Length; i++)
            {
                if (playerHandCards[i].sprite.name == "2D")
                {
                    D++;
                }
            }
        }

        if (H != 9)
        {
            H = 0;
            for (int i = 0; i < playerHandCards.Length; i++)
            {
                if (playerHandCards[i].sprite.name == "2H")
                {
                    H++;
                }
            }
        }

        if (S != 9)
        {
            S = 0;
            for (int i = 0; i < playerHandCards.Length; i++)
            {
                if (playerHandCards[i].sprite.name == "2S")
                {
                    S++;
                }
            }
        }
 

        SuitNumCheck();

      
                if (C == 0)
                {
                    C = 9;
                }

                if (D == 0 )
                {
                    D = 9;
                }

                if (H == 0)
                {
                    H = 9;
                }

                if (S == 0 ) 
                {
                    S = 9;
                }

            if (C == 9 && suitRandom == 0)
            {
                C = 0;
            }
            if (D == 9 && suitRandom == 1)
            {
                D = 0;
            }
            if (H == 9 && suitRandom == 2)
            {
                H = 0;
            }
            if (S == 9 && suitRandom == 3)
            {
                S = 0;
            }
      
    }

    public void SuitNumCheck()
    {
       
            if (C == 0 )
            {
                suitRandom = Random.Range(0, 4);
            }
            if (D == 0 )
            {
                suitRandom = Random.Range(0, 4);
            }
            if (H == 0 )
            {
                suitRandom = Random.Range(0, 4);
            }
            if (S == 0 )
            {
                suitRandom = Random.Range(0, 4);
            }
    }

}
