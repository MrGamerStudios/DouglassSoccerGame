using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boundry")
        {
            StartCoroutine("waitBoundry");
        }

        if (other.gameObject.tag == "Boundry1")
        {
            StartCoroutine("waitBoundry1");
        }

        if (other.gameObject.tag == "Agk" )
        {
            StartCoroutine("Agk");
        }

        if (other.gameObject.tag == "Hgk")
        {
            StartCoroutine("Hgk");
        }
    }

    IEnumerator waitBoundry()
    {
        BeforeBoundry();
        yield return new WaitForSeconds(5);
        print ("Waited 5 Seconds");
        OtherBoundry();

    }

    void BeforeBoundry()
    {
        var rigidbody = this.GetComponent<Rigidbody>();
        transform.position = GameObject.Find("BoundryB").transform.position;
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.useGravity = false;
    }

    void OtherBoundry()
    {
        var rigidbody = this.GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.useGravity = true;
    }

    IEnumerator waitBoundry1()
    {
        BeforeBoundry1();
        yield return new WaitForSeconds(5);
        print("Waited 5 Seconds");
        OtherBoundry1();

    }
    void BeforeBoundry1()
    {
        var rigidbody = this.GetComponent<Rigidbody>();
        transform.position = GameObject.Find("Boundry1B").transform.position;
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.useGravity = false;
    }


    void OtherBoundry1()
    {
        var rigidbody = this.GetComponent<Rigidbody>();
        transform.position = GameObject.Find("Boundry1B").transform.position;
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.useGravity = true;
    }

    IEnumerator Agk()
    {
        BeforeAgk();
        yield return new WaitForSeconds(5);
        print("Waited 5 Seconds");
        OtherAgk();

    }

    void BeforeAgk()
    {
        var rigidbody = this.GetComponent<Rigidbody>();
        transform.position = GameObject.Find("HGoalKick").transform.position;
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.useGravity = false;
    }

    void OtherAgk()
    {
        var rigidbody = this.GetComponent<Rigidbody>();
        transform.position = GameObject.Find("HGoalKick").transform.position;
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.useGravity = true;
    }

    IEnumerator Hgk()
    {
        BeforeHgk();
        yield return new WaitForSeconds(5);
        print("Waited 5 Seconds");
        OtherHgk();

    }

    void BeforeHgk()
    {
        var rigidbody = this.GetComponent<Rigidbody>();
        transform.position = GameObject.Find("AGoalKick").transform.position;
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.useGravity = false;
    }


    void OtherHgk()
    {
        var rigidbody = this.GetComponent<Rigidbody>();
        transform.position = GameObject.Find("AGoalKick").transform.position;
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.useGravity = true;
    }
}