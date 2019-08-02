using System.Collections;
using UnityEngine;

public class SpawnCars : MonoBehaviour {

    [SerializeField]
    private bool mainScene;
    public GameObject[] cars;
    public Transform[] spawnplaces;
    private float startSpawn = 0.5f, waitSpawn;
    private int countcars;
    private bool onceStop = false;

    private void Start()
    {
        StartCoroutine(LeftUpCars());
        StartCoroutine(LeftDwnCars());
        StartCoroutine(RightUpCars());
        StartCoroutine(RightDwnCars());

        waitSpawn = mainScene ? 10f : 7f; 

        MoveCar.moveON = true;
        CollisionCars.lose = false;
    }

    void Update()
    {
        if (!mainScene)
        {
            if (countcars > 60)
                waitSpawn = 4f;
            if (countcars > 40)
                waitSpawn = 5f;
            if (countcars > 20)
                waitSpawn = 6f;
        }

        if (CollisionCars.lose && !onceStop)
        {
            StopAllCoroutines();
            onceStop = true;
        }
    }

    IEnumerator LeftUpCars()

    {
        yield return new WaitForSeconds(Random.Range (startSpawn, startSpawn + 4.5f));
        while (true)
        {
            GameObject carInst = Instantiate(cars[Random.Range(0, cars.Length)], spawnplaces[0].position, 
                spawnplaces[0].rotation) as GameObject;
            countcars++;
            int rand = mainScene ? 1 : Random.Range(0, 3);
            switch (rand)
            {
                case 1:
                    carInst.AddComponent<LUmLD>();
                    break;
                case 2:
                    carInst.AddComponent<LUmRU>();
                    break;
            }
            yield return new WaitForSeconds(Random.Range(waitSpawn, waitSpawn + 5f));
        }
             
    }

    IEnumerator LeftDwnCars()

    {
        yield return new WaitForSeconds(Random.Range(startSpawn, startSpawn + 4.5f));
        while (true)
        {
            GameObject carInst = Instantiate(cars[Random.Range(0, cars.Length)], spawnplaces[3].position,
                spawnplaces[3].rotation) as GameObject;
            countcars++;
            int rand = mainScene ? 1 : Random.Range(0, 3);
            switch (rand)
            {
                case 1:
                    carInst.AddComponent<LDmRD>();
                    break;
                case 2:
                    carInst.AddComponent<LDmLU>();
                    break;
            }
            yield return new WaitForSeconds(Random.Range(waitSpawn, waitSpawn + 5f));
        }

    }

    IEnumerator RightUpCars()

    {
        yield return new WaitForSeconds(Random.Range(startSpawn, startSpawn + 4.5f));
        while (true)
        {
            GameObject carInst = Instantiate(cars[Random.Range(0, cars.Length)], spawnplaces[2].position,
                spawnplaces[2].rotation) as GameObject;
            countcars++;
            int rand = mainScene ? 1 : Random.Range(0, 3);
            switch (rand)
            {
                case 1:
                    carInst.AddComponent<RUmLU>();
                    break;
                case 2:
                    carInst.AddComponent<RUmRD>();
                    break;
            }
            yield return new WaitForSeconds(Random.Range(waitSpawn, waitSpawn + 5f));
        }

    }

    IEnumerator RightDwnCars()

    {
        yield return new WaitForSeconds(Random.Range(startSpawn, startSpawn + 4.5f));
        while (true)
        {
            GameObject carInst = Instantiate(cars[Random.Range(0, cars.Length)], spawnplaces[1].position,
                spawnplaces[1].rotation) as GameObject;
            countcars++;
            int rand = mainScene ? 1 : Random.Range(0, 3);
            switch (rand)
            {
                case 1:
                    carInst.AddComponent<RDmRU>();
                    break;
                case 2:
                    carInst.AddComponent<RDmLD>();
                    break;
            }
            yield return new WaitForSeconds(Random.Range(waitSpawn, waitSpawn + 5f));
        }

    }
}
