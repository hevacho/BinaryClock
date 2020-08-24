using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinaryClockController : MonoBehaviour
{

    public BinaryItem[] H;
    public BinaryItem[] HH;
    public BinaryItem[] M;
    public BinaryItem[] MM;
    public BinaryItem[] S;
    public BinaryItem[] SS;

    private void Start()
    {
        InvokeRepeating("SetVisualTime", 0f, 1f);
    }
    private void SetVisualTime()
    {
        //Seconds
        if (System.DateTime.Now.Second.ToString().Length < 2)
        {
            SetS(ConvertToBinary("0"));
            SetSS(ConvertToBinary(System.DateTime.Now.Second.ToString()));
        }
        else
        {
            string WholeText = System.DateTime.Now.Second.ToString();
            string A = WholeText[0].ToString();
            string B = WholeText[1].ToString();
            SetS(ConvertToBinary(A));
            SetSS(ConvertToBinary(B));
        }

        //Minutes
        if (System.DateTime.Now.Minute.ToString().Length < 2)
        {
            SetM(ConvertToBinary("0"));
            SetMM(ConvertToBinary(System.DateTime.Now.Minute.ToString()));
        }
        else
        {
            string WholeText = System.DateTime.Now.Minute.ToString();
            string A = WholeText[0].ToString();
            string B = WholeText[1].ToString();
            SetM(ConvertToBinary(A));
            SetMM(ConvertToBinary(B));
        }
        //Hours
        if (System.DateTime.Now.Hour.ToString().Length < 2)
        {
            setH(ConvertToBinary("0"));
            setHH(ConvertToBinary(System.DateTime.Now.Hour.ToString()));
        }
        else
        {
            string WholeText = System.DateTime.Now.Hour.ToString();
            string A = WholeText[0].ToString();
            string B = WholeText[1].ToString();
            setH(ConvertToBinary(A));
            setHH(ConvertToBinary(B));
        }
    }

    private void SetS(string _in)
    {
        string[] mToSplit = _in.Split('/');
        for (int i = 1; i <= S.Length; i++)
        {
            if (mToSplit[i].Equals("1"))
                S[i - 1].OnEnterTypeOf();
            else
                S[i - 1].OnExitTypeOf();
        }
    }
    private void SetSS(string _in)
    {
        string[] mToSplit = _in.Split('/');
        for (int i = 1; i <= SS.Length; i++)
        {
            if (mToSplit[i].Equals("1"))
                SS[i - 1].OnEnterTypeOf();
            else
                SS[i - 1].OnExitTypeOf();
        }
    }
    private  void SetM(string _in)
    {
        string[] mToSplit = _in.Split('/');
        for (int i = 1; i <= M.Length; i++)
        {
            if (mToSplit[i].Equals("1"))
                M[i - 1].OnEnterTypeOf();
            else
                M[i - 1].OnExitTypeOf();
        }
    }
    private void SetMM(string _in)
    {
        string[] mToSplit = _in.Split('/');
        for (int i = 1; i <= MM.Length; i++)
        {
            if (mToSplit[i].Equals("1"))
                MM[i - 1].OnEnterTypeOf();
            else
                MM[i - 1].OnExitTypeOf();
        }
    }
    private void setH(string _in)
    {
        string[] mToSplit = _in.Split('/');
        for (int i = 1; i <= H.Length; i++)
        {
            if (mToSplit[i].Equals("1"))
                H[i - 1].OnEnterTypeOf();
            else
                H[i - 1].OnExitTypeOf();
        }
    }
    private  void setHH(string _in)
    {
        string[] mToSplit = _in.Split('/');
        for (int i = 1; i <= HH.Length; i++)
        {
            if (mToSplit[i].Equals("1"))
                HH[i - 1].OnEnterTypeOf();
            else
                HH[i - 1].OnExitTypeOf();
        }
    }
    private string ConvertToBinary(string _innerText)
    {
        string mToReturn = "";
        int mToEvaluate = int.Parse(_innerText.ToString());
        if (mToEvaluate != 0)
        {
            while (true)
            {
                if (mToEvaluate % 2 != 0)
                {
                    mToReturn += "/1";
                }
                else
                {
                    mToReturn += "/0";
                }
                mToEvaluate /= 2;
                if (mToEvaluate <= 0)
                    break;
            }
        }
        else
        {
            mToReturn = "/0/0/0/0";
        }
        string mtoSend = FillVoid(mToReturn);
        return mtoSend;
    }

    private string FillVoid(string _InnerText)
    {
        string[] mToSplit = _InnerText.Split('/');
        
        string mToReturn = "";
        if (mToSplit.Length == 2)
        {
            mToReturn = string.Concat("/", mToSplit[1], "/0/0/0");
        }
        if (mToSplit.Length == 3)
        {
            mToReturn = string.Concat("/", mToSplit[1],"/", mToSplit[2], "/0/0");
        }
        if (mToSplit.Length == 4)
        {
            mToReturn = string.Concat("/", mToSplit[1], "/", mToSplit[2], "/", mToSplit[3], "/0");
        }
        if (mToSplit.Length == 5)
        {
            mToReturn = _InnerText;
        }
        return mToReturn;
    }
}
