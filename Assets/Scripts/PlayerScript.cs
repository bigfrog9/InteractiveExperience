using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    //story progress
    public bool hasCandle = false;
    public bool hasWood = false;
    public bool hasPlate = false;
    public bool hasShovel = false;



    //collectables
    public GameObject interactSpeech;

    public bool hasCross = false;
    public bool hasTPumpkin=false;
    public bool hasWPumpkin=false;
    public bool hasSpear=false;
    public bool hasUrn=false;


    public SpinningObjects collects;

    public float moveSpeed;

    private Rigidbody rb;

    private Vector3 playerInput;
    private Vector3 playerVelocity;

    private Camera cam;

    public GameObject CrossMark;
    public GameObject TpumpMark;
    public GameObject WpumpMark;
    public GameObject SpearMark;
    public GameObject UrnMark;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        cam = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        CollectList();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement*moveSpeed);

        Ray ray=cam.ScreenPointToRay(Input.mousePosition);
        Plane ground = new Plane(Vector3.up, Vector3.zero);
        float raylength;

        if (ground.Raycast(ray, out raylength))
        {
            Vector3 pointToLook = ray.GetPoint(raylength);

            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }
    }

    public void CollectList()
    {
        if (hasCross) CrossMark.SetActive(true);
        if (hasTPumpkin) TpumpMark.SetActive(true);
        if (hasWPumpkin) WpumpMark.SetActive(true);
        if (hasSpear) SpearMark.SetActive(true);
        if (hasUrn) UrnMark.SetActive(true);
    }
}
