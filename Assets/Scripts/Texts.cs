
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Texts", order = 1)]
public class Texts : ScriptableObject
{
    [SerializeField] private string[] text;

    public string getText(int k) {
        return text[k];
    }

}
