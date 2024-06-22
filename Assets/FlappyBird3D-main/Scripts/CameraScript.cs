using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    // Start is called before the first frame update
    void Start()
    {
        CameraOne();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1")){
            CameraOne ();
        }
        
        if (Input.GetKeyDown("2")){
            CameraTwo ();
        }
        if (Input.GetKeyDown("3")){
            CameraThree ();
        }
    }

    void CameraOne(){
        camera1.SetActive(true);
        camera2.SetActive(false);
        camera3.SetActive(false);
    }

    void CameraTwo(){
        camera1.SetActive(false);
        camera2.SetActive(true);
        camera3.SetActive(false);
    }
    void CameraThree(){
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(true);
    }
}
