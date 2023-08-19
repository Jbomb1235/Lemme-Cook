using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraChange : MonoBehaviour
{
    public PolygonCollider2D MainRoom;
    public PolygonCollider2D Room1;
    public PolygonCollider2D Room2;
    public PolygonCollider2D Room3;
    public PolygonCollider2D Room4;
    public PolygonCollider2D Room5;
    public CinemachineConfiner confiner;

    public GameObject Player;

    public GameObject r1;
    public GameObject r2;
    public GameObject r3;
    public GameObject r4;
    public GameObject r5;
    public GameObject rm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name=="room1")
        {
            confiner.m_BoundingShape2D = Room1;
            r1.SetActive(false);
            r2.SetActive(false);
            r3.SetActive(false);
            r4.SetActive(false);
            r5.SetActive(true);
            rm.SetActive(false);
        }
        if (other.gameObject.name=="room2")
        {
            confiner.m_BoundingShape2D = Room2;
            r1.SetActive(false);
            r2.SetActive(true);
            r3.SetActive(false);
            r4.SetActive(false);
            r5.SetActive(false);
            rm.SetActive(false);
        }
        if (other.gameObject.name=="room3")
        {
            confiner.m_BoundingShape2D = Room3;
            r1.SetActive(false);
            r2.SetActive(false);
            r3.SetActive(true);
            r4.SetActive(false);
            r5.SetActive(false);
            rm.SetActive(false);
        }
        if (other.gameObject.name=="room4")
        {
            confiner.m_BoundingShape2D = Room4;
            r1.SetActive(false);
            r2.SetActive(false);
            r3.SetActive(false);
            r4.SetActive(true);
            r5.SetActive(false);
            rm.SetActive(false);
        }
        if (other.gameObject.name=="room5")
        {
            confiner.m_BoundingShape2D = Room5;
            r1.SetActive(true);
            r2.SetActive(false);
            r3.SetActive(false);
            r4.SetActive(false);
            r5.SetActive(false);
            rm.SetActive(false);
        }
        if (other.gameObject.name=="Quad")
        {
            confiner.m_BoundingShape2D = MainRoom;
            r1.SetActive(false);
            r2.SetActive(false);
            r3.SetActive(false);
            r4.SetActive(false);
            r5.SetActive(false);
            rm.SetActive(true);
        }
    }
}
