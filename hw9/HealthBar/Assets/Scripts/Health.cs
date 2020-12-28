using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HealthBar
{
    public class Health : MonoBehaviour
    {
        public float curHP;
        public float nextHP;
        public float fullHP = 100.0f;

        private void Start() {
            curHP = fullHP;
            nextHP = fullHP;
        }

        private void Update() {
            //Linear interpolation to make HP change smoothly
            curHP = Mathf.Lerp(curHP, nextHP, 0.05f);
        }

        public void Hurt(){
            nextHP = (curHP - 10.0f)>=0f?curHP-10.0f:0.0f;
        }

        public void Recover(){
            nextHP = fullHP;
        }
    }   
}
