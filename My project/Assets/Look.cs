using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public float sensitivity;
    public float smoothing;
    public Transform charCamera;
     Vector2 appliedMouseDelta, currentMouseLook; 
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; 
    }

    // Update is called once per frame
    void Update() //Update is running every frame                     
    {
        //Gets the X and Y position of our mouse. Storing it into a Vector2 called smoothMouseDelta then applying it to our currentMouseLook x,y
        Vector2 smoothMouseDelta = Vector2.Scale(new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")), Vector2.one * sensitivity * smoothing);
        appliedMouseDelta = Vector2.Lerp(appliedMouseDelta, smoothMouseDelta, 1 / smoothing);
        currentMouseLook += appliedMouseDelta;
        currentMouseLook.y = Mathf.Clamp(currentMouseLook.y, -90, 90);
        //Setting the Cameras Rotation to the currentMouseLook X and Y coordinates 
        charCamera.localRotation = Quaternion.AngleAxis(-currentMouseLook.y, Vector3.right);
        transform.localRotation = Quaternion.AngleAxis(currentMouseLook.x, Vector3.up);

    }
}
