using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileScript : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(1f, 0, 0);
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.StartsWith("enemy")) {
            Destroy(collision.gameObject);
        }
    }
}