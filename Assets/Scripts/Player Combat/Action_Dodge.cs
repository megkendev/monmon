using UnityEngine;

public class Action_Dodge : Action
{
    protected override void TakeAction()
    {
        print("player dodging");
        base.TakeAction();
    }
}
