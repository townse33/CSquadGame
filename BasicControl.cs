using UnityEngine;
using System.Collections;

public class BasicControl : MonoBehaviour {

    public static class Globals{

     public static float rotX, rotY, rotZ, speed, roll = 0f;

}
	// Update is called once per frame
	void Update () {

        

        Globals.rotX = Globals.rotX + 0.002f * (Input.mousePosition.x-200); //Gets mouse X
        Globals.rotY = Globals.rotY - 0.002f * (Input.mousePosition.y-200); //Gets mouse Y

        

        if(Input.GetKeyDown("w"))
        {
            Globals.speed = Globals.speed+0.01f;
        }
        if (Input.GetKeyDown("s"))
        {
            Globals.speed = Globals.speed - 0.01f;
        }
        if (Input.GetKeyDown("a"))
        {
            Globals.roll = -1;
        }
        if (Input.GetKeyDown("d"))
        {
            Globals.roll = 1;
        }
        if (Input.GetKeyUp("d") || Input.GetKeyUp("a"))
        {
            Globals.roll = 0;
        }

        Globals.rotZ = Globals.rotZ + Globals.roll;

        transform.eulerAngles = new Vector3(Globals.rotY, Globals.rotX, Globals.rotZ); //Rotates object to mouse position
        Vector3 velVec = Vector3.forward * Globals.speed;
        transform.Translate(velVec);
	}
}
