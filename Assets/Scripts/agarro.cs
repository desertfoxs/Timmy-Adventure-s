using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agarro : MonoBehaviour
{
    public bool encontro = true; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponentInParent<objetoagarrar>().objeto = this.gameObject;
        }

        Debug.Log("encontro");
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponentInParent<objetoagarrar>().objeto = null;

        }

    }

}

