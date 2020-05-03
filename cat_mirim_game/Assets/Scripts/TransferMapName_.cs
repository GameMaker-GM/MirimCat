using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransferMapName_ : MonoBehaviour
{

    public string transferMapName; //이동할 맵의 이름

    private Moving_Object thePlayer;

    // Use this for initialization
    void Start()
    {
        thePlayer = FindObjectOfType<Moving_Object>(); //다수의 객체
                                                       // GetComponent//단일객체, 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            thePlayer.currentMapName = transferMapName;
            SceneManager.LoadScene(transferMapName);
        }
    }
}

 