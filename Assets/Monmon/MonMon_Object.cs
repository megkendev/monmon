using UnityEngine;

[CreateAssetMenu(fileName = "MonMon_Object", menuName = "Scriptable Objects/MonMon_Object")]
public class MonMon_Object : ScriptableObject
{
    public string monmonID, nature;
    public float loyalty;
}
