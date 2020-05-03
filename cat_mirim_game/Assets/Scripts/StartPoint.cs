using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour {

    public string startPoint; // 맵이 이동, 플레이어가 시작 될 위치
    private Moving_Object thePlayer;
    private CameraManager_ theCamera;

	// Use this for initialization
	void Start () {
        theCamera = FindObjectOfType<CameraManager_>();
        thePlayer = FindObjectOfType<Moving_Object>();

		if (startPoint == thePlayer.currentMapName)
        {
            theCamera.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, theCamera.transform.position.z);
            thePlayer.transform.position = this.transform.position;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
