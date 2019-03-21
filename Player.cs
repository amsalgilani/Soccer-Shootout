using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Ball ball;
    public float kickSpeed = 3.5f;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
       if (GvrViewer.Instance.Triggered || Input.GetKeyDown("space")) {

            RaycastHit [] hits = Physics.RaycastAll(transform.position, transform.forward);

            foreach (RaycastHit hit in hits) {
                if (hit.transform.tag == "Target")
                {
                    ball.ShootTo(hit.point, kickSpeed);
                }
            }
        }
    }
}
