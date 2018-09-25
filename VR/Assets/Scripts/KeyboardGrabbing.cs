using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardGrabbing : MonoBehaviour {
    private bool holding = false;
    public Vector3 fruitDisplacement;
    public float thrust;
    private GameObject holdingFruit;

    void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Ray ray;
            RaycastHit hit;
            ray = new Ray(transform.position, transform.forward);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.blue);
                
                if(hit.transform.gameObject.tag == "Fruit" && holding == false)
                {
                    holdingFruit = hit.transform.gameObject;
                    grabFruit(holdingFruit);
                }
            }

            if(holding == true && holdingFruit)
            {
                throwFruit(holdingFruit);
            }
        }
	}

    public void grabFruit(GameObject fruit)
    {
        holding = true;

        fruit.transform.SetParent(transform);
        fruit.transform.position = transform.position;
    }

    public void throwFruit(GameObject fruit)
    {
        holding = false;

        fruit.GetComponent<Rigidbody>().AddForce(transform.forward * thrust);
    }
}
