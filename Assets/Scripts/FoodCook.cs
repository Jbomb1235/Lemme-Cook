using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCook : MonoBehaviour
{
    // Start is called before the first frame update
    private bool active;
    public GameObject cutComp;
    public GameObject Player;
    public int foodFooded;
    public bool foodMade;
    public string tagComing;
    public string tagLeaving;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            Player.tag = "Player";
            if (Input.GetKeyDown(KeyCode.E))
            {
                foodFooded-=1;
            }
            if (foodFooded==0)
            {
                foodMade = true;
                active = false;
            }
            if (foodMade)
            {
                foodFooded = 8;
                foodMade = false;
                Player.tag = tagLeaving;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == tagComing)
        {
            active = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == tagComing)
        {
            active = true;
            
            Debug.Log("AAAAAAAAAAAAAAAAAAa");
        }
    }
}
