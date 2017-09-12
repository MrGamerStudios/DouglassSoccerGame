using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BallManager : MonoBehaviour

{
    public int HScore;
    public int AScore;
    public GameObject Mercy;
    public GameObject GameOver;
    public GameObject MHFS;
    public GameObject MAFS;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "HGoal")
        {
            StartCoroutine("HGoal");
        }

        if (other.gameObject.tag == "AGoal")
        {
            StartCoroutine("AGoal");
        }
    }

    public void Update()
    {
        GameObject.Find("AScore").GetComponent<TextMesh>().text = AScore + "";
        GameObject.Find("HScore").GetComponent<TextMesh>().text = HScore + "";
        GameObject.Find("AwayScore").GetComponent<Text>().text = AScore + "";
        GameObject.Find("HomeScore").GetComponent<Text>().text = HScore + "";
        GameObject.Find("MHFS").GetComponent<Text>().text = HScore + "";
        GameObject.Find("MAFS").GetComponent<Text>().text = AScore + "";
        }

    public void FixedUpdate()
    {
        if (AScore - HScore >= 10)
        {
            Mercy.SetActive(true);
            MHFS.SetActive(true);
            MAFS.SetActive(true);
            Time.timeScale = 0.0f;
        }

        if (HScore - AScore >= 10)
        {
            Mercy.SetActive(true);
            MHFS.SetActive(true);
            MAFS.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }

    IEnumerator HGoal()
    {
        BeforeHGoal();
        yield return new WaitForSeconds(5);
        print("Waited 5 Seconds");
        OtherHGoal();

    }

    void BeforeHGoal()
    {
        var rigidbody = this.GetComponent<Rigidbody>();
        transform.position = GameObject.Find("BallPosition").transform.position;
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.useGravity = false;
        HScore += 1;
    }

    void OtherHGoal()
    {
        var rigidbody = this.GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.useGravity = true;
    }

    IEnumerator AGoal()
    {
        BeforeAGoal();
        yield return new WaitForSeconds(5);
        print("Waited 5 Seconds");
        OtherAGoal();

    }

    void BeforeAGoal()
    {
        var rigidbody = this.GetComponent<Rigidbody>();
        transform.position = GameObject.Find("BallPosition").transform.position;
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.useGravity = false;
        AScore += 1;
    }

    void OtherAGoal()
    {
        var rigidbody = this.GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.useGravity = true;
    }

}


