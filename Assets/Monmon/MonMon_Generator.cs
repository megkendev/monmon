using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class MonMon_Generator : MonoBehaviour
{
    /*[Header("Monmon IDs")]
    public string[] monmonID;
    public int idInt;*/

    [Header("Nature")]
    public string[] monmonNature;
    private int natureInt;

    [Header("Loyalty")]
    public float[] monmonLoyalty;
    private int loyaltyInt;

    public void GenerateMonmon(string monmonID)
    {
        natureInt = Random.Range(0, monmonNature.Length);
        loyaltyInt = Random.Range(0, monmonLoyalty.Length);

        string newMonmon = monmonID + ";" + monmonNature[natureInt].ToString() + ";" + monmonLoyalty[loyaltyInt].ToString();
        MonMon_InventoryManager.Instance.monMon_Library.monmonInventory.Add(newMonmon);
        print("created new " + newMonmon);
    }
}
