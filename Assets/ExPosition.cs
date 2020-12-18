using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chap03{
    public class ExPosition : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            transform.position = new Vector3(0.0f, 2.0f, 3.0f);
            transform.rotation = Quaternion.Euler(0.0f,90.0f, -45.0f);

            Debug.Log("位置(transform.position)");
            Debug.Log("向き(transform.eulerAngles)");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
