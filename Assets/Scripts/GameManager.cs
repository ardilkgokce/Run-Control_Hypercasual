using Ardil;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject targetPoint;
    public static int charCount = 1;


    public List<GameObject> spawnList = new List<GameObject>();
    void Start()
    {

    }

    void Update()
    {

    }
    public void AgentManagement(string operations, int inputNumber, Transform _transform)
    {
        switch (operations)
        {
            case "Multiply":
                Library.Multiply(inputNumber, spawnList, _transform);
                break;

            case "RackUp":
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

            case "Minus":


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

            case "Divide":


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
