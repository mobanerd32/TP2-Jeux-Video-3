using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntrerMaison : MonoBehaviour
{

    [SerializeField] 
    private string nomScene;

    [SerializeField] 
    private GameObject levelManager;

    

    private  void OnCollisionEnter(Collision other)
    {
        levelManager.GetComponent<LevelManager>().LoadScene(nomScene);
    }
}
