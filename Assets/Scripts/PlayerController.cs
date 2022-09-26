using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManager;
    void Start()
    {

    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * 0.5f * Time.deltaTime);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (Input.GetAxis("Mouse X") < 0)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x -
                    0.1f, transform.position.y, transform.position.z), 0.3f);
            }
            if (Input.GetAxis("Mouse X") > 0)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x +
                    0.1f, transform.position.y, transform.position.z), 0.3f);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Multiply") || other.CompareTag("RackUp") || other.CompareTag("Divide") || other.CompareTag("Minus"))
        {
            int sayi = int.Parse(other.name);
            gameManager.AgentManagement(other.tag, sayi, other.transform);
        }
    }
}