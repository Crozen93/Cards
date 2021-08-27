using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class SuitMovingState : State
{
    [SerializeField] private float timer;                    // timer float
    [SerializeField] private float Speed;                    // cards speed
    [SerializeField] private float spreadCards;              // cards spread

    private float avgCards;
    private float avgCardsDel;
    private float shortCard;


    public override void Run()
    {
       
        CardsSuitMoving();
        
    }

    

    void CardsSuitMoving()
    {
        // calculations
        float cardSpeed = Speed * Time.deltaTime;
        avgCards = gameLogick.playerHandCards.Length * spreadCards;
        avgCardsDel = 0 - (avgCards / 2);
        shortCard = avgCards / gameLogick.playerHandCards.Length;


        gameLogick.playerHandCards = new Image[gameLogick.playerHandSecondParent.childCount];
       
        for (int i = 0; i < gameLogick.playerHandCards.Length; i++)
        {            
            gameLogick.playerHandCards[i] = gameLogick.playerHandSecondParent.GetChild(i).GetComponent<Image>();         
        }

        timer += Time.deltaTime;

        //moving 
        for (int i = 0; i < gameLogick.playerHandCards.Length; i++)
        {
            //suit CLUBS
            if (gameLogick.suitRandom == 0  )
            {
                if (gameLogick.suitRandom == 0 && gameLogick.playerHandCards[i].sprite.name == "2C")
                {
                    
                    gameLogick.playerHandCards[i].GetComponent<Button>().interactable = true;    
                    gameLogick.playerHandCards[i].transform.localPosition = Vector3.MoveTowards(gameLogick.playerHandCards[i].transform.localPosition, new Vector3(avgCardsDel += shortCard + 50, -900, 0), cardSpeed);
                }
                else
                {                  
                    gameLogick.playerHandCards[i].transform.localPosition = Vector3.MoveTowards(gameLogick.playerHandCards[i].transform.localPosition, new Vector3(avgCardsDel += shortCard -20, -900, 0), cardSpeed);

                    if (timer >= 0.3f && gameLogick.playerHandCards[i].transform.localPosition.y == -900)
                    {
                        timer = 0f;

                        for (int z = 0; z < gameLogick.playerHandCards.Length; z++)
                        {
                            gameLogick.spreadingCardCords[z] = gameLogick.playerHandCards[z].transform.localPosition;
                            gameLogick.spreadingCardCords[z].x += 70;
                        }

                        gameLogick.SetState(gameLogick.movingOffAciveSuitState);
                    }
                }
            }

            //suit DIAMONDS
            if (gameLogick.suitRandom == 1)
            {
                if (gameLogick.suitRandom == 1 && gameLogick.playerHandCards[i].sprite.name == "2D")
                {

                    gameLogick.playerHandCards[i].GetComponent<Button>().interactable = true;
                    gameLogick.playerHandCards[i].transform.localPosition = Vector3.MoveTowards(gameLogick.playerHandCards[i].transform.localPosition, new Vector3(avgCardsDel += shortCard + 50, -900, 0), cardSpeed);
                }
                else
                {
                    gameLogick.playerHandCards[i].transform.localPosition = Vector3.MoveTowards(gameLogick.playerHandCards[i].transform.localPosition, new Vector3(avgCardsDel += shortCard - 20, -900, 0), cardSpeed);

                    if (timer >= 0.3f && gameLogick.playerHandCards[i].transform.localPosition.y == -900)
                    {
                        timer = 0f;

                        for (int z = 0; z < gameLogick.playerHandCards.Length; z++)
                        {
                            gameLogick.spreadingCardCords[z] = gameLogick.playerHandCards[z].transform.localPosition;
                            gameLogick.spreadingCardCords[z].x += 70;
                        }

                        gameLogick.SetState(gameLogick.movingOffAciveSuitState);
                    }
                }
            }

            //suit HEARTS
            if (gameLogick.suitRandom == 2)
            {
                if (gameLogick.suitRandom == 2 && gameLogick.playerHandCards[i].sprite.name == "2H")
                {

                    gameLogick.playerHandCards[i].GetComponent<Button>().interactable = true;
                    gameLogick.playerHandCards[i].transform.localPosition = Vector3.MoveTowards(gameLogick.playerHandCards[i].transform.localPosition, new Vector3(avgCardsDel += shortCard + 50, -900, 0), cardSpeed);
                }
                else
                {               
                    gameLogick.playerHandCards[i].transform.localPosition = Vector3.MoveTowards(gameLogick.playerHandCards[i].transform.localPosition, new Vector3(avgCardsDel += shortCard - 20, -900, 0), cardSpeed);

                    if (timer >= 0.3f && gameLogick.playerHandCards[i].transform.localPosition.y == -900)
                    {
                        timer = 0f;

                        for (int z = 0; z < gameLogick.playerHandCards.Length; z++)
                        {
                            gameLogick.spreadingCardCords[z] = gameLogick.playerHandCards[z].transform.localPosition;
                            gameLogick.spreadingCardCords[z].x += 70;
                        }

                        gameLogick.SetState(gameLogick.movingOffAciveSuitState);
                    }
                }
            }

            //suit SPADES
            if (gameLogick.suitRandom == 3)
            {
                if (gameLogick.suitRandom == 3 && gameLogick.playerHandCards[i].sprite.name == "2S")
                {

                    gameLogick.playerHandCards[i].GetComponent<Button>().interactable = true;
                    gameLogick.playerHandCards[i].transform.localPosition = Vector3.MoveTowards(gameLogick.playerHandCards[i].transform.localPosition, new Vector3(avgCardsDel += shortCard + 50, -900, 0), cardSpeed);
                }
                else
                {                  
                    gameLogick.playerHandCards[i].transform.localPosition = Vector3.MoveTowards(gameLogick.playerHandCards[i].transform.localPosition, new Vector3(avgCardsDel += shortCard - 20, -900, 0), cardSpeed);

                    if (timer >= 0.3f && gameLogick.playerHandCards[i].transform.localPosition.y == -900)
                    {
                        timer = 0f;

                        for (int z = 0; z < gameLogick.playerHandCards.Length; z++)
                        {
                            gameLogick.spreadingCardCords[z] = gameLogick.playerHandCards[z].transform.localPosition;
                            gameLogick.spreadingCardCords[z].x += 70;
                        }
                        
                        gameLogick.SetState(gameLogick.movingOffAciveSuitState);
                    }
                }
            }

        }
    }
   
   
}
