using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redColourChanger : MonoBehaviour
{

    [SerializeField] private Material myMaterial;
    private float changeColourDuration = 1f;

    private void Start()
    {
        myMaterial.color = Color.black;
    }

    public void redOnEnable()
    {
        // Kick off the change color routine, which is automatically stopped by OnDisable
        StartCoroutine(redChangeColour());
    } 

    public IEnumerator redChangeColour()
    {
        {

            var wait = new WaitForSecondsRealtime(changeColourDuration);

            myMaterial.color = Color.red;
            yield return wait;

            myMaterial.color = Color.black;

        }
    }

}
