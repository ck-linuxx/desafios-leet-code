using System;
using System.Globalization;
using System.Text.Json;
using System.Text.RegularExpressions;


public class Solution
{
    int[] array = [1, 2, 8, 9, 10];
    int[] array2 = [3, 4, 5, 12, 15];

    public Array Merge(int[] nums1, int m, int[] nums2, int n)
    {
        // fiz isso aqui e estava errado.

        //nums1 = nums1.Take(m).ToArray();

        // estarei iterando 3 arrays:
        // primeiro: ------
        // segundo:  --
        // terceiro: --------
        int maiorTamanho = m > n ? m : n;
        List<int> arrayMergeado = new();
        int posicaoAtualDeN = 0;
        int posicaoAtualDeM = 0;

        for (int i = 0; i <= maiorTamanho; i++)
        {
            // primeiro avalio o array 1: i < m?, então entra
            // depois, avalio o array 2: i < n?, então entra e avalia
            // entre esses dois, preciso saber quem é o maior. 
            // tenho 3 situações:
            // Eles são iguais
            // nums1[i]  > nums2[i] 
            // nums1[i] < nums2[i]; 
            // após acrescentar um com o outro, preciso avaliar a condição anterior e posterior.
            // a solução em cima é ruim porque encavala, vai ficar: 1, 5, 2, 7 caso seja 1,2 e 5, 7;

            //OUTRA ABORDAGEM:

            // Vou enfileirando o array A até que algum seja maior ou igual a B;
            // Quando encontrar algum maior ou igual a B, passo a fazer de B, e daí eu salvo a posição.

            /// COMECEI DO JEITO ABAIXO, mas achei outro melhor, esse aqui falha quando o índice é maior que o nums2
            //if (i < m)
            //{
            //    if(i < n) 
            //    { 
            //        if (nums1[i] < nums2[i])
            //        {

            //        }
            //    }
            //}

            if (posicaoAtualDeM <= i
                && m > 0
                && posicaoAtualDeM < m)
            {
                if (posicaoAtualDeN < n)
                {
                    if (nums1[posicaoAtualDeM] <= nums2[posicaoAtualDeN])
                    {
                        arrayMergeado.Add(nums1[posicaoAtualDeM]);
                        posicaoAtualDeM++;
                    }
                }
                else
                {
                    arrayMergeado.Add(nums1[posicaoAtualDeM]);
                    posicaoAtualDeM++;
                }
            }

            if (posicaoAtualDeN <= i
                && n > 0
                && posicaoAtualDeN < n)
            {
                if (posicaoAtualDeM < m)
                {
                    if (nums2[posicaoAtualDeN] <= nums1[posicaoAtualDeM])
                    {
                        arrayMergeado.Add(nums2[posicaoAtualDeN]);
                        posicaoAtualDeN++;
                    }
                }
                else
                {
                    arrayMergeado.Add(nums2[posicaoAtualDeN]);
                    posicaoAtualDeN++;
                }
            }
        }

        // aparentemente isso aqui tambem nao pode 
        //nums1 = arrayMergeado.ToArray();
        // o array precisa ser atribuído assim
        for (int i = 0; i < arrayMergeado.Count; i++)
        {
            nums1[i] = arrayMergeado[i];
        }

        return nums1;


    }
    
    public static void Main()
    {
        Solution sol = new Solution();
        var resultado = sol.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);

        foreach (var numero in resultado)
            Console.WriteLine(numero);
    }
}
