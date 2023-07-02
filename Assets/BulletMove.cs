using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float BulletSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x < 10)
        {
            transform.Translate(BulletSpeed * Time.deltaTime * Vector2.right);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
