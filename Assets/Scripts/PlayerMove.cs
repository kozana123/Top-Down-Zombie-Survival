using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    public float sprintOn;
    public bool isGrounded;
    public Rigidbody rigit;

    private Camera mainCamera;


    // Start is called before the first frame update
    void Start()
    {
        rigit = GetComponent<Rigidbody>();
        mainCamera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.position += Vector3.right * moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");

        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        if (groundPlane.Raycast(cameraRay, out rayLength))
        {
            Vector3 pointToLook = cameraRay.GetPoint(rayLength);
            Debug.DrawLine(cameraRay.origin, pointToLook, Color.red);

            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }
        Sprint();
    }
    public void Sprint()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += Vector3.forward * sprintOn * Time.deltaTime * Input.GetAxis("Vertical");
            transform.position += Vector3.right * sprintOn * Time.deltaTime * Input.GetAxis("Horizontal");
        }
    }

    private void OnCollisionEnter(Collision coli)
    {
        isGrounded = true;
    }
    public void Jump()
    {
        
    }

}
