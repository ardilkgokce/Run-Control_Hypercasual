using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject target;
    public GameObject charPrefab;
    public GameObject spawnPoint;
    public GameObject targetPoint;


    public List<GameObject> spawnList = new List<GameObject>();
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            foreach (var item in spawnList)
            {
                if (!item.activeInHierarchy)
                {
                    item.transform.position = spawnPoint.transform.position;
                    item.SetActive(true);
                    break;
                }
            }
        }
    }
}
