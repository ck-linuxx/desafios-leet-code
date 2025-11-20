# Tempo de pesquisa, desde o assunto ate a linguagem:
# Deabilitado a conclusão de codigo do copilot
# Link utilizado como refenrencia sobre o assunto: https://guilherme-rmendes95.medium.com/algoritmos-merge-sort-ef12dadeba2a

array = [1, 2, 8, 9, 10]
array2 = [3, 4, 5, 12, 15]
arrayOrdenado = []

# Nao funcionou, pois desta forma não estava conseguindo encontrar uma maneira de realizar o merge. Ps. o merge deve seguir um "padrao" de ordem numerica, por isso nao consegui utilizando esta funcao
# array = [9, 2, 8, 15, 1]
# array2 = [ 10, 4, 5, 12, 3]
# def merge_sorted_arrays(arr):
#   i = 0
#   while i < len(arr):
#     arrayOrdenado.append(arr[i])
#     if(arrayOrdenado[i -1] > arr[i]):
#       print(arrayOrdenado[i -1], arr[i], arrayOrdenado)
#       posicaoAtual = arrayOrdenado[i -1]
#       arrayOrdenado[i] = posicaoAtual
#       arrayOrdenado[i -1] = arr[i]
#     i += 1
#   return arrayOrdenado


# Gap do extend veio de um erro que tive e apareceu nos comentarios mencionando o extend
# https://stackoverflow.com/questions/32420006/merge-sort-in-python-int-object-is-not-iterable
# That particular error is coming from the fact that you're saying sorted_array.extend(_arr_left[left]). You're asking for sorted_array to have appended to it every element of the "iterable" _arr_left[left]. But _arr_left[left] isn't really iterable, it's just whatever int is at index left in _arr_left.


def merge_sorted_arrays(arr, arr2):
  i = j = 0

  while i < len(arr) and j < len(arr2):
    if(arr[i] < arr2[j]):
      arrayOrdenado.append(arr[i])
      i += 1
    else:
      arrayOrdenado.append(arr2[j])
      j += 1
  arrayOrdenado.extend(arr[i:])
  arrayOrdenado.extend(arr2[j:]) # no python o exntend espera uma lista iteravel, por isso é utilizado a notacao [i:] -> todos os elementtos desde a posicao i = 3 -> [9, 10]
    
  return arrayOrdenado

print(merge_sorted_arrays(array, array2))
    
  