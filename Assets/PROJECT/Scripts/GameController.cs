using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public player player;
    public float resettimer = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.holdingball == false) ;
        {
            resettimer -= Time.deltaTime;
            if(resettimer <= 0)
            {
                SceneManager.LoadScene("Game");
            }           
        }
    }
}
