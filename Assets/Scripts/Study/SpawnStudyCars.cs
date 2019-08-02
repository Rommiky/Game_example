using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpawnStudyCars : MonoBehaviour {

    [SerializeField]
    static public bool buttonsoff;
    public GameObject[] carsStudy;
    public Transform studyspawnplace1, studyspawnplace2;
    static public int steps;
    public Text lessontext;
    
    private void Start()
    {
        steps = 0;
        Lone();
        buttonsoff = true;        
    }

    
        public void Lone ()
        {
            GameObject carInst = Instantiate(carsStudy[Random.Range(0, carsStudy.Length)], studyspawnplace1.position,
            studyspawnplace1.rotation) as GameObject;
            lessontext.text = "Нажмите на машинку чтобы ускорить ее, нажмите еще раз и она поедет быстрее";
            
        }

        public void Ltwo ()
        {
            GameObject carInst = Instantiate(carsStudy[Random.Range(0, carsStudy.Length)], studyspawnplace1.position,
            studyspawnplace1.rotation) as GameObject;
            carInst.AddComponent<RDmLD>();
            lessontext.text = "Мигающий свет показывает направление поворота";
        }

        public void Lthree ()
        {
            GameObject carInst = Instantiate(carsStudy[Random.Range(0, carsStudy.Length)], studyspawnplace1.position,
            studyspawnplace1.rotation) as GameObject;
            GameObject crashcarInst = Instantiate(carsStudy[Random.Range(0, carsStudy.Length)], studyspawnplace2.position,
            studyspawnplace2.rotation) as GameObject;
            crashcarInst.AddComponent<MoveCar>();
            lessontext.text = "Ускоряйте машинки, чтобы предотвратить аварию";
        }
    
      
}
