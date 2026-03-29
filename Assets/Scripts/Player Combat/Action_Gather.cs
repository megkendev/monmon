using UnityEngine;

public class Action_Gather : Action
{
    protected override void TakeAction()
    {
        print("player gathering");
        base.TakeAction();
    }
}
