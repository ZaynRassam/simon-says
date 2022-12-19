using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenColourChanger : MonoBehaviour
{

    [SerializeField] private Material myMaterial;
    private float changeColourDuration = 1f;

    private void Start()
    {
        myMaterial.color = Color.black;
    }

    public void greenOnEnable()
    {
        // Kick off the change color routine, which is automatically stopped by OnDisable
        StartCoroutine(greenChangeColour());
    } 

    public IEnumerator greenChangeColour()
    {
        {

            var wait = new WaitForSecondsRealtime(changeColourDuration);

            myMaterial.color = Color.green;
            yield return wait;

            myMaterial.color = Color.black;

        }
    }

}
