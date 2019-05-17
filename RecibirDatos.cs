using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecibirDatos : MonoBehaviour 
{
	//url dode se comunica con php para adicionar el click del menu
	private string getUrlPosInX = "http://tadeolabhack.com:8081/test/Oversas/RecibirPosX.php";
	private string getUrlPosInY = "http://tadeolabhack.com:8081/test/Oversas/RecibirPosY.php";
    private string getUrlPosInZ = "http://tadeolabhack.com:8081/test/Oversas/RecibirPosZ.php";
    private string getUrlTime = "http://tadeolabhack.com:8081/test/Oversas/RecibirTiempo.php";

    List<int> posX;
    List<int> posY;
    List<int> posZ;
    List<int> time;

    string[] pX;
    string[] pY;
    string[] pZ;
    string[] t;
    public Text nombre;
    public Text trat;

    public string id;
    public string intento;

    public admin administrador;

	public void recieveItem()
	{
        id = nombre.text;
        intento = trat.text;
		StartCoroutine (datos());
	}

	public IEnumerator datos()
	{
		
        WWWForm form = new WWWForm();
        form.AddField("Nombre", id);
        form.AddField("Intento", intento);
        WWW totalPosX = new WWW(getUrlPosInX, form);
        yield return totalPosX;
        Debug.Log(totalPosX.text);
        if (!string.IsNullOrEmpty(totalPosX.text))
        {
            //trim le quita los espacios al comienzo y al final
            pX = totalPosX.text.Split('-');
            for (int i = 0; i < pX.Length; i++) {
                administrador.posX1[i] = int.Parse(pX[i]);
            }
            
        }
        else {
            Debug.Log("WAAAAAAAAAAAAAAAAA0");
        }

        WWWForm form1 = new WWWForm();
        form1.AddField("Nombre", id);
        form1.AddField("Intento", intento);
        WWW totalPosY = new WWW(getUrlPosInY, form1);
        yield return totalPosY;
        Debug.Log(totalPosY.text);
        if (!string.IsNullOrEmpty(totalPosY.text))
        {
            //trim le quita los espacios al comienzo y al final
            pY = totalPosY.text.Split('-');
            for (int i = 0; i < pY.Length; i++)
            {
                administrador.posY1[i] = int.Parse(pY[i]);
            }

        }
        else
        {
            Debug.Log("WAAAAAAAAAAAAAAAAA0");
        }

        WWWForm form2 = new WWWForm();
        form2.AddField("Nombre", id);
        form2.AddField("Intento", intento);
        WWW totalPosZ = new WWW(getUrlPosInZ, form);
        yield return totalPosZ;
        Debug.Log(totalPosZ.text);
        if (!string.IsNullOrEmpty(totalPosZ.text))
        {
            //trim le quita los espacios al comienzo y al final
            pZ = totalPosZ.text.Split('-');
            for (int i = 0; i < pZ.Length; i++)
            {
                administrador.posZ1[i] = int.Parse(pZ[i]);
            }

        }
        else
        {
            Debug.Log("WAAAAAAAAAAAAAAAAA0");
        }

        WWWForm form3 = new WWWForm();
        form3.AddField("Nombre", id);
        form3.AddField("Intento", intento);
        WWW totaTiempos = new WWW(getUrlTime, form);
        yield return totaTiempos;
        Debug.Log(totaTiempos.text);
        if (!string.IsNullOrEmpty(totaTiempos.text))
        {
            //trim le quita los espacios al comienzo y al final
            t = totaTiempos.text.Split('-');
            for (int i = 0; i < t.Length; i++)
            {
                administrador.times1[i] = int.Parse(t[i]);
            }

        }
        else
        {
            Debug.Log("WAAAAAAAAAAAAAAAAA0");
        }
    }




}
