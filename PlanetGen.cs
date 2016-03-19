using System.IO;
using UnityEngine;
using System.Collections;

public class PlanetGen : MonoBehaviour {

    ArrayList planets;

	// Update is called once per frame
	void ranMaterial(GameObject gameObj) {

        float dirSize = System.IO.Directory.GetFiles("Assets/Resources/").Length;
       
        float ranM = Random.Range(0f,1f);

        int ranID = (int) Mathf.Round(ranM*(dirSize-1));

        string ranMat = System.IO.Directory.GetFiles("Assets/Resources/")[ranID];

        ranMat = ranMat.Substring(17);

        int EndStr = ranMat.Length-4;

        ranMat = ranMat.Substring(0, EndStr);

        print(ranMat);

        Material toLoad = (Material)Resources.Load(ranMat);

        gameObj.GetComponent<Renderer>().material = toLoad;
    }

    void Start()
    {
        for (int i = 0; i < 100; i++){


            GameObject planet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            planet.transform.position = new Vector3(Random.Range(-200f, 200f), Random.Range(-200f, 200f), Random.Range(-200f, 200f));
            float scaleFactor = Random.Range(1f, 10f);
            planet.transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
            ranMaterial(planet);

        }

    }
}
