using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telebort : MonoBehaviour
{
    public GameObject Player;
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        //random();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name=="Player")
        {
            if(num==1){
                Player.transform.position = new Vector2(3,-5.5f);
                //random();
            }
            if(num==2){
                Player.transform.position = new Vector2(-30,-5.5f);
                //random();
            }
            if(num==3){
                Player.transform.position = new Vector2(-53,-5.5f);
                //random();
            }
            if(num==4){
                Player.transform.position = new Vector2(-77,-5.5f);
                //random();
            }
            if(num==5){
                Player.transform.position = new Vector2(-100,-5.5f);
                //random();
            }
            if(num==6){
                Player.transform.position = new Vector2(-125,-5.5f);
                //random();
            }
        }
    }
    void random()
    {
        num = Random.Range(1,6);
        Debug.Log(num);
    }
}
