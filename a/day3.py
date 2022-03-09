id = [6,7,8,9]
emp_name=["abc","pqr","xyz"]
student_detail=[1,"abc",25.3,id]

#insert element in list
#id.append(100)
#id.insert(4,100)
#id.insert(5,700)
#id.insert(2,200)


#print(id)
#print(emp_name)
#print(student_detail)
#id


#index slicing 

#id[1:4]
#id[0:0]
#id[::3]

#delete = index
#remove = value
#pop = return the element(same as delete)


#del id[2]
#id

#id.pop(3)
#id

#  SORT,REVERSE,LENGTH

#lst = [3,5,100,2,7,9]
#lst1 = ['ab','ww','ee','rr']
#lst.sort()
#lst1.sort()
#lst
#lst1

#lst1 = [3,5,100,2,7,9]
#lst2 = [2,5,100,2,7,9]
#lst3 = [1,5,100,2,7,9]

#lst=[lst1,lst2,lst3]
#lst.sort()

#for i in lst:

# i.sort()
  
#lst

#student_detail.reverse()
#student_detail

#PRINTING A LENGTH
#len(id)

#COUNT ELEMENT
#count=[2,2,4,4,6,6]
#count.count(4)

#RECOGNIZING THE INDEX
#id.index(6)

#MAXIMUM NUMBER
#max(id)
#min(id)

#FIND THE SUM OF LIST
#sum(id)

#APPEND LIST1 > LIST2
c1=[1,2,3,4]
c2=[5,6,7,8]
#c1.extend(c2)
#c1+c2
#c1

#IN OR NOT IN
#3 in c1
#3 not in c1
def Flames(name1,name2):
    namestr = name1 + name2

    for c in namestr:
        if namestr.count(c) != 1:
          
            namestr = namestr.replace(c,"")

    print("FLAMES....")
    print("F = Friend \nL = Love \nA = Affection \nM = Marriage \nE = Enemy \nS = Siblings \n\n")
    

    number = len(namestr) % 6
    rel = ""

    if number == 1:
        rel += "Friends"
    elif number == 2:
        rel += "Love"
    elif number == 3:
        rel += "Affection"
    elif number == 4:
        rel += "Marriage"
    elif number == 5:
        rel += "Enemy"
    elif number == 0:
        rel += "Siblings"
    else:
        pass

    return rel

n1 = input("Enter your name : ").upper()
n2 = input("Enter name of your crush : ").upper()
print(f"Your Relationship is : {Flames(n1,n2)}")