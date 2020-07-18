using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderLash : MonoBehaviour
{
    public Transform startMarker;
    public Transform endMarker;

    public float speed = 1.0f;
    public float journeyLength = 1.0f;
    private float startTime;
    public bool loop = false;
    public bool lashActivated = true;
    public ArañaE araña;
    public Boss boss;
    public EnemyEscara EscarabajoN;
    public CienPies cienpies;
    //public GameObject ColliderSlash;

    // Start is called before the first frame update
    void Start()
    {
        lashActivated = true;
        //ColliderSlash.SetActive(false);

    }



    // Update is called once per frame
    void Update()
    {
        araña = ArañaE.instance;

        boss = Boss.instance;

        EscarabajoN = EnemyEscara.instance;

        cienpies = CienPies.instance;

        if (lashActivated == true)
        {
            if (!loop)
            {
                float distCovered = (Time.time - startTime) * speed;
                transform.position = Vector3.Lerp(startMarker.position, endMarker.position, distCovered / journeyLength);
            }

            if (Input.GetMouseButton(0))
            {
                
                if (loop)
                {
                    float distCovered = Mathf.PingPong(Time.time - startTime, journeyLength / speed);
                    transform.position = Vector3.Lerp(startMarker.position, endMarker.position, distCovered / journeyLength);
                }
            }


        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Araña"))
        {
            araña.GetComponent<ArañaE>().vida = araña.GetComponent<ArañaE>().vida  - 2;
        }

        if (other.gameObject.CompareTag("Boss"))
        {
            boss.GetComponent<ArañaE>().vida = boss.GetComponent<ArañaE>().vida - 2;
        }

        if (other.gameObject.CompareTag("Cienpies"))
        {
            cienpies.GetComponent<ArañaE>().vida = cienpies.GetComponent<ArañaE>().vida - 2;
        }

        if (other.gameObject.CompareTag("EscarabajoN"))
        {
            EscarabajoN.GetComponent<ArañaE>().vida = EscarabajoN.GetComponent<ArañaE>().vida - 2;
        }
    }



}
