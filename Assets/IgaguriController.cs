using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriController : MonoBehaviour
{
    public int point;
    public void shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
        GetComponent<SphereCollider>().enabled = false;
        GameObject.FindGameObjectWithTag("Canvas").GetComponent<ScoreText>().AddPoint(point);
        Debug.Log("Igaguri");

    }
    void Start()
    {
        //shoot(new Vector3(0, 200, 2000)); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
