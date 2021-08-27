using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class CardsMovingState : State
{
    [SerializeField] private float Speed;                 //cards speed
    [SerializeField] private float spreadCards;           //cards spread

    private  float avgCards;
    private  float avgCardsDel;
    private  float shortCard;


    public override void Run()
    {
        gameLogick.SuitsCheck();
        CardsMoving();
    }

    void CardsMoving()
    {
        // calculations
        float cardSpeed = Speed * Time.deltaTime;
        avgCards = gameLogick.playerHandCards.Length * spreadCards;
        avgCardsDel = 0 - (avgCards / 2);
        shortCard = avgCards / gameLogick.playerHandCards.Length;


        gameLogick.playerHandCards = new Image[gameLogick.playerHandSecondParent.childCount]; 

        //moving
        for (int i = 0; i < gameLogick.playerHandCards.Length; i++)
        {
            gameLogick.playerHandCards[i] = gameLogick.playerHandSecondParent.GetChild(i).GetComponent<Image>();
            gameLogick.playerHandCards[i].gameObject.SetActive(true);      
            gameLogick.playerHandCards[i].transform.localPosition = Vector3.Lerp(gameLogick.playerHandCards[i].transform.localPosition, new Vector3(avgCardsDel += shortCard, -900, 0), cardSpeed);

            if (gameLogick.playerHandCards[i].transform.localPosition.y <= -895)
            {
                gameLogick.SetState(gameLogick.suitMovingdState);
            }
        }
     
    }

  
}
