using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ShieldAbility : MonoBehaviour
{
    public static bool ShieldAnimm=false;
    public void DisCol()
    {
        ShieldAnimm = true;
        StartCoroutine(DisableObjects());
    }

    IEnumerator DisableObjects()
    {
        GameObject[] objectsToDisable = GameObject.FindGameObjectsWithTag("Chale");

        foreach (GameObject obj in objectsToDisable)
        {
            Debug.Log(obj);
            Collider2D collider = obj.GetComponent<Collider2D>();

            if (collider != null)
            {
                collider.enabled = false;
            }
            
                
             
        }

        yield return new WaitForSeconds(4f);
        ShieldAnimm=false;

        foreach (GameObject obj in objectsToDisable)
        {
            Collider2D collider = obj.GetComponent<Collider2D>();


            if (collider != null)
            {
                collider.enabled = true;
            }

        }
    }

}
