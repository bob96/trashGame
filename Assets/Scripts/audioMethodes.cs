using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioMethodes : MonoBehaviour {


    void ToggleRollInSound()
    {
        AudioManager.PlaySound("driveToScreen");
    }
    void OpenBinSound()
    {
        AudioManager.PlaySound("openContainer");
    }
    void CloseBinSound()
    {
        AudioManager.PlaySound("closeContainer");
    }
}
