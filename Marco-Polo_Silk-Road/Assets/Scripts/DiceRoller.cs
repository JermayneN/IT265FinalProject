using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoller : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        DiceValues = new int[6];
        theStateManager = GameObject.FindObjectOfType<StateManager>();
    }

    StateManager theStateManager;

    public int[] DiceValues;

    public Sprite[] DiceImageOne;
    public Sprite[] DiceImageZero;


    // Update is called once per frame
    void Update()
    {
		
    }

    public void RollTheDice()
    {

        if (theStateManager.IsDoneRolling == true)
        {
            // We've already rolled this turn.
            return;
        }

        theStateManager.DiceTotal = 0;
        for (int i = 0; i < DiceValues.Length; i++)
        {
            DiceValues[i] = Random.Range(0, 2);
            theStateManager.DiceTotal += DiceValues[i];

            if (DiceValues[i] == 0)
            {
                this.transform.GetChild(i).GetComponent<Image>().sprite = 
                    DiceImageZero[Random.Range(0, DiceImageZero.Length)];
            }
            else
            {
                this.transform.GetChild(i).GetComponent<Image>().sprite = 
                    DiceImageOne[Random.Range(0, DiceImageOne.Length)];                
            }

        }

        // If we had an animation, we'd have to wait for it to finish before
        // we set doneRolling, but we can just set it right away
        //theStateManager.DiceTotal = 15;
        theStateManager.IsDoneRolling = true;
        theStateManager.CheckLegalMoves();


        //Debug.Log("Rolled: " + DiceTotal);
    }
}
