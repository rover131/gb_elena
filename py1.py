n = int(input())
n1 = n // 100 
n2 = (n % 100) 
n3 = n % 10 
print(n1 + n2 + n3)





n = int(input())
n1 = n // 6
n2 = n // 6
n3 = (n // 6) * 4
print(n1, n3, n2)









n = int(input())
n1 = n // 100000
n2 = (n % 100000) // 10000
n3 = (n % 10000) // 1000
n4 = (n % 1000) // 100
n5 = (n % 100) // 10
n6 = n % 10
if n1 + n2 + n3 == n4 + n5 + n6:
    print('yes')
else:
    print('no')
    
    
    
    
    
    
a = int(input())
b = int(input())
c = int(input())
if c <= b * a and (c % a == 0 or c % b == 0):
    print('yes')
else:
    print('no')
