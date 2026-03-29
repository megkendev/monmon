using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class Action : MonoBehaviour
{
    private Button button;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(TakeAction);
    }

    protected virtual void TakeAction()
    {
        // in aciton subclass, determine what happens here
        // then call CombatManager.Instance.NextTurn()
        CombatManager.Instance.NextTurn();
    }
}
