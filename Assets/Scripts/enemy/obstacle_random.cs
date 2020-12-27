using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_random : MonoBehaviour
{
    float RandomY, timer;
    Vector2 RandomPos;
    public GameObject pipe;
  

    // Update is called once per frame
    void Update()
    {
    
        RandomY = UnityEngine.Random.Range(2f, -1.2f);

        RandomPos = new Vector2(gameObject.transform.position.x , RandomY);

        timer -= Time.deltaTime;

        if (timer <= 0.0f)
        {
            GameObject SpawnEnemy = Instantiate(pipe, RandomPos, Quaternion.identity);
            timer = 1.6f;
        }

    }
}
