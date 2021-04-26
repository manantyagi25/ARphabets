using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript_Orange : MonoBehaviour
{
    public GameObject CoffeeMachine;
    private bool rotateStatus = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(rotateStatus == true)
            CoffeeMachine.transform.Rotate(0, 0, 50 * Time.deltaTime);
    }

    public void RotateMachine()
    {
        if (rotateStatus == false)
        {
            rotateStatus = true;
        }
        else
        {
            rotateStatus = false;
        }
    }
}
