using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningObjects : MonoBehaviour
{
    private float spinSpeed;

    public PlayerScript player;

    public GameObject PlayerObject;

    // Start is called before the first frame update
    void Start()
    {
        spinSpeed = 3;
    }

    public void Spin()
    {
        transform.Rotate(0,1,0*Time.deltaTime*spinSpeed);
    }

    // Update is called once per frame  
    void Update()
    {
        Spin();

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == PlayerObject)
        {
            gameObject.SetActive(false);

            if (CompareTag("Cross") == true) player.hasCross = true;
            if (CompareTag("TallPumpkin") == true) player.hasTPumpkin = true;
            if (CompareTag("WidePumpkin") == true) player.hasWPumpkin = true;
            if (CompareTag("Spear") == true) player.hasSpear = true;
            if (CompareTag("Urn") == true) player.hasUrn = true;
        }
    }

}
