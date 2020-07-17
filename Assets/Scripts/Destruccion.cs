using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruccion : MonoBehaviour
{
    public Boss boss;

    public CienPies cienpies;

    public Cofre craneo;

    public EnemyEscara escarabajoN;

    private void Update()
    {
        escarabajoN = EnemyEscara.instance;

        craneo = Cofre.instance;

        cienpies = CienPies.instance;

        boss = Boss.instance;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Araña"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Pared"))
        {
            Destroy(gameObject);
        }

        
         if (collision.gameObject.CompareTag("Boss"))
         {
             Destroy(gameObject);
         }

         if (collision.gameObject.CompareTag("Cienpies"))
         {
             Destroy(gameObject);
         }

         if (collision.gameObject.CompareTag("EscarabajosN"))
         {
            Destroy(gameObject);
         }

        if (collision.gameObject.CompareTag("Craneo"))
        {
            Destroy(gameObject);
        }

    }
}
