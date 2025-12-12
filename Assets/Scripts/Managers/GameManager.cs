using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get ; private set; }
    [SerializeField] private int turnNumber = 1;
    public bool isPlayerTurn = false;
    public Button nextTurnButton;

    void Awake()
    {
        if (Instance != null)
        {
            print("There's more than one GameManager!" + transform + " - " + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nextTurnButton.onClick.AddListener(NextTurn);
        NextTurn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextTurn()
    {
        turnNumber++;
        isPlayerTurn =! isPlayerTurn;
        print("current turn: " + turnNumber + ", isPlayerTurn: " + isPlayerTurn);

        if (isPlayerTurn)
        {
            print("it's the player's turn!");
        }
        else
        {
            print("it's the monmon's turn!");
            MonMonAI.Instance.TakeTurn();
        }
    }
}
