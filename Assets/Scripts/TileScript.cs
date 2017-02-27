using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour {
    private float fallDealy = 1.5f;

	// Use this for initialization
	void Start () {
        //Debug.Log("true");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void onTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("True : HHHHH");
        }
    }
    /*
    IEnumerator FallDown()
    {
        yield return new WaitForSeconds(fallDealy);
        GetComponent<Rigidbody>().isKinematic = false;
    }
    */
}
