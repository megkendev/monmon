using UnityEngine;

public class Action_Brace : Action
{
    protected override void TakeAction()
    {
        print("player bracing");
        base.TakeAction();
    }
}
