using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorTest : MonoBehaviour
{

    public Animator animator;
    public int floorNum = 2;
    public GameObject position1;
    public GameObject position2;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
            LiftTo1();
        if (Input.GetKey(KeyCode.K))
            LiftTo2();
    }

    //plan 1 physically moving
    public void LiftUp() {
        animator.SetInteger("Floor",2);
    }

    public void LiftDown()
    {
        animator.SetInteger("Floor", 1);
    }

    public void LiftTo1() {
        player.transform.position = position1.transform.position;
    }

    //plan 2 teleport to different elevator
    public void LiftTo2()
    {
        player.transform.position = position2.transform.position;
    }
}
