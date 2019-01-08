using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject particalFx;
    private bool instatiatedVfx;
    private void Start()
    {
        instatiatedVfx = false;
    }


    private void Update()
    {
        if (TrashGenerator.trashToSpawnCount <= 0 && Intro.introFinish && !instatiatedVfx)
        {
            Instantiate(particalFx);
            instatiatedVfx = true;
        }
    }
}
