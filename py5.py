def f(n):
    i = 2
    flag = True
    while i < n and flag:
        if n % i == 0:
            flag = False
        i += 1
    if flag:
        return 'yes'
    return 'no'
n = int(input())
print(f(n))





def f(n):
    if n == 0:
        return ''
    k = int(input())
    return f(n - 1) + f' {k}'


n = int(input())
print(f(n))
