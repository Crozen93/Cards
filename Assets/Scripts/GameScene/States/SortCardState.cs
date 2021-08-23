using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class SortCardState : State
{

    public override void Run()
    {
        CardsSort();

        gameLogick.SetState(gameLogick.cardsMovingdState);
    }

    void CardsSort()
    {

        for (int i = 0; i < gameLogick.playerHandCards.Length; i++)
        {
            if (gameLogick.playerHandCards[i].sprite.name == "2C")
            {
                gameLogick.playerHandCards[i].transform.parent = gameLogick.playerHandSecondParent; // transform CLUBS card in second parent
            }
        }

        for (int i = 0; i < gameLogick.playerHandCards.Length; i++)
        {
            if (gameLogick.playerHandCards[i].sprite.name == "2H")
            {
                gameLogick.playerHandCards[i].transform.parent = gameLogick.playerHandSecondParent; // transform HEARTS card in second parent
            }
        }

        for (int i = 0; i < gameLogick.playerHandCards.Length; i++)
        {
            if (gameLogick.playerHandCards[i].sprite.name == "2D")
            {
                gameLogick.playerHandCards[i].transform.parent = gameLogick.playerHandSecondParent; // transform DIAMONDS card in second parent
            }
        }

        for (int i = 0; i < gameLogick.playerHandCards.Length; i++)
        {

            if (gameLogick.playerHandCards[i].sprite.name == "2S")
            {
                gameLogick.playerHandCards[i].transform.parent = gameLogick.playerHandSecondParent; // transform SPADES card in second parent
            }

        }

        for (int i = 0; i < gameLogick.playerHandCards.Length; i++)
        {
            gameLogick.playerHandCards[i] = gameLogick.playerHandSecondParent.GetChild(i).GetComponent<Image>();
        }
    }
}
