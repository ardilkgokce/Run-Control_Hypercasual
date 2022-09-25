using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject targetPoint;
    public int charCount = 1;


    public List<GameObject> spawnList = new List<GameObject>();
    void Start()
    {

    }

    void Update()
    {

    }
    public void AgentManagement(string data, Transform _transform)
    {
        switch (data)
        {
            case "x2":
                int sayi = 0;
                foreach (var item in spawnList)
                {
                    if (sayi < charCount)
                    {


                        if (!item.activeInHierarchy)
                        {
                            item.transform.position = _transform.position;
                            item.SetActive(true);
                            sayi++;
                        }

                    }
                    else
                    {
                        sayi = 0;
                        break;
                    }
                }
                charCount *= 2;
                break;

            case "+3":
                int sayi2 = 0;
                foreach (var item in spawnList)
                {
                    if (sayi2 < 3)
                    {


                        if (!item.activeInHierarchy)
                        {
                            item.transform.position = _transform.position;
                            item.SetActive(true);
                            sayi2++;
                        }

                    }
                    else
                    {
                        sayi2 = 0;
                        break;
                    }
                }
                charCount += 3;
                break;

            case "-4":


                if (charCount < 4)
                {
                    foreach (var item in spawnList)
                    {
                        item.transform.position = Vector3.zero;
                        item.SetActive(false);
                    }
                    charCount = 1;
                }
                else
                {
                    int sayi3 = 0;
                    foreach (var item in spawnList)
                    {
                        if (sayi3 != 4)
                        {
                            if (item.activeInHierarchy)
                            {
                                item.transform.position = Vector3.zero;
                                item.SetActive(false);
                                sayi3++;
                            }

                        }
                        else
                        {
                            sayi3 = 0;
                            break;
                        }
                    }
                    charCount -= 4;
                }

                break;

            case "/2":


                if (charCount <= 2)
                {
                    foreach (var item in spawnList)
                    {
                        item.transform.position = Vector3.zero;
                        item.SetActive(false);
                    }
                    charCount = 1;
                }
                else
                {
                    int bolen = charCount / 2;
                    int sayi3 = 0;
                    foreach (var item in spawnList)
                    {
                        if (sayi3 != bolen)
                        {
                            if (item.activeInHierarchy)
                            {
                                item.transform.position = Vector3.zero;
                                item.SetActive(false);
                                sayi3++;
                            }

                        }
                        else
                        {
                            sayi3 = 0;
                            break;
                        }
                    }
                    if (charCount % 2 == 0)
                    {
                        charCount /= 2;
                    }
                    else if (charCount % 2 == 1)
                    {
                        charCount /= 2;
                        charCount++;
                    }

                }

                break;
        }
    }
}
