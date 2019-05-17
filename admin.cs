using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class admin : MonoBehaviour
{

    public string nombre1, apellido1, correo1, cedula1;
    public string nombre2, apellido2, correo2, cedula2;
    public string nombre3, apellido3, correo3, cedula3;

    public List<int> times1, posX1, posY1, posZ1 = new List<int>();
    public List<int> times2, posX2, posY2, posZ2 = new List<int>();
    public List<int> times3, posX3, posY3, posZ3 = new List<int>();

    private void Start()
    {
        begin();
    }

    public void begin()
    {
        nombre1 = "Raul";
        apellido1 = "Gonzales";
        correo1 = "aaa@bbb.com";
        cedula1 = "1245394848373";

        nombre2 = "Maria";
        apellido2 = "Sabaneta";
        correo2 = "abbb@bpppb.com";
        cedula2 = "1245397654323";

        nombre3 = "Pericles";
        apellido3 = "Urdaneta";
        correo3 = "apppp@baaa.com";
        cedula3 = "124111122345323";

        for (int i = 0; i < 7; i++) {
            times1.Add(5 + i);
            posX1.Add(50 + i);
            posY1.Add(100 + i);
            posZ1.Add(35 + i);

            times2.Add(3 + i);
            posX2.Add(8 + i);
            posY2.Add(10 + i);
            posZ2.Add(159 + i);

            times3.Add(10 + i);
            posX3.Add(10 + i);
            posY3.Add(4 + i);
            posZ3.Add(19 + i);
        }
    }
}
