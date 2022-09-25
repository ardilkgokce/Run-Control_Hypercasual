using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{
    GameObject target;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindWithTag("GameManager").GetComponent<GameManager>().targetPoint;
    }


    private void LateUpdate()
    {
        agent.SetDestination(target.transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpikeBox"))
        {
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().charCount--;
            gameObject.SetActive(false);
        }
    }
}
