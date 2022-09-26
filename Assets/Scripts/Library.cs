using System.Collections.Generic;
using UnityEngine;


namespace Ardil
{
    public class Library : MonoBehaviour
    {
        public static void Multiply(int InputNumber, List<GameObject> SpawnList, Transform _transform)
        {
            int donguSayisi = (GameManager.charCount * InputNumber) - GameManager.charCount;
            int sayi = 0;
            foreach (var item in SpawnList)
            {
                if (sayi < donguSayisi)
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
            GameManager.charCount *= InputNumber;
        }

    }
}

