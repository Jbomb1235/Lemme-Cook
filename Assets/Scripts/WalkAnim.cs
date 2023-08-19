using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAnim : MonoBehaviour
{
    private Animator m;

    // Start is called before the first frame update
    void Start()
    {
        m = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(m!=null){
            if(Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.A))
            {
                //m.enabled = false;
                m.enabled = true;
                m.SetTrigger("Walk");
                //Debug.Log("WALK");
                
            }
            else{
                m.Play("Idle", -1, 0f);
                //m.enabled = false;
                m.ResetTrigger("Walk");
                //m.enabled = true;
                
                m.SetTrigger("Idle");
                //Debug.Log("Idle");
               
            }
        }
    }
}
