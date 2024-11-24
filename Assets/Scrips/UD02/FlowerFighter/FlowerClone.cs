using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FloweClone : MonoBehaviour
{


    //Zona de variables globales

    public GameObject Flower;
    public Transform PostRotFlower;

    public float thrustY;
    public float thrustZ;


    private float _timeFlower = 3.0f;
    private float _timeInvoke = 2.0f;
    private float _timeRepeating = 5.0f;


    // Start is called before the first frame update
    void Start()
    {

        //"InvokeRepeating" llama al método y usa dos tiempos:
        //"_timeInvoke" = cuándo va a llamarlo por primera vez
        //_"timeRepeating = cada cuánto va a llamarlo
        InvokeRepeating("CreateFlower", _timeInvoke, _timeRepeating);

    }



    // Update is called once per frame
    void Update()
    {

        CreateFlower();



    }

    private void CreateFlower()
    {
        if(Input.GetMouseButtonDown(0)) 
        {

            //Crear clones del prefab
            GameObject cloneFlower = Instantiate(Flower, PostRotFlower.position, PostRotFlower.rotation);



            //Obtengo el componente RigidBody de cada flor
            Rigidbody rbFlower = cloneFlower.GetComponent<Rigidbody>();


            //Creo la fuerza
            //"Vector3.up" hace referencia al eje Y y global de la escena
            rbFlower.AddForce(Vector3.up * thrustY);
            //"Vector3.forward" hace referencia al eje z local de "PosRotFlower"
            rbFlower.AddForce(transform.forward * thrustZ);


            //Se destruyen las flores con un tiempo de espera
            Destroy(cloneFlower, _timeFlower);

        }


    }      


}
