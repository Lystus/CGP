using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed = 5;
    public float clamppos;
    public Vector3 startpos;
    void Start()
    {
        startpos = transform.position;
    }
    void FixedUpdate()
    {
        float newpos = Mathf.Repeat(Time.time * speed, clamppos);
        transform.position = startpos + Vector3.left * newpos;
    }
    
}
