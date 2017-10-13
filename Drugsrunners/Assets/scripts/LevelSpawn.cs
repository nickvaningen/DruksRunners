using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class test_spawn : MonoBehaviour{
    private float lastSpawn;
    private float distanceOfLastSpawn;
    private float sizeOfLastSpawn;
    private GameObject roomToBuild;
    public List<GameObject> roomList;
    public List<GameObject> chunkList;
    public GameObject[] roomListArray;
    // Use this for initialization
    void Start ()
    {
        distanceOfLastSpawn = 0;
        sizeOfLastSpawn = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(transform.position.x > distanceOfLastSpawn * 5 - 20)
        {
            roomToBuild = GenerateRoom();
            distanceOfLastSpawn += sizeOfLastSpawn/2;
            sizeOfLastSpawn = roomToBuild.transform.localScale.x;
            distanceOfLastSpawn += sizeOfLastSpawn / 2;
            chunkList.Add(Instantiate(roomToBuild, new Vector3(distanceOfLastSpawn * 5, 0.0f, 0.0f), Quaternion.identity));
        }
        if(chunkList[0].transform.position.x < transform.position.x - 20)
        {
            Destroy(chunkList[0]);
            chunkList.Remove(chunkList[0]);
        }
    }

    GameObject GenerateRoom()
    {
        roomListArray = Resources.LoadAll<GameObject>("Rooms");
        roomList = roomListArray.ToList();
        return roomList[Random.Range(0, roomList.Count)];
        //GameObject newRoom = Instantiate(roomToBuild, transform.position, Quaternion.identity) as GameObject;
        //return newRoom;
    }
}