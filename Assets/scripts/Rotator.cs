using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 10.0f;

    // Update is called once per frame
    private void Update()
    {
        // Rotate the object around its own up (Y) axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            return;
        }
        
    }
}
