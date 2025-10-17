using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public float speed;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y <= -5.5f)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 5.5f, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") 
        {
            other.transform.GetComponent<playerScript>().TakeDamage();
            Debug.Log("Hit: " + other);
        }

        if (other.tag == "Laser")
        {
            Destroy(gameObject);
        }
    }
}