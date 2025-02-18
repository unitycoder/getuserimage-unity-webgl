using UnityEngine;

namespace webgl.tools
{
    public class Spin : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            t = GetComponent<Transform>();
        }

        // Update is called once per frame
        void Update()
        {
            t.localEulerAngles = t.localEulerAngles + new Vector3(0, Time.deltaTime * 120.0f, 0);
        }

        Transform t;
    }
}
