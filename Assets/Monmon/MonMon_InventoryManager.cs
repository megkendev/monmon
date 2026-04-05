using UnityEngine;

public class MonMon_InventoryManager : MonoBehaviour
{
    public static MonMon_InventoryManager Instance { get ; private set; }
    public MonMon_Library monMon_Library;
    public MonMon_Generator monMon_Generator;

    void Awake()
    {
        if (Instance != null)
        {
            print("There's more than one MonMon_InventoryManager!" + transform + " - " + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
}
