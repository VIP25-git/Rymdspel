using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float playerSpeed = 5;
    public GameObject laserShot;
    private int playerHealth = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0, -4.3f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x < 8.2f)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
            }
        }

        if (transform.position.x > -8.2f)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
            }
        }
            
      
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(laserShot, transform.position, transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Destroy(gameObject);
        }


    }
    public void TakeDamage()
    {
        playerHealth--;
        Debug.Log("Player healt: " + playerHealth);

        if (playerHealth < 0)
        {
            Destroy(gameObject);
        }
    }
}
