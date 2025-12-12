using Pathfinding;
using UnityEngine;
using UnityEngine.UI;

public class MonMonAI : MonoBehaviour
{
    public static MonMonAI Instance { get ; private set; }
    FollowerEntity ai;
    AIDestinationSetter destinationSetter;
    public Transform[] location;
    [SerializeField] private float maxHp;
    public float hp;
    public Image hpObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (Instance != null)
        {
            print("There's more than one MonMonAI!" + transform + " - " + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    void OnEnable()
    {
        ai = GetComponent<FollowerEntity>();
        destinationSetter = GetComponent<AIDestinationSetter>();
    }

    void Start()
    {
        hp = maxHp;
        hpObject.fillAmount = hp/maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeTurn()
    {
        int thisTurnLocation = Random.Range(0, location.Length);
        destinationSetter.target = null;
        destinationSetter.target = location[thisTurnLocation];
        print("moving to location " + thisTurnLocation.ToString());
        GameManager.Instance.NextTurn();
    }
}
