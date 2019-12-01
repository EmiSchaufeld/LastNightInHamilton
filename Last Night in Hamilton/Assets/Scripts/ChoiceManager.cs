using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public enum OlderKidsCheckpoint
{
    checkpointZero,
    checkpointOne,
    checkpointTwo,
    checkpointThree
}


public class ChoiceManager : MonoBehaviour
{

    //public 
    public Flowchart mainFlowchart;

    public OlderKidsCheckpoint currentOlderKidsCheckpoint = OlderKidsCheckpoint.checkpointZero;
    public Block olderKidController = new Block();
    //int olderKidsNumber;

    // Start is called before the first frame update
    void Start()
    {
        //olderKidController.
            
    }

    // Update is called once per frame
    void Update()
    {
        if (currentOlderKidsCheckpoint != (OlderKidsCheckpoint)mainFlowchart.GetIntegerVariable("olderKids")) {

            currentOlderKidsCheckpoint = (OlderKidsCheckpoint)mainFlowchart.GetIntegerVariable("olderKids");

            switch (currentOlderKidsCheckpoint)
            {
                case OlderKidsCheckpoint.checkpointZero: Debug.Log("You haven't talked yet"); break;
                case OlderKidsCheckpoint.checkpointOne: Debug.Log("You chose choice 1"); break;
            }

        }

         

                // Do something
        }

    /*
    public void StoryPoint(){

        switch(story){

            case OlderKids:

                if(olderCheckpoint == 0){ mainFlowchart etc etc }
                if(olderCheckpoint == 1){ mainFlowchart etc etc }

            break;
        }

    }





    */

    public void OlderKidsStoryPoint()
    {
        switch(currentOlderKidsCheckpoint)
    {
            case OlderKidsCheckpoint.checkpointZero: mainFlowchart.ExecuteBlock("Older Crowd 1"); break;
            case OlderKidsCheckpoint.checkpointOne: mainFlowchart.ExecuteBlock("Older Crowd 2"); break;
        }
    }
}


