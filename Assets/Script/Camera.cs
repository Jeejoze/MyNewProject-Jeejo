using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Player;
    public Vector3 offset;
    public float xMin = 0;
    public float xMax = 21.0f;
    public float yMin = -5.0f;
    public float yMax =  10;
    private  Vector3 newPos;
    // Start is called before the first frame update
    void Start()
    {
        if(Player == null)
        {
            Player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        newPos = Player.transform.position + offset;
        float x = Mathf.Clamp(newPos.x, xMin, xMax);
        float y = Mathf.Clamp(newPos.y, yMin, yMax);
        transform.position = new Vector3(x,y, newPos.z);
    }
}
