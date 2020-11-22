using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoves : MonoBehaviour {

    public float speed;
    ObstacleSpawner pipeSpawner = new ObstacleSpawner();
    

	// Use this for initialization
	void Start ()
    {
        
	}

    void speedCheck()
    {
        if (Score.score >= 5 && Score.score < 6)
        {
            speed += 0.01f;
            pipeSpawner.maxTime -= 0.5f;
        }
    }
   

    // Update is called once per frame
    void Update ()
    {
        //speedCheck();
        transform.position += Vector3.left * speed * Time.deltaTime;
	}

    

}
