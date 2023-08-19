using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InOutInstruction : MonoBehaviour
{
    public bool ThoughtIWasFeelingYou = true;
    
    // Start is called before the first frame update
    void Start()
    {
        //BoyIsALiar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BoyIsALiar()
    {
        Debug.Log("RAHHHHHHH");
        if (ThoughtIWasFeelingYou==true) {
            gameObject.transform.position += new Vector3(-385, 0, 0);
            ThoughtIWasFeelingYou = false;
        } else
        {
            gameObject.transform.position += new Vector3(385, 0, 0);
            ThoughtIWasFeelingYou = true;
        }
    }
}
