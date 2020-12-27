using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    bool isMoving;
    public float scrollSpeed;
    public Transform background;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<GameManager>().playingEvent += StartMoving;
        FindObjectOfType<GameManager>().overEvent += StopMoving;
    }
   
    // Update is called once per frame
    void Update()
    {
        ResetPosition();
    
        if (isMoving == true)
        {
            background.position += new Vector3(-scrollSpeed, 0, 0) * Time.deltaTime;
        }
        else
        {
            background.position += new Vector3(0, 0, 0) * Time.deltaTime;
        }
    }

    void ResetPosition()
    {
        // if() 만약에 카메라 밖을 넘어가면 
        // background의 position을 0으로 바꾼다.

        if (background.position.x <= -6.5f)
            background.position = new Vector3(0, 0, 0);
    }
    void StartMoving()
    {
        isMoving = true;
    }
    void StopMoving()
    {
        isMoving = false;
    }
}
