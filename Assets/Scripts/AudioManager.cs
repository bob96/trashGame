using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public static AudioClip pickTrash, openContainer, closeContainer, drivingToTheScreen, foodToContainer, plasticToContainer, paperToContainer, glassToContainer;
    public AudioClip pickTrashRc, openContainerRc, closeContainerRc, drivingToTheScreenRc, foodToContainerRc, plasticToContainerRc, paperToContainerRc, glassToContainerRc;
    static AudioSource audioSrc;
   
    private void Start()
    {
      
       

        pickTrash = pickTrashRc;
        openContainer = openContainerRc;
        closeContainer = closeContainerRc;
        drivingToTheScreen = drivingToTheScreenRc;
        foodToContainer = foodToContainerRc;
        plasticToContainer = plasticToContainerRc;
        paperToContainer = paperToContainerRc;
        glassToContainer = glassToContainerRc;

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
       
        switch (clip)
        {
            case "pickTrash":
                audioSrc.PlayOneShot(pickTrash);
                break;
            case "openContainer":
                audioSrc.PlayOneShot(openContainer);
                break;
            case "closeContainer":
                audioSrc.PlayOneShot(closeContainer);
                break;
            case "drivingToTheScreen":
                audioSrc.PlayOneShot(drivingToTheScreen);
                break;
            case "foodToContainer":
                audioSrc.PlayOneShot(foodToContainer);
                break;
            case "plasticToContainer":
                audioSrc.PlayOneShot(plasticToContainer);
                break;
            case "paperToContainer":
                audioSrc.PlayOneShot(paperToContainer);
                break;
            case "glassToContainer":
                audioSrc.PlayOneShot(glassToContainer);
                break;
            
        }
        
     
    }

}
