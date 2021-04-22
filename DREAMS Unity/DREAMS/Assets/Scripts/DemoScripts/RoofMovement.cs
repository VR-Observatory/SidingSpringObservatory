using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofMovement : MonoBehaviour
{
    public Animator roof_animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RoofAnimation();
    }

    private void RoofAnimation()
    {
        if ((roof_animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !roof_animator.IsInTransition(0)))
        {
            if (Input.GetAxis("Open Roof") > 0.9)
            {
                roof_animator.SetBool("Move", !roof_animator.GetBool("Move"));
            }
        }
    }
}
