using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAngel : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public bool defenderse = false;
    public bool DOBSalt = true;

    bool canjump;
    bool dobleSalto = false;
    Rigidbody2D rb2d;

    public GameObject Checkpoint;

    Vector3 initialPosition;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        initialPosition = transform.position;
    }

    void Update()
    {
        

        if (Input.GetKey("left"))
        {
            rb2d.AddForce(new Vector2(-speed * Time.deltaTime, 0));
            //gameObject.GetComponent<Animator>().SetBool("moving", true);
            //gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKey("right"))
        {
            rb2d.AddForce(new Vector2(speed * Time.deltaTime, 0));
            //gameObject.GetComponent<Animator>().SetBool("moving", true);
            //gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (!Input.GetKey("right") && !Input.GetKey("left"))
        {
            //gameObject.GetComponent<Animator>().SetBool("moving", false);
        }


     
        if (Input.GetKeyDown("up"))
        {
            if (DOBSalt)
            {
                if (canjump)
                {
                    canjump = false;
                    rb2d.AddForce(new Vector2(0, jumpForce));
                    dobleSalto = true;
                }
                else if (dobleSalto)
                {
                    rb2d.AddForce(new Vector2(0, jumpForce));
                    dobleSalto = false;
                }
            }
            else if(canjump)
            {
                canjump = false;
                rb2d.AddForce(new Vector2(0, jumpForce));
            }
         
            
        }
        if (Input.GetKeyDown("z"))
        {
            defenderse = true;
            StopAllCoroutines();
            StartCoroutine("Timer");

        }
        if (Input.GetKeyUp("z"))
        {

            nodefenderse();

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "muro")
        {
            canjump = true;
        }
        
    }
    
    void nodefenderse()
    {
        defenderse = false;

    }

    public void Doble_salto()
    {
        Debug.Log("doble salto activado");
        DOBSalt = true;

        transform.position = initialPosition;

    }


    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);

        nodefenderse();
    }
}
