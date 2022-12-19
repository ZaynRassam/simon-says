using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerClick : MonoBehaviour
{
    [SerializeField] Material redMaterial;
    [SerializeField] Material blueMaterial;
    [SerializeField] Material greenMaterial;
    [SerializeField] Material yellowMaterial;
    [SerializeField] simonSays simonSaysLogic;
    public List<string> playerPattern = new List<string>();
    public bool onlyOnce = true;
    private int count = 0;


    private void Start()
    {
        simonSaysLogic = GameObject.FindGameObjectWithTag("simonsays").GetComponent<simonSays>();
    }

    private void Update()
    {

        if (playerPattern.Count == (simonSaysLogic.level+2) && onlyOnce)
        {
            onlyOnce = false;

            for (int i=0; i < playerPattern.Count; i++)
            {
                if (playerPattern[i] == simonSaysLogic.pattern[i]) {
                    count++;
                }
                else
                {
                    Debug.Log("Wrong Combination!");
                    break;
                }
            }


            if (count == simonSaysLogic.level + 2)
            {
                Debug.Log("Congrats!");
                simonSaysLogic.level++;
            }
            count = 0;
            playerPattern.Clear();
            simonSaysLogic.pattern.Clear();
            
        }
    }

    public void redClick()
    {
        string colour = "";
        if (simonSaysLogic.gameActive)
        {
            redMaterial.color = Color.red;
            playerPattern.Add("red");
        }
    }

    public void blueClick()
    {
        string colour = "";
        if (simonSaysLogic.gameActive)
        {
            blueMaterial.color = Color.blue;
            playerPattern.Add("blue");
        }
    }    
    
    public void greenClick()
    {
        string colour = "";
        if (simonSaysLogic.gameActive)
        {
            greenMaterial.color = Color.green;
            playerPattern.Add("green");
        }
    }   
    
    public void yellowClick()
    {
        string colour = "";
        if (simonSaysLogic.gameActive)
        {
            yellowMaterial.color = Color.yellow;
            playerPattern.Add("yellow");
        }
    }


    public void releaseClick()
    {
        if (simonSaysLogic.gameActive)
        {
            redMaterial.color = Color.black;
            blueMaterial.color = Color.black;
            greenMaterial.color = Color.black;
            yellowMaterial.color = Color.black;
        }
    }
}
