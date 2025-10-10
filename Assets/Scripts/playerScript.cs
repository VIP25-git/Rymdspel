using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float playerSpeed = 5;
    public GameObject laserShot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0, -3.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(laserShot, transform.position, transform.rotation);
        }
    }
}
