using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTimer : MonoBehaviour
{
    public bool WeaponCool = false;
    public bool CountdownActive = false;
    public float timer;
    public GameObject bullet;
    public Transform maincharacter;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = maincharacter.transform.position;
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            CountdownActive = true;
            WeaponCool = false;
        }
        else
        {
            timer = 0;
            CountdownActive = false;
            WeaponCool = true;
        }

        if (timer == 0 & WeaponCool & Input.GetKeyDown(KeyCode.A) == true)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
        timer = 5;
    }
}
