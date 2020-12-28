using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HealthBar{
    [RequireComponent(typeof(Health))]
    public class IMGUI : MonoBehaviour
    {
        private GameObject Character;
        private float curHP;
        private float fullHP;
        private void Start() {
            Character = this.gameObject;
        }

        private void OnGUI() {
            if(GUI.Button(new Rect(20,20,80,40),"Hurt"))
            {
                Character.GetComponent<Health>().Hurt();
            }
            if(GUI.Button(new Rect(110,20,80,40),"Recover"))
            {
                Character.GetComponent<Health>().Recover();
            }

            //Linear interpolation to make HP change smoothly
            curHP = Character.GetComponent<Health>().curHP;
            fullHP = Character.GetComponent<Health>().fullHP;

            GUI.HorizontalScrollbar(new Rect(20,90,170,20), 0.0f, curHP, 0.0f, fullHP);
        }
    }
}
