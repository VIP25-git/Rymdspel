using UnityEngine;

public class laserScript : MonoBehaviour
{
    public float laserSpeed = 8;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("I hit: " + other.name);

        Destroy(gameObject);
    }
}
