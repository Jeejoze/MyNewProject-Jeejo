using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parabola : MonoBehaviour
{
    private Vector3 Center;
    // Start is called before the first frame update
    void Start()
    {
        Center = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Sin(Time.time * 0.5f) * 10;
        Debug.Log(x);

        transform.position = new Vector3(x + Center.x, Center.y, 0);
    }
}
