using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaplayer : MonoBehaviour
{

    public int maxHealth = 4;
    public int currentHealth;

    public healtbarprueba healthBar;
    public move move;
    // Start is called before the first frame update
    void Start()
    {
        
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            if (move.defenderse == false)
            {
                currentHealth -= 1;
                healthBar.SetHealth(currentHealth);
            }
        }

        if (collision.gameObject.tag == "pinchos")
        {
            if (move.defenderse == false)
            {
                currentHealth -= 1;
                healthBar.SetHealth(currentHealth);
            }
        }

    }
}