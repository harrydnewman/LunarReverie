using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmongUs : MonoBehaviour
{
     
    [SerializeField] private GameObject amongUs;
    [SerializeField] private GameObject drawer;

    [SerializeField] private GameObject backofDrawer;
    [SerializeField] private GameObject frontofDrawer;

    private float drawerMaxOut = -3.7228f;
    private float drawerMaxIn = -3.1692f;

    private float drawerz;
    private float drawery = 0.2f;
    private float drawerx = -3.26f;

    private float correctRotation = 0.0f;
    private float yCorrectRoation = 90.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //no fucking idea how this code is working, the z and x are swapped but if it works it works!
        drawerz = drawer.gameObject.transform.position.x;
        if (drawerz < drawerMaxOut)
        {
                Vector3 newPosition = drawer.transform.position;
                newPosition.x = drawerMaxOut;
                drawer.transform.position = newPosition;
        }
        if (drawerz > drawerMaxIn)
        {
            Vector3 ogPosition = drawer.transform.position;
            ogPosition.x = drawerMaxIn;
            drawer.transform.position = ogPosition;
        }
        if (drawer.gameObject.transform.position.y != drawery)
        {
            Vector3 yPosition = drawer.transform.position;
            yPosition.y = drawery;
            drawer.transform.position = yPosition;
        }

        if (drawer.gameObject.transform.position.z != drawerx)
        {
            Vector3 zPosition = drawer.transform.position;
            zPosition.z = drawerx;
            drawer.transform.position = zPosition;
        }

     

    }
}
