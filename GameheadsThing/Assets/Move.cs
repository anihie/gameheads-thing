using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

//public vs private -> public variables for things that the user can change (barrier between user and coder)
    public int myInt;

    // Start is called before the first frame update
    //void is the type of variable that the function returns - void indicates that the function returns nothing
    void Start()
    {
        myInt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        myInt = myInt + 1;
        Debug.Log(myInt);

        gameObject.transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
