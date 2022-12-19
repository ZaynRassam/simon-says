using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowColourChanger : MonoBehaviour
{

    [SerializeField] private Material myMaterial;
    private float changeColourDuration = 1f;

    private void Start()
    {
        myMaterial.color = Color.black;
    }

    public void yellowOnEnable()
    {
        // Kick off the change color routine, which is automatically stopped by OnDisable
        StartCoroutine(yellowChangeColour());
    } 

    public IEnumerator yellowChangeColour()
    {
        {

            var wait = new WaitForSecondsRealtime(changeColourDuration);

            myMaterial.color = Color.yellow;
            yield return wait;

            myMaterial.color = Color.black;

        }
    }

}
