using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour
{
    GameObject helicopter;
    // Start is called before the first frame update
    void Start()
    {
        helicopter = GameObject.Find("Helicopter");
    }

    private void Update()
    {
        Vector3 v = helicopter.transform.position;
        v.y = transform.position.y;
        transform.LookAt(v);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, 0, 0.2f);
    }
}