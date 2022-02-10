using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    public Text zone = default; // la zone de texte
    [SerializeField] public Texts text; // l'ensemble des lignes de texte � afficher
    private int nbInst = 0; // l'indice de la prochaine ligne de texte � afficher

    void Start()
    {
        
    }
    void callback()
    {
        zone.text = text.getText(nbInst);
        nbInst++;
    }
}
