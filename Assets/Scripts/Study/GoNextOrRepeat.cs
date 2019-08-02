using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextOrRepeat : MonoBehaviour {

    public SpawnStudyCars spawnstudycars;


    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "Gonext":
                switch (SpawnStudyCars.steps)
                {
                    case 0:
                        SpawnStudyCars.steps++;
                        spawnstudycars.Ltwo();
                        SpawnStudyCars.buttonsoff = true;
                        break;
                    case 1:
                        spawnstudycars.Lthree();
                        SpawnStudyCars.steps++;
                        SpawnStudyCars.buttonsoff = true;
                        break;
                    case 2:
                        StartCoroutine(LoadScene("game"));
                        break;

                }
                break;
            case "Repeat":
                switch (SpawnStudyCars.steps)
                {
                    case 0:
                        spawnstudycars.Lone();
                        SpawnStudyCars.buttonsoff = true;
                        break;
                    case 1:
                        spawnstudycars.Ltwo();
                        SpawnStudyCars.buttonsoff = true;
                        break;
                    case 2:
                        spawnstudycars.Lthree();
                        SpawnStudyCars.buttonsoff = true;
                        break;
                }
                break;
        }
    }
    IEnumerator LoadScene(string scene)
    {
        float fadeTime = Camera.main.GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(scene);
    }
}
