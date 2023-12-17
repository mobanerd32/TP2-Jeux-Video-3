using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Listeobjet", menuName = "ScriptableObjects/listeObjet")]
public class Listeobjet : ScriptableObject
{
    [SerializeField]
    private string[] ListeObjet;

    [SerializeField] 
    public int[] nombreObjet;

    public float tempsDeJeu = 0;

    public int score;
    

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    public void resetValue()
    {
        nombreObjet[0] = 7;
        nombreObjet[1] = 9;
        nombreObjet[2] = 4;
        nombreObjet[3] = 5;
        tempsDeJeu = 0;
        score = 0;
    }
}
