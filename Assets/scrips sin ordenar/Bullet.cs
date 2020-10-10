using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float movespeed = 7f;
    Rigidbody2D rigidbody;
    move Tarjet;
    Vector2 moveDirection;
    AudioSource defensa;
    public AudioClip defenderaudio;
    void Start()
    {
        defensa = GetComponent<AudioSource>();
        rigidbody = GetComponent<Rigidbody2D>();
        Tarjet = GameObject.FindObjectOfType<move>();
        moveDirection = (Tarjet.transform.position - transform.position).normalized * movespeed;
        rigidbody.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);

    }


    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("pego");


            if (Tarjet.defenderse==true)
            {
                defensa.clip = defenderaudio;
                defensa.Play();
                Debug.Log("entro");
                moveDirection = (transform.position - Tarjet.transform.position).normalized * movespeed;
                rigidbody.velocity = new Vector2(moveDirection.x, moveDirection.y);
            }

           else
            {
                Destroy(gameObject);
            }

        }
        if (col.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }


    }
}
