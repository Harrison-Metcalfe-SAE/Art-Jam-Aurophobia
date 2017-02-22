using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deactivateRooms : MonoBehaviour
{

    public GameObject redRoom;
    public GameObject blueRoom;
    public GameObject purpleRoom;
    public GameObject greenRoom;
    public GameObject endRoom;
    public bool endRoomIsDying = false;
    public float timeLeft;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (endRoomIsDying)
        {
            timeLeft -= Time.deltaTime;
        }

        if (timeLeft < 0)
        {
            endRoomIsDying = false;
            endRoom.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        redRoom.SetActive(false);
        blueRoom.SetActive(false);
        greenRoom.SetActive(false);
        purpleRoom.SetActive(false);
        timeLeft = 5;
        endRoomIsDying = true;
    }
}