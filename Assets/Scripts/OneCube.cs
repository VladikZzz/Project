using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneCube : MonoBehaviour
{
    bool metBefore;
    int index;
    public Cubes cubes;
    // Start is called before the first frame update
    void Start()
    {
        metBefore = false;
    }

    // Update is called once per frame
    void Update()
    {  
        if(metBefore == true) 
        {
            if(transform.parent != null) 
            {
                transform.localPosition = new Vector3(0, -index, 0); 
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obsticle")
        {
            cubes.hit();
            this.transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public bool GetMetBefore() 
    {
        return metBefore;
    }
    public void MetBefore() 
    {
        metBefore = true;
    }
    public void setIndex(int index)
    {
        this.index = index;
    }

}
