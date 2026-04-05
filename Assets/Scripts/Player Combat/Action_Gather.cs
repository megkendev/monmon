using UnityEngine;

public class Action_Gather : Action
{
    protected override void TakeAction()
    {
        print("player gathering");
        // TEST REMOVE THIS LATER
        string currentMonmonID = CombatManager.Instance.monMonAI.GetMonmonID();
        MonMon_InventoryManager.Instance.monMon_Generator.GenerateMonmon(currentMonmonID);
        // END OF TEST
        base.TakeAction();
    }
}
