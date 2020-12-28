using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HealthBar{
    public class ScreenOverlay : MonoBehaviour
    {
        public GameObject Character;
        public float HPOffset = 2.5f;
        private Slider healthSlider;
        // Start is called before the first frame update
        void Start()
        {
            healthSlider = this.gameObject.GetComponentInChildren<Slider>();
            healthSlider.maxValue = Character.GetComponent<Health>().fullHP;
        }

        // Update is called once per frame
        void Update()
        {
            healthSlider.value = Character.GetComponent<Health>().curHP;

            Vector3 worldPos = new Vector3(Character.transform.position.x, Character.transform.position.y + HPOffset, Character.transform.position.z);
            Vector3 screenPos = Camera.main.WorldToScreenPoint(worldPos);
            healthSlider.transform.position = new Vector3(screenPos.x, screenPos.y, screenPos.z);
        }
    }
}
