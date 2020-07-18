using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aparecer : MonoBehaviour
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
            Aparecio[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        player = Player.instance;

        dropea = player.GetComponent<Player>().bAbrir;

        if (Bum == true)
        {
            if (dropea == true)
            {
                for (int i = 0; i < Aparecio.Length; i++)
                {
                    Aparecio[i].SetActive(false);
                }
            }
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
