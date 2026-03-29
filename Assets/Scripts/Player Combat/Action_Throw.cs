using UnityEngine;

public class Action_Throw : Action
{
    protected override void TakeAction()
    {
        CombatManager.Instance.monMonAI.TakeDamage(2);
        base.TakeAction();
    }
}
