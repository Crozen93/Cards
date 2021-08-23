using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class StartRandomCardsState : State
{

    public override void Run()
    {
        RandomesCards();

        gameLogick.SetState(gameLogick.sortCardState);
    }

    void RandomesCards()
    {
        gameLogick.startGameButton.gameObject.SetActive(false);

        
        for (int i = 0; i < 13; i++)
        {
            gameLogick.playerHandCards[i].sprite = gameLogick.suitdCards[Random.Range(0, 4)];
        }

    }
}
