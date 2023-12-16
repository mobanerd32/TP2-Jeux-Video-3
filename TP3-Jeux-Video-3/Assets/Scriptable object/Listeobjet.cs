using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Listeobjet", menuName = "ScriptableObjects/listeObjet")]
public class Listeobjet : ScriptableObject
{
    [SerializeField]
    private string[] ListeObjet;

    [SerializeField] 
    private int[] nombreObjet;
    
}
