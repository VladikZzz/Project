using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    GameObject mainCube;
    int height;
    // Start is called before the first frame update
    void Start()
    {
        mainCube = GameObject.Find("MainCube");
    }

    // Update is called once per frame
    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);
    }
    public void hit() 
    {
        height--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Pickup" && other.gameObject.GetComponent<OneCube>().GetMetBefore()==false)
        {
            height += 1;
            other.gameObject.GetComponent<OneCube>().MetBefore();
            other.gameObject.GetComponent<OneCube>().setIndex(height);
            other.gameObject.transform.parent = mainCube.transform;

        }
    }
}
