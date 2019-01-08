using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour {


    private void OnTriggerStay(Collider other)
    {

        //putting plastic in the Dubstin
        if(gameObject.transform.parent.tag == "PlasticTrash" && other.gameObject.transform.parent.gameObject.tag == "PlasticDubstin" && !DragTrash.isMouseDragging)
        {
            gameObject.transform.parent.gameObject.SetActive(false);
            TrashGenerator.trashToSpawnCount--;
        }
        //putting plastic in the Dubstin
        else if (gameObject.transform.parent.tag == "PaperTrash" && other.gameObject.transform.parent.gameObject.tag == "PaperDubstin" && !DragTrash.isMouseDragging)
        {
            gameObject.transform.parent.gameObject.SetActive(false);
            TrashGenerator.trashToSpawnCount--;
        }
        //putting plastic in the Dubstin
        else if (gameObject.transform.parent.tag == "GlassTrash" && other.gameObject.transform.parent.gameObject.tag == "GlassDubstin" && !DragTrash.isMouseDragging)
        {
            gameObject.transform.parent.gameObject.SetActive(false);
            TrashGenerator.trashToSpawnCount--;
        }
        //putting plastic in the Dubstin
        else if (gameObject.transform.parent.tag == "FoodTrash" && other.gameObject.transform.parent.gameObject.tag == "FoodDubstin" && !DragTrash.isMouseDragging)
        {
            gameObject.transform.parent.gameObject.SetActive(false);
            TrashGenerator.trashToSpawnCount--;
        }
    }

   
}

