using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abresesamo : MonoBehaviour
{
    public GameObject[] Aparecio;

    public Player player;

    public bool dropea = false;

    public bool Aquino = false;

    public bool Bum = false;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Aparecio.Length; i++)
        {
            Aparecio[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        player = Player.instance;

        dropea = player.GetComponent<Player>().abrir;

        if (Bum == true)
        {

                for (int i = 0; i < Aparecio.Length; i++)
                {
                    Aparecio[i].SetActive(true);
                }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Bum = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Bum = true;
        }
    }
}
