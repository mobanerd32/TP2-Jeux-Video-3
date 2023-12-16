using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollecteObjet : MonoBehaviour
{

    [SerializeField] private TMP_Text[] listeTexte;

    [SerializeField] private Listeobjet listeobjet;

    private void OnTriggerEnter(Collider other)
    {

        switch(other.gameObject.transform.tag){
            
            case "plante":
                other.gameObject.SetActive(false);
                listeobjet.nombreObjet[0] -= 1;
                listeTexte[0].text = listeobjet.nombreObjet[0].ToString();
                break;
        }
        
    }


    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        listeobjet.resetValue();
        for(int i = 0; i<listeTexte.Length; i++){
            listeTexte[i].text = listeobjet.nombreObjet[i].ToString();
        }
    }
}
