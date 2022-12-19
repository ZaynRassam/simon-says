using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class simonSays : MonoBehaviour
{

    [SerializeField] private GameObject redGameObject;
    [SerializeField] private GameObject blueGameObject;
    [SerializeField] private GameObject greenGameObject;
    [SerializeField] private GameObject yellowGameObject;
    private redColourChanger red;
    private blueColourChanger blue;
    private greenColourChanger green;
    private yellowColourChanger yellow;
    public List<string> pattern = new List<string>();
    public bool gameActive = false;
    [SerializeField] playerClick playerClickLogic;
    [SerializeField] public int level = 1;
    [SerializeField] Text currentLevel;



    // Start is called before the first frame update
    void Start()
    {
        red = redGameObject.GetComponent<redColourChanger>();
        blue = blueGameObject.GetComponent<blueColourChanger>();
        green = greenGameObject.GetComponent<greenColourChanger>();
        yellow = yellowGameObject.GetComponent<yellowColourChanger>();
    }

    // Update is called once per frame
    void Update()
    {
        currentLevel.text = level.ToString();
    }

    public void increaseLevel()
    {
        if (gameActive)
        {
            if (level < 100 && gameActive)
            {
                level += 1;
            }
            else
            {
                Debug.Log("Can't go above level 99!");
            }
        }
    }

    public void decreaseLevel()
    {
        if (gameActive)
        {
            if (level > 1)
            {
                level -= 1;
            }
            else
            {
                Debug.Log("Can't go below level 1!");
            }
        }
    }

    public void runLevel1()
    {
        gameActive = false;
        StartCoroutine(level1());
    }

    private IEnumerator level1()
    {
        string colour;

        pattern.Clear();
        for (int i = 0; i < (level+2); i++)
        {
            randomFunctionPicker();
            yield return new WaitForSeconds(1.5f);
        }
        gameActive = true;
        playerClickLogic.onlyOnce = true;
    }



    private void randomFunctionPicker()
    {
        int randomNum = Random.Range(0, 4);
        switch (randomNum)
        {
            case 0:
                red.redOnEnable();
                pattern.Add("red");
                break;
            case 1:
                blue.blueOnEnable();
                pattern.Add("blue");
                break;
            case 2:
                green.greenOnEnable();
                pattern.Add("green");
                break;
            case 3:
                yellow.yellowOnEnable();
                pattern.Add("yellow");
                break;
        }
    }
}
