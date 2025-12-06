#This is an example!
# 1   2  3     4

#sihT si na !elpmaxe
# 1   2  3     4

#Tempo 1H:34min
def reverse_words(text):
  reversed_string = ""
  final_string = ""
  for a in text:
    reversed_string = a + reversed_string

  array_text = reversed_string.split()
  i = 0
  while len(array_text) > i:
    final_string = array_text[i] + " " + final_string
    i += 1
  
  return final_string 



print(reverse_words("The quick brown fox jumps over the lazy dog. "))