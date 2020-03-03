using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player;
    public int damage;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
             Shoot();
         }
    }

    void Shoot(){
        Instantiate(bullet,transform.position,transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D hitInfo){
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy!=null){
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
