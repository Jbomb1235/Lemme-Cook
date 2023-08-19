using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMelt : MonoBehaviour
{

    public bool foodCooked;
    public bool active;
    public GameObject Player;
    public string tagComing;
    public string tagLeaving;

    private Animator m;

    // Start is called before the first frame update
    void Start()
    {
        foodCooked = false;   
        m = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (active && Input.GetKeyDown(KeyCode.E)&&!foodCooked&&Player.tag=="Beef")
        {
            m.SetTrigger("Cook");
            m.ResetTrigger("Idle");
            m.ResetTrigger("Done");
            Invoke("FinishCook",10f);
            Player.tag = "Player";
            active = false;
        }
        if (active && foodCooked && Input.GetKeyDown(KeyCode.E))
        {
            Player.tag = tagLeaving;
            gameObject.tag = "Untagged";
            m.SetTrigger("Idle");
            m.ResetTrigger("Cook");
            m.ResetTrigger("Done");
            foodCooked = false;
            active = false;
        }
        if(tagComing == "Beef")
        {
            tagLeaving = "Patty";
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            active = false;
            tagComing = "";
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            active = true;
            tagComing = Player.tag;
        }
    }
    public void FinishCook()
    {
        foodCooked = true;
        m.SetTrigger("Done");
        m.ResetTrigger("Cook");
        m.ResetTrigger("Idle");
        Debug.Log("Done");
    }
}
