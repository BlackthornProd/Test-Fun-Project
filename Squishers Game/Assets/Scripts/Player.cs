using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public GameObject projectile;

    private void Update()
    {

        if (timeBtwAttack <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {

                Instantiate(projectile, transform.position, Quaternion.Euler(0, 0, 90));
                timeBtwAttack = startTimeBtwAttack;
            }
            else if(Input.GetKeyDown(KeyCode.Q))
            {
                Instantiate(projectile, transform.position, Quaternion.Euler(0, 0, 180));
                timeBtwAttack = startTimeBtwAttack;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                Instantiate(projectile, transform.position, Quaternion.Euler(0, 0, 0));
                timeBtwAttack = startTimeBtwAttack;
            }

            
        }
        else {
            timeBtwAttack -= Time.deltaTime;
        }
        
    }
}
