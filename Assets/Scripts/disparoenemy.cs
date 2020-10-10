using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoenemy : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject bullet;
    float firerate;
    float nextfire;
    int healt=1;
    void Start()
    {
        firerate = 1f;
        nextfire= Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void disparar()
    {
        if (Time.time > nextfire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextfire = Time.time + firerate;
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "Player")
        {
            disparar();
            Debug.Log("pego");
           
        }
    }
    //dentro del enemy
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            healt--;
            if (healt == 0)
            {
                Destroy(gameObject);
            }
        }
        
    }

}
