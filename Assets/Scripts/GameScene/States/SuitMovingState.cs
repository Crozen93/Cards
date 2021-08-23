using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class SuitMovingState : State
{
    public float Speed;
    public float delCards;

    private float avgCards;
    private float avgCardsDel;
    private float shortCard;


    public override void Run()
    {
       
        CardsSuitMoving();
        
    }

    

    void CardsSuitMoving()
    {
        float cardSpeed = Speed * Time.deltaTime;

        avgCards = gameLogick.playerHandCards.Length * delCards;
        avgCardsDel = 0 - (avgCards / 2);
        shortCard = avgCards / gameLogick.playerHandCards.Length;

        gameLogick.playerHandCards = new Image[gameLogick.playerHandSecondParent.childCount];
       
        for (int i = 0; i < gameLogick.playerHandCards.Length; i++)
        {            
            gameLogick.playerHandCards[i] = gameLogick.playerHandSecondParent.GetChild(i).GetComponent<Image>();         
        }
           
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
                    // playerHandCards[i].transform.localPosition = Vector3.MoveTowards(playerHandCards[i].transform.localPosition, new Vector3(form += form2 - 15, -900, 0), cardSpeed);
                    gameLogick.playerHandCards[i].transform.localPosition = Vector3.MoveTowards(gameLogick.playerHandCards[i].transform.localPosition, new Vector3(avgCardsDel += shortCard -20, -900, 0), cardSpeed);

                    Debug.Log("C");
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
                    gameLogick.playerHandCards[i].transform.localPosition = Vector3.MoveTowards(gameLogick.playerHandCards[i].transform.localPosition, new Vector3(avgCardsDel += shortCard - 15, -900, 0), cardSpeed);
                    Debug.Log("D");
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
                    // playerHandCards[i].transform.localPosition = Vector3.MoveTowards(playerHandCards[i].transform.localPosition, new Vector3(form += form2 - 15, -900, 0), cardSpeed);
                    gameLogick.playerHandCards[i].transform.localPosition = Vector3.MoveTowards(gameLogick.playerHandCards[i].transform.localPosition, new Vector3(avgCardsDel += shortCard - 15, -900, 0), cardSpeed);

                    Debug.Log("H");
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
                    // playerHandCards[i].transform.localPosition = Vector3.MoveTowards(playerHandCards[i].transform.localPosition, new Vector3(form += form2 - 15, -900, 0), cardSpeed);
                    gameLogick.playerHandCards[i].transform.localPosition = Vector3.MoveTowards(gameLogick.playerHandCards[i].transform.localPosition, new Vector3(avgCardsDel += shortCard - 15, -900, 0), cardSpeed);
                    //  break;
                    Debug.Log("S");
                }
            }

        }
    

    }

   
}
