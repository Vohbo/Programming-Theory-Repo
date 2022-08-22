using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YgoCard : Card
{
    public string ExpansionName { get; set; }

    public override string ShowSomeShit()
    {
        return Name + " : " + ExpansionName;
    }
}
