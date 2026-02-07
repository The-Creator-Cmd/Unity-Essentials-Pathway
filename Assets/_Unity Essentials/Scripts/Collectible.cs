using UnityEngine;
using UnityEngine.InputSystem;
public class NewMonoBehaviourScript : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject onCollectEffect;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Collectible object rotation code. 
        transform.Rotate(0, 0, 0.5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Make the collectible object disapper.
            Destroy(gameObject);

            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
        
    }
}
