using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffre : MonoBehaviour
{

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("clé");
        if(other.transform.tag == "Clé"){
            animator.SetTrigger("CleSerrure");
        }
    }
}
