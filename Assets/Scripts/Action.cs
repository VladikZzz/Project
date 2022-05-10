using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{   
    [SerializeField]
    private float forward;
    [SerializeField]
    private float left_right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal")*left_right*Time.deltaTime;
        this.transform.Translate(horizontal,0,forward*Time.deltaTime);
    }
}
