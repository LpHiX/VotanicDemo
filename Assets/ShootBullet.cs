using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Votanic.vXR.vGear;

public class ShootBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vGear.Cmd.Received("Shoot"))
        {
            Debug.Log("Hi");
            GameObject bullet = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            bullet.transform.position = vGear.head.transform.position + vGear.head.transform.forward * 0.1f;
            bullet.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            bullet.transform.up = (bullet.transform.position - vGear.head.transform.position).normalized;
            bullet.AddComponent<Rigidbody>().AddForce(vGear.head.transform.forward * 1000);
            Destroy(bullet, 5f);
        }
    }
}
