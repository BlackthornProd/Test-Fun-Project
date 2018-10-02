using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public GameObject projectile;
    public Transform arrowPos;
    private float timeBtwShot;
    public float startTimeBtwShot;

    public float offset;

    private Transform player;
    public float speed;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        Vector2 pos = new Vector2(player.position.x, player.position.y + 1.9f);
        transform.position = Vector2.MoveTowards(transform.position, pos, speed * Time.deltaTime);

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (timeBtwShot <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(projectile, arrowPos.position, transform.rotation);
            }
        }
        else {
            timeBtwShot -= Time.deltaTime;
        }
        
    }
}
