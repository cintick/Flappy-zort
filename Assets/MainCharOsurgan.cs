using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharOsurgan : MonoBehaviour
{
    public Rigidbody2D OsurganRigidBody;
    public float FlapStrenght;

    
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space) == true)
        {
            OsurganRigidBody.velocity = FlapStrenght * Vector2.up;
        }
    }

    void flyup()
    {
        OsurganRigidBody.velocity = FlapStrenght * Vector2.up;
    }

    private void FixedUpdate()
    {
        
    }

}
