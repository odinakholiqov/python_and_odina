# list_1 = ['4', '12', '45', '7', '0', '100', '200', '-12', '-500']

# for idx, i in enumerate(list_1):

#     list_1[idx] = int(i)


# print(sorted(list_1))
# List_2=0
# List_1=0
# if List_1 match List_2:
#      print("YES")


list_1 = [1, 2, 4, 6, 8, 2, 1, 4, 10, 12, 14, 12, 16, 17]
unique_elements = set(list_1)
if len(unique_elements) == len(list_1):
    print("> Правда")
else:
    print("> Неверно")
    list_2 =   [2, 4, 6, 8, 10, 12, 14]
    unique_elements = set(list_2)
if len(unique_elements) == len(list_2):
    print("> Правда")
else:
    print("> Неверно")