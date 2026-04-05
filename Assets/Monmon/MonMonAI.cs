using Pathfinding;
using UnityEngine;
using UnityEngine.UI;

public class MonMonAI : MonoBehaviour
{
    FollowerEntity ai;
    AIDestinationSetter destinationSetter;
    [SerializeField] protected Transform[] location;
    [SerializeField] private float maxHp = 10;
    [SerializeField] protected float hp;
    [SerializeField] protected Image hpObject;
    [SerializeField] protected string monmonID;

    void OnEnable()
    {
        ai = GetComponent<FollowerEntity>();
        destinationSetter = GetComponent<AIDestinationSetter>();
    }

    public void InitializeState()
    {
        hp = maxHp;
        UpdateHP();
    }

    public virtual void TakeTurn()
    {
        int thisTurnLocation = Random.Range(0, location.Length);
        destinationSetter.target = null;
        destinationSetter.target = location[thisTurnLocation];
        print("moving to location " + thisTurnLocation.ToString());
        CombatManager.Instance.NextTurn();
    }

    public float GetHP()
    {
        return hp;
    }

    public void TakeDamage(float damage)
    {
        hp -= damage;
        print("current hp is " + hp);
        UpdateHP();
    }

    public void UpdateHP()
    {
        hpObject.fillAmount = hp/maxHp;
    }

    public string GetMonmonID()
    {
        return monmonID;
    }
}
