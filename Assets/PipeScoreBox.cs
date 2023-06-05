using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScoreBox : MonoBehaviour
{
    public GameLogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameLogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
        
        
    }

}