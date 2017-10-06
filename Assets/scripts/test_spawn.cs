using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class test_spawn : MonoBehaviour {
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private GameObject player;
    public List<GameObject> roomList;
    public GameObject[] roomListArray;
    // Use this for initialization
    void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        //if(player.transform.position.x > transform.position.x)
        //{
        //    Instantiate(prefab, gameObject.GetComponent<Transform>().position, Quaternion.identity);
        //}
        //else if(false)
        //{
        //    Destroy(this.gameObject);
        //}
    }

    GameObject GenerateRoom()
    {
        roomListArray = Resources.LoadAll<GameObject>("Rooms");
        roomList = roomListArray.ToList();
        GameObject roomToBuild = roomList[Random.Range(0, roomList.Count)];
        GameObject newRoom = Instantiate(roomToBuild, transform.position, Quaternion.identity) as GameObject;
        return newRoom;
    }
}