using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Camera : MonoBehaviour
{
    public Vector2 minCapPos, maxCapPos;
    public float smoothTime = 3f;
    Vector2 velocity;
    Transform target;
    


    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {

        float posX = Mathf.Round( 
            Mathf.SmoothDamp(transform.position.x, target.position.x, ref velocity.x, smoothTime)*100) / 100;
        float posY = Mathf.Round(
            Mathf.SmoothDamp(transform.position.y, target.position.y, ref velocity.y, smoothTime) * 100) / 100;

        transform.position = new Vector3(
 
            Mathf.Clamp(posX, minCapPos.x, maxCapPos.x),
            Mathf.Clamp(posY, minCapPos.y, maxCapPos.y),
            transform.position.z
            );

    }
}
