using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class MovingCenterCardsState : State
{
    [SerializeField] private float timer;           // timer float

    public override void Run()
    {

        MovingCenter(gameLogick.pressedButtonNum);
    }

    void MovingCenter(int numButton)
    {

        float cardSpeed = 5f * Time.deltaTime;
        gameLogick.cards[numButton].transform.localPosition = Vector3.Lerp(gameLogick.cards[numButton].transform.localPosition, new Vector3(0, -100, 0), cardSpeed);

        for (int i = 0; i < gameLogick.playerHandCards.Length; i++)
        {
            gameLogick.playerHandCards[i].GetComponent<Button>().interactable = false;
        }

        gameLogick.cards[numButton].interactable = true;

        timer += Time.deltaTime;

        //timer
        if (timer >= 2)
        {
            timer = 0f;

            gameLogick.cards[numButton].transform.parent = gameLogick.playerHanFirstdParent;
            gameLogick.cards[numButton].gameObject.SetActive(false);

            gameLogick.playerScore += 1;
            gameLogick.playerScoreText.text = gameLogick.playerScore.ToString();

            gameLogick.possible.Add(gameLogick.suitRandom);

            gameLogick.SetState(gameLogick.suitMovingdState);
        }
    }
 
}

