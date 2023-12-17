using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelManagerFin : MonoBehaviour
{

    [SerializeField] private Listeobjet listeobjet;

    [SerializeField] private TMP_Text scorefinal;

    // Start is called before the first frame update
    void Start()
    {
        scorefinal.text = "Points : " + listeobjet.score.ToString();
    }

    public void RetourAcceuil(){
        SceneManager.LoadScene("Accueil");
    }
}
