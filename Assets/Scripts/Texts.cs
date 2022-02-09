
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Texts", order = 1)]
public class Texts : ScriptableObject
{
    [SerializeField] private string text = default;
    public string Text => text;

}
