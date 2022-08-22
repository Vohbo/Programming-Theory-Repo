using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inherits from Card
public class YgoCard : Card
{
    //Some trivial getters and setters for our Property. All public in this case
    public string ExpansionName { get; set; }

    //I guess this is a (very simplistic) layer of abstraction. I thought of doing more but I really can't be bothered
    public override string ShowSomeShit()
    {
        return Name + " : " + ExpansionName;
    }
}
