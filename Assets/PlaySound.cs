using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public bool activateTrigger = false;
    public GameObject Sound;

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
        if (other.gameObject.tag == "HGoal")
        {
            activateTrigger = true;
            Sound.SetActive(false);
        }
    }
}