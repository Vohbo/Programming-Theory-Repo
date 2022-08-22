using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomOutput : MonoBehaviour
{
    public Text something;

    // Start is called before the first frame update
    void Start()
    {
        int testscore = Random.Range(1, 3);
        //We make a list (with one item) of Cards, depending on some random luck, we add a Yu Gi Oh! or Magic card
        List<Card> myCards = new List<Card>();

        if (testscore == 1)
        {
            MagicCard myCard = new MagicCard();
            myCard.Name = "Jace, the Mind Sculptor";
            myCard.Manacost = 5;
            myCards.Add(myCard);
        }
        else
        {
            YgoCard myCard = new YgoCard();
            myCard.Name = "Mystic Tomato";
            myCard.ExpansionName = "Rear Guard Action";
            myCards.Add(myCard);
        }

        //Finally, we call some abstracted method to display the information we want.
        //This information is different depending on the Card Game, but due to polymorphism we can just call the display method.
        something.text = myCards[0].ShowSomeShit();
    }
}
