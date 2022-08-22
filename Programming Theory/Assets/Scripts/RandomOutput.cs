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

        something.text = myCards[0].ShowSomeShit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
