using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 3; i++)
        {
            Vector3 v = new Vector3(Random.Range(-500, 500), Random.Range(50, 150), Random.Range(-500, 500));
            //GameObject.Instantiate(enemy, v, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}