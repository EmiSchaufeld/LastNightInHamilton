using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Clock : MonoBehaviour
{
    public int minutes;
    public int hours;
    public string ampm;
    public Flowchart mainFlowchart; 

  


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string minutesString = minutes.ToString();
        string hoursString = hours.ToString();

        if (minutes == 60) {
            minutes = 0;
            hours++;
        }
      
         if(minutes < 10){
            minutesString = "0" + minutesString;
         }

       mainFlowchart.SetIntegerVariable("intMinutes", minutes);
       mainFlowchart.SetIntegerVariable("intHours", hours);

       mainFlowchart.SetStringVariable("stringMinutes", minutesString);
       mainFlowchart.SetStringVariable("stringHours", hoursString);
         
    }
    public void AddMinuteValue(int addedMinutes){
        minutes += addedMinutes;
        //call method in fungus to add time in conversations

    }

    
}
