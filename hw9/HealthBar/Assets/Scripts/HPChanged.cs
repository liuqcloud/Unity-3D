using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HealthBar{
    public class HPChanged : MonoBehaviour
    {
        public GameObject character;
        private void Start() {
            this.gameObject.GetComponent<Slider>().maxValue = character.GetComponent<Health>().fullHP;
        }
        private void Update() {
            this.gameObject.GetComponent<Slider>().value = character.GetComponent<Health>().curHP;
        }
    }
}

