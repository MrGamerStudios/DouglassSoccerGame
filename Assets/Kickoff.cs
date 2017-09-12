using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kickoff : MonoBehaviour
{
    public bool activateTrigger = false;
    public bool activatePlayer = false;
    public GameObject Sound;
    public GameObject Player;

    void Start()
    {
        Sound.SetActive(false);
    }


    void Update()
    {

        if (activateTrigger)
        {
            Sound.SetActive(true);
        }

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kickoff")
        {
            StartCoroutine("wait");
        }

        if (other.gameObject.tag == "GoalKick")
        {
            StartCoroutine("wait");
        }


    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
        print("Waited 5 Seconds");
        Other();

    }

    void Other()
    {
        activateTrigger = true;
        Sound.SetActive(false);
    }

}

//System.Threading.Thread.Sleep(5000);
//Kickoff