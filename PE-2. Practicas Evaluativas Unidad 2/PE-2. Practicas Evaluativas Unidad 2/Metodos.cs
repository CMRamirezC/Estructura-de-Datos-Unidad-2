using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_2.Practicas_Evaluativas_Unidad_2
{
    class Metodos
    {
        int[] ArrayNum;
        int Num;
        string digitos;
        public Metodos(int tamaño, int numero)
        {
            ArrayNum = new int[tamaño];
            digitos = numero.ToString();
            for(int i = 0; i < ArrayNum.GetLength(0); i++)
            {
                ArrayNum[i] = int.Parse(digitos[i].ToString());
            }
        }
        public int MaximoValor(int tamaño)
        {
            if(tamaño == ArrayNum.GetLength(0))
            {
                Num = ArrayNum[tamaño - 1];
                return MaximoValor(tamaño - 1);
            }
            else if(tamaño == 0)
            {
                return Num;
            }
            else
            {
                if(ArrayNum[tamaño - 1] > Num)
                {
                    Num = ArrayNum[tamaño - 1];
                    return MaximoValor(tamaño - 1);
                }
                else
                {
                    return MaximoValor(tamaño - 1);
                }
            }
        }
        public int MinimoValor(int tamaño)
        {
            if(tamaño == ArrayNum.GetLength(0))
            {
                Num = ArrayNum[tamaño - 1];
                return MinimoValor(tamaño - 1);
            }
            else if(tamaño == 0)
            {
                return Num;
            }
            else
            {
                if(ArrayNum[tamaño - 1] < Num)
                {
                    Num = ArrayNum[tamaño - 1];
                    return MinimoValor(tamaño - 1);
                }
                else
                {
                    return MinimoValor(tamaño - 1);
                }
            }
        }
        public void SucesionInversa(int tamaño)
        {
            if(tamaño == 1)
            {
                Console.WriteLine(ArrayNum[tamaño - 1]);
            }
            else
            {
                Console.WriteLine(ArrayNum[tamaño - 1]);
                SucesionInversa(tamaño - 1);
            }
        }
    }
}
