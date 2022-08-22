using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicCard : Card
{
    public int Manacost { get; set; }

    public string ShowSomeShit()
    {
        return Name + " : " + Manacost;
    }
}
