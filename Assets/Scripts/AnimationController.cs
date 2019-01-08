using System.Collections;
using System.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    private Animator anim;
    public static string toOpen;
    

    private void Awake()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }

    private void Start()
    {
       
    }

    private void Update()
    {
        if (Intro.introFinish)
        {
            anim.enabled = true;
            anim.SetBool("IntroFinishgg", true);
        }
        if (toOpen == null)
        {
            return;
        }
        else if(toOpen == gameObject.transform.parent.tag.Replace("Dubstin", "") && DragTrash.binOpen)
        {
            anim.SetBool("binOpen", true);
            
        }
        else if(!DragTrash.binOpen)
        {
            anim.SetBool("binOpen", false);
            
        }

    }


}
