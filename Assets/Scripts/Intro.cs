using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour {

    public static bool introFinish = false;
    public GameObject spawner;

	public void OpenBin()
    {
        introFinish = true;
        Instantiate(spawner, transform.position, Quaternion.identity);
    }
}
