using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonMon_Library", menuName = "Scriptable Objects/MonMon_Library")]
public class MonMon_Library : ScriptableObject
{
    //TODO: once inventory is a json system, restore monmonInventory as tracking MonMon_Object
    //public List<MonMon_Object> monmonInventory = new List<MonMon_Object>();

    public List<string> monmonInventory = new List<string>();
}
