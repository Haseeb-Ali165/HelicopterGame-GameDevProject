using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    GameObject helicopter;
    // Start is called before the first frame update
    void Start()
    {
        helicopter = GameObject.Find("Helicopter");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, 0, 0.5f);
        transform.LookAt(helicopter.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Heli"))
        {
            SceneManager.LoadScene("gameover");
        }
    }
}