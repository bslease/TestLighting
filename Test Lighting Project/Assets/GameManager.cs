using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text counter;
    private int numBalls = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Resources.Load("Ball"), this.transform.position, this.transform.rotation);
            numBalls++;
            if (numBalls == 1)
            {
                Debug.Log("enabling counter");
                counter.enabled = true;
            }
            counter.text = numBalls.ToString(); 
        }
    }
}
