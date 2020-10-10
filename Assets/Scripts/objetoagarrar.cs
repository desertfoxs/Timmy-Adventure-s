using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetoagarrar : MonoBehaviour
{
    public GameObject objeto;
    public GameObject agarrarelobjeto;
    public Transform interaccion;
    public Collider2D box;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (objeto != null && objeto.GetComponent<agarro>().encontro==true && agarrarelobjeto==null) 
        {

            if (Input.GetKeyDown(KeyCode.F))
            {
                agarrarelobjeto = objeto;
                agarrarelobjeto.GetComponent<agarro>().encontro = false;
                agarrarelobjeto.transform.SetParent(interaccion);
                agarrarelobjeto.transform.position = interaccion.position;
                agarrarelobjeto.GetComponent<Rigidbody2D>().gravityScale = 0;
                agarrarelobjeto.GetComponent<Rigidbody2D>().isKinematic = true;
                box.enabled = false;


            }
           
           
           
           
        }
        else if (agarrarelobjeto != null && (Input.GetKeyDown(KeyCode.F)))
        {
           
            agarrarelobjeto.GetComponent<agarro>().encontro = true;
            agarrarelobjeto.transform.SetParent(null);

            agarrarelobjeto.GetComponent<Rigidbody2D>().gravityScale = 1;
            agarrarelobjeto.GetComponent<Rigidbody2D>().isKinematic = false;
            agarrarelobjeto = null;
            box.enabled = true;
        }

    }




}