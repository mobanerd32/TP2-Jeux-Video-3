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
    

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    public void resetValue()
    {
        nombreObjet[0] = 6;
    }
}
