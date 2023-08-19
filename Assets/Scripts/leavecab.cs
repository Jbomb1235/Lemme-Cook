using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leavecab : MonoBehaviour
{
    public bool active;
    public GameObject player;
    public bool keydown;
    public string aaa;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        aaa = gameObject.tag;
        if (Input.GetKeyDown(KeyCode.E))
        {
            keydown = true;
        }
        else
        {
            keydown = false;
        }
        if(gameObject.tag != "cabinet" && active && keydown)
        {
            Debug.Log("the intrusive thoughts will win");
            player.tag = gameObject.tag;
            gameObject.tag = "cabinet";
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            active = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            active = true;
            Debug.Log("AAAAAAAAAAAAAAAAAAAAA");
        }
    }
}
