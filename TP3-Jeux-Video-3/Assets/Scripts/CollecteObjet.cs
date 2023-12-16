using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollecteObjet : MonoBehaviour
{

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.transform.tag == "collectible"){
            other.gameObject.SetActive(false);
        }
        
    }
}
