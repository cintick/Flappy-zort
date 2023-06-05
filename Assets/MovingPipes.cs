using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPipes : MonoBehaviour
{
    public float pipeSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -30)
        {
            transform.Translate(pipeSpeed * Time.deltaTime * Vector2.left);
        }
        else
        {
            Destroy(gameObject);
        }
    }


}
