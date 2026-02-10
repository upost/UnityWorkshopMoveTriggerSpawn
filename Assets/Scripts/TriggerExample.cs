using UnityEngine;

public class TriggerExample : MonoBehaviour
{

    public GameObject bullet;

    public float speed=2;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered by: " + other.name);
        if(other.tag=="Player")
        { 
            GameObject b = Instantiate(bullet, transform.position + transform.up * 1, transform.rotation);
            Rigidbody rb = b.GetComponent<Rigidbody>();
            rb.AddForce(transform.up * speed + transform.right * Random.Range(-1f,1f)
                + transform.forward * Random.Range(-1f,1f), ForceMode.Impulse);
        }
    }

}
