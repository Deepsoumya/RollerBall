using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;
 
 [RequireComponent(typeof(Button))]
 public class GameObject : MonoBehaviour {
 
     private Button button;
 
     private void Start() {
         button = GetComponent<Button>();
         button.onClick.AddListener(TaskOnClick);
     }
 
     void TaskOnClick() {
         Application.LoadLevel(Application.loadedLevel);
     }
 }