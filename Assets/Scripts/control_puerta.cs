using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_puerta : MonoBehaviour
{
    bool PCerrada = false;
    bool idel = true;

    public void OnTriggerEnter2D(Collider2D other)
    {
        gameObject.GetComponent<Animator>().SetBool("idel", false);

        if (!PCerrada )
        {
            gameObject.GetComponent<Animator>().SetBool("cerrar", true);
            PCerrada = true;
            
        }

        else if(PCerrada )
        {
            gameObject.GetComponent<Animator>().SetBool("cerrar", false);
            PCerrada = false;
            gameObject.GetComponent<Animator>().SetBool("idel", true);
        }
    
        
    }

}


