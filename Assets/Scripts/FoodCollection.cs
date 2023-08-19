using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollection : MonoBehaviour
{
    public GameObject txt;
    public bool active;
    public bool cook;
    public GameObject Player;
    public string tag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (active)
        {
            txt.SetActive(true);
        }
        else
        {
            txt.SetActive(false);
        }*/
        if (active && Input.GetKeyDown(KeyCode.E))
        {
            cook = true;
            active = false;
        }
        if (cook)
        {
            Debug.Log("why");
            Player.tag = tag;
            cook = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            active = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            active = true;
        }
    }
}
