using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_move : MonoBehaviour
{
    public Transform tr;
    public float speed = 1f;
    public Gauge gauge;
    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        gauge = FindObjectOfType<Gauge>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 target = new Vector2(tr.position.x - 0.1f, tr.position.y);
        tr.position = Vector2.MoveTowards(tr.position, target, speed * Time.deltaTime);
        if (tr.position.x < -5)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            gauge.currentGauge -= damage;
        }
    }
    
}
