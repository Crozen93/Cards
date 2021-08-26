using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SuitState : State
{
    public float Speed;



    public override void Run()
    {
        if (isFineshed)
            return;

        moveSuit();
    }

    void moveSuit()
    {
        float cardSpeed = Speed * Time.deltaTime;

 
        for (int i = 0; i < gameLogick.playerHandCards.Length; i++)
        {
            //suit CLUBS
            if (gameLogick.suitRandom == 0)
            {
                if (gameLogick.suitRandom == 0 && gameLogick.playerHandCards[i].sprite.name == "2C")
                {                  
                }
                else
                {
                    gameLogick.playerHandCards[i].transform.localPosition = Vector3.MoveTowards(gameLogick.playerHandCards[i].transform.localPosition, gameLogick.nn[i], cardSpeed);
                
                }
            }

            //suit DIAMONDS
            if (gameLogick.suitRandom == 1)
            {
                if (gameLogick.suitRandom == 1 && gameLogick.playerHandCards[i].sprite.name == "2D")
                {
                }
                else
                {
                    gameLogick.playerHandCards[i].transform.localPosition = Vector3.MoveTowards(gameLogick.playerHandCards[i].transform.localPosition, gameLogick.nn[i], cardSpeed);
                 
                }
            }

            //suit HEARTS
            if (gameLogick.suitRandom == 2)
            {
                if (gameLogick.suitRandom == 2 && gameLogick.playerHandCards[i].sprite.name == "2H")
                {                 
                }
                else
                {
                    gameLogick.playerHandCards[i].transform.localPosition = Vector3.MoveTowards(gameLogick.playerHandCards[i].transform.localPosition, gameLogick.nn[i], cardSpeed);
                  
                }
            }

            //suit SPADES
            if (gameLogick.suitRandom == 3)
            {
                if (gameLogick.suitRandom == 3 && gameLogick.playerHandCards[i].sprite.name == "2S")
                {                 
                }
                else
                {
                    gameLogick.playerHandCards[i].transform.localPosition = Vector3.MoveTowards(gameLogick.playerHandCards[i].transform.localPosition, gameLogick.nn[i], cardSpeed);
                   
                }
            }

        }
    }
}
