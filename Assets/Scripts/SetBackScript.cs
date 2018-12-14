using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBackScript : MonoBehaviour
{
    
    public GameObject player;
    public GameObject checkPoint;
    public float checkPointPosX;
    public float checkPointPosY;
    public Vector2 playerPos;

    void Start()
    {
        //sätter chackPointPosX till värdet av checkpointens position på X axeln
        checkPointPosX = checkPoint.transform.position.x;

        //sätter chackPointPosY till värdet av checkpointens position på Y axeln men plussar på 0.5
        checkPointPosY = checkPoint.transform.position.y + 0.5f;

    }

    void Update()
    {
        //sätter playerPos till värdet av spelarens position
        playerPos = player.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //sätter playerPos på X axeln till checkPointPosX
            playerPos.x = checkPointPosX;

            //sätter playerPos på Y axeln till checkPointPosY
            playerPos.y = checkPointPosY;

            //sätter spelarens position till playerPos
            player.transform.position = playerPos;
        }
    }
}
