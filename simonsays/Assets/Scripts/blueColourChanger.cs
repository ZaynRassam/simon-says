using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueColourChanger : MonoBehaviour
{

    [SerializeField] private Material myMaterial;
    private float changeColourDuration = 1f;

    private void Start()
    {
        myMaterial.color = Color.black;
    }

    public void blueOnEnable()
    {
        // Kick off the change color routine, which is automatically stopped by OnDisable
        StartCoroutine(blueChangeColour());
    } 

    public IEnumerator blueChangeColour()
    {
        {

            var wait = new WaitForSecondsRealtime(changeColourDuration);

            myMaterial.color = Color.blue;
            yield return wait;

            myMaterial.color = Color.black;

        }
    }

}
