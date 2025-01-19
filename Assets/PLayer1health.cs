using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLayer1health : MonoBehaviour
{
    Rigidbody2D rig;
    public static int Playerhealth = 1000;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        print(Playerhealth);

        if (Playerhealth <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
