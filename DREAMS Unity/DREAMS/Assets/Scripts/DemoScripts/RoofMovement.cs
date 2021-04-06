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

    private void RoofAnimation() {
        if (Input.GetAxis("Oculus_CrossPlatform_PrimaryIndexTrigger") > 0.9)
        {
            roof_animator.SetBool("Move", true);
        }
        else if (Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.9) {
            roof_animator.SetBool("Move", false);
        }
    }
}
