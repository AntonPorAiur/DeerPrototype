using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 25;
    private float horizontalInput;
    private float xRange = 10.0f;
    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Keep the pplayer inbounds 
        if(transform.position.x < -xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x > xRange){
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
