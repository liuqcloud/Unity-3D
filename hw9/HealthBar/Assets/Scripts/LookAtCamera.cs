using UnityEngine;

namespace LookAtCamera{
    public class LookAtCamera : MonoBehaviour 
    {
        void Update () 
        {
            this.transform.LookAt (Camera.main.transform.position);
        }
    }
}