using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Minuteur : MonoBehaviour
{
    
    [SerializeField] private TMP_Text texteMinuteur;

    [SerializeField] private Listeobjet listeobjet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        listeobjet.tempsDeJeu += Time.deltaTime;
        texteMinuteur.text = "Temps écoulé : " + listeobjet.tempsDeJeu.ToString("0");
    }
}
