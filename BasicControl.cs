using UnityEngine;
using System.Collections;

public class BasicControl : MonoBehaviour {

    public static class Globals{

     public static float rotX, rotY, rotZ, speed, roll, rise = 0f;

}
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown("w"))
        {
            Globals.speed = Globals.speed+0.02f;
        }
        if (Input.GetKeyDown("s"))
        {
            Globals.speed = Globals.speed*0.99f;
        }
        if (Input.GetKeyDown("a"))
        {
            Globals.roll = -0.3f;
        }
        if (Input.GetKeyDown("d"))
        {
            Globals.roll = 0.3f;
        }
        if (Input.GetKeyUp("d") || Input.GetKeyUp("a"))
        {
            Globals.roll = 0;
        }
        if (Input.GetKeyDown("q"))
        {
            Globals.rise = -0.3f;
        }
        if (Input.GetKeyDown("e"))
        {
            Globals.rise = 0.3f;
        }
        if (Input.GetKeyUp("q") || Input.GetKeyUp("e"))
        {
            Globals.rise = 0;
        }


 

        transform.Rotate(new Vector3(Globals.rise, 0, Globals.roll)); //Rotates object to mouse position
        Vector3 velVec = Vector3.forward * Globals.speed;
        transform.Translate(velVec);
	}
}
