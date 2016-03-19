using UnityEngine;
using System.Collections;

public class BasicAI : MonoBehaviour {

    public GameObject Player;

    // Update is called once per frame
    void Update () {

        Vector3 distance = Player.transform.position - this.transform.position;

        if (distance.sqrMagnitude < 100) //Combat Behaviour
        {
            
        }

        if(distance.sqrMagnitude < 20) //Alerted Behaviour
        {
            Vector3 direction = 0.02f * distance / distance.magnitude;

            this.transform.eulerAngles = direction;

            this.transform.Translate(transform.forward);
        }
        else //Patrol Behaviour
        {

        }
        
	
	}
}
