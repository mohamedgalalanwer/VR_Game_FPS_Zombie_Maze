using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartNewGame : MonoBehaviour {

    

    IEnumerator WaitAndPrint()
    {
        // suspend execution for 5 seconds
        yield return new WaitForSeconds(60);
        print("WaitAndPrint " + Time.time);
        Application.LoadLevel("Hospital");
    }

    IEnumerator Start()
    {
        print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine
        yield return StartCoroutine("WaitAndPrint");
        print("Done " + Time.time);
    }
}

