using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public Transform tr;
    public float speed = 1f;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Vector2 target = new Vector2(tr.position.x - 0.1f, tr.position.y);
        tr.position = Vector2.MoveTowards(tr.position, target, speed * Time.deltaTime);
    }
}
