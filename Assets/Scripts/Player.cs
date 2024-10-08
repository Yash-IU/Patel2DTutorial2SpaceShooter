using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float yPosition;
    [SerializeField] GameObject laser;
    [SerializeField] GameObject Wide_Laser;
    public float fireRate = 8f;
    private float nextFire = 0f;
    // Start is called before the first frame update
    void Start()
    {
        yPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 convertedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(convertedPosition.x, yPosition, 0);

        if (Input.GetButtonDown("FireLaser"))
        {
            Instantiate(laser, transform.position, Quaternion.identity);
        }

        if (Input.GetButtonDown("FireWideLaser") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Wide_Laser, transform.position, Quaternion.identity);
        }
    }
}
