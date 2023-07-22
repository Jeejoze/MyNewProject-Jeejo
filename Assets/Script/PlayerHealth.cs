using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        if(Player == null)
        {
             Player =  GameObject.FindGameObjectWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckFall();
    }
    private void CheckFall()
    {
        if(Player.transform.position.y <= -7)
        {
             Destroy(Player, 0.1f);
              SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
