using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    public float jumpForce; 
    bool canjump;
    bool dobleSalto = false;
    public bool defenderse = false;
    Rigidbody2D rb2d;
   private  Animator anim;
    public bool DOBSalt = true;
    private Vector3 initialPosition;
    public bool escudo = false;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        initialPosition = transform.position;
    }

    void Update()
    {
        

        if (Input.GetKey("left"))
        {
            rb2d.AddForce(new Vector2(-speed * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKey("right"))
        {
            rb2d.AddForce(new Vector2(speed * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (!Input.GetKey("right") && !Input.GetKey("left"))
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }

       if((Input.GetKey("left") && Input.GetKey("up")) || (Input.GetKey("right") && Input.GetKey("up"))){
            gameObject.GetComponent<Animator>().SetBool("moving", false);
            gameObject.GetComponent<Animator>().SetBool("saltar", true);

        }
     
        if (Input.GetKeyDown("up"))
        {
            if (DOBSalt) { 
                if (canjump) {
                    canjump = false;
                    rb2d.AddForce(new Vector2(0, jumpForce));
                    dobleSalto = true;
                    gameObject.GetComponent<Animator>().SetBool("moving", false);
                    gameObject.GetComponent<Animator>().SetBool("saltar", true);
                }

                else if (dobleSalto)
                {
                    rb2d.AddForce(new Vector2(0, jumpForce));
                    dobleSalto = false;
                }

            }
            else if (canjump)
            {
                canjump = false;
                rb2d.AddForce(new Vector2(0, jumpForce));
            }



        }
        if (rb2d.velocity.y < 0)
        {
            gameObject.GetComponent<Animator>().SetBool("saltar", false);
            gameObject.GetComponent<Animator>().SetBool("caida", true);
        }
        
        
        if (Input.GetKeyDown("z") && escudo)
        {
            Debug.Log("escudo en uso");
            defenderse = true;
            StopAllCoroutines();
            StartCoroutine("Timer");
            gameObject.GetComponent<Animator>().SetBool("animdefensa", true);

        }
        if (Input.GetKeyUp("z") && escudo)
        {
            
            nodefenderse();

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "muro" || collision.transform.tag == "enemy" || collision.transform.tag == "Agarrar")
        {
           
            canjump = true;
            gameObject.GetComponent<Animator>().SetBool("saltar", false);
            gameObject.GetComponent<Animator>().SetBool("caida", false);


        }
       
        
    }

    public void OnTriggerEnter2D(Collider2D colicion)
    {
        if (colicion.transform.tag == "estatua")
        {

                Debug.Log("se activo el escudo");
                escudo = true;

        }
    }


    void nodefenderse()

    {
        gameObject.GetComponent<Animator>().SetBool("animdefensa", false);
        defenderse = false;

    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);
        
        nodefenderse();
    }
    
        public void Doble_salto()
    {
        Debug.Log("doble salto activado");
        DOBSalt = true;

        transform.position = initialPosition;
    }
}
