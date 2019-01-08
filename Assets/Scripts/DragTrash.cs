using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragTrash : MonoBehaviour{

    //public
    public static bool binOpen;
    
    //private
    private GameObject getTarget;
    public static bool isMouseDragging;
    private Vector3 offsetValue;
    private Vector3 positionOfScreen;



    void Update()
    {
        //Mouse Button Press Down
        if (Input.GetMouseButtonDown(0))
        {   
            //make a raycast to the object the first object detected will be dragged
            RaycastHit hitInfo;
            getTarget = ReturnClickedObject(out hitInfo);
            if (getTarget != null)
            {
                AudioManager.PlaySound("pickTrash");
                isMouseDragging = true;
                //Converting world position to screen position
                positionOfScreen = Camera.main.WorldToScreenPoint(getTarget.transform.position);
                //get the offsedt value between the mouse position and the target
                offsetValue = getTarget.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, positionOfScreen.z));
                
            }
            
        }

        //Mouse Button Up
        if (Input.GetMouseButtonUp(0))
        {
            
            isMouseDragging = false;
            //close dubstin and send signal to the animation controller
            binOpen = false;
            OpenAndCloseDubstin(180);
            
        }

        //Is mouse Moving
        if (isMouseDragging)
        {
            //tracking mouse position.
            Vector3 currentScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, positionOfScreen.z);

            //converting screen position to world position with offset changes.
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenSpace) + offsetValue;

            //pick trash sound
            

            //It will update target gameobject's current postion.
            getTarget.transform.position = currentPosition;
            //open the dubstin
            binOpen = true;
            //open animation signal
            AnimationController.toOpen = getTarget.tag.Replace("Trash", "");
           
            OpenAndCloseDubstin(90f);
            
        }


    }

    //Method to Return Clicked Object
    GameObject ReturnClickedObject(out RaycastHit hit)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
        {
            
            //getting the target gameObject
            target = hit.collider.gameObject;
        }

        //excluding background and dubstins to move
        if(target.tag == "BackGround" || target.tag == "GlassDubstin"
            || target.tag == "PaperDubstin"
            || target.tag == "PlasticDubstin"
            || target.tag == "FoodDubstin")
        {
            return null;
        }

        return target.transform.parent.gameObject;
    }

    void OpenAndCloseDubstin(float Angle)
    {
        GameObject bin = GameObject.FindGameObjectWithTag("Player");
        //plastic
        if (getTarget.tag == "PlasticTrash")
        {
           

           GameObject plasticDubstin = FindChildWithTag(bin.transform,"PlasticDubstin");
            Debug.Log(plasticDubstin);
            Transform plasticDubstinChild = FindChildWithTag(plasticDubstin.transform, "Top").transform;
            
            if (plasticDubstinChild == null)
            {
                Debug.Log("Error");
            }
            else
            {
                Debug.Log(plasticDubstinChild);
                plasticDubstinChild.localRotation = Quaternion.Euler(-Angle, 0, 0);
            }
           
        }
        //paper
        if (getTarget.tag == "PaperTrash")
        {
            GameObject paperDubstin = FindChildWithTag(bin.transform, "PaperDubstin");
            Transform paperDubstinChild = FindChildWithTag(paperDubstin.transform, "Top").transform;
            if (paperDubstinChild == null)
            {
                Debug.Log("Error");
            }
            else
            {
                Debug.Log(paperDubstinChild);
                paperDubstinChild.localRotation = Quaternion.Euler(-Angle, 0, 0);
            }

        }
        //food
        if (getTarget.tag == "FoodTrash")
        {
            GameObject foodDubstin = FindChildWithTag(bin.transform, "FoodDubstin");
            Transform foodDubstinChild = FindChildWithTag(foodDubstin.transform, "Top").transform;
            if (foodDubstinChild == null)
            {
                Debug.Log("Error");
            }
            else
            {
                Debug.Log(foodDubstinChild);
                foodDubstinChild.localRotation = Quaternion.Euler(-Angle, 0, 0);
            }

        }
        //glass 
        if (getTarget.tag == "GlassTrash")
        {
            GameObject glassDubstin = FindChildWithTag(bin.transform, "GlassDubstin");
            Transform glassDubstinChild = FindChildWithTag(glassDubstin.transform, "Top").transform;
            if (glassDubstinChild == null)
            {
                Debug.Log("Error");
            }
            else
            {
                Debug.Log(glassDubstinChild);
                glassDubstinChild.localRotation = Quaternion.Euler(-Angle, 0, 0);
            }

        }

    }

    
    


    //finding a child of a parent with the childs tag
    GameObject FindChildWithTag(Transform parent,string tag)
    {
        foreach(Transform child in parent)
        {   

            if(child.gameObject.tag == tag)
            {
                return child.gameObject;
            }
        }
        return null;
    }
    


}
