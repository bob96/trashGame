using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashGenerator : MonoBehaviour {

    public GameObject[] TrashToSpawn;
    public static int trashToSpawnCount;
    public Vector2 spawnBoxX;
    public Vector2 spawnBoxY;

    private void Start()
    {
        trashToSpawnCount = TrashToSpawn.Length;
        SpawnTrash();
    }


    void SpawnTrash()
    {
        GameObject trashGoParent = GameObject.FindGameObjectWithTag("Finish");
        foreach( GameObject trash in TrashToSpawn)
        {
            //setting a random position for the trash
            Vector3 randPosition = new Vector3(Random.Range(spawnBoxX.x, spawnBoxX.y), Random.Range(spawnBoxY.x, spawnBoxY.y), -10f);
            //setting a random Z position for the trash
            Vector3 randRotation = new Vector3(0f,0f, Random.Range(-180, 180));
            GameObject Trash = Instantiate(trash, randPosition, Quaternion.Euler(randRotation));
            Trash.transform.parent = trashGoParent.transform;
        } 

    }
}
