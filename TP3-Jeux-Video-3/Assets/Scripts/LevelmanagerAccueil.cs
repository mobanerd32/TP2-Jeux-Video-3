using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelmanagerAccueil : MonoBehaviour
{

    [SerializeField] private Listeobjet listeobjet;
    // Start is called before the first frame update
    void Start()
    {
        listeobjet.resetValue();
    }
}
