stroka1 = 'пара-ра-рам рам-пам-папам па-ра-па-дам'
vowels = ['а', 'е', 'ё', 'и', 'й', 'о', 'у', 'ы', 'э', 'ю', 'я']
phrases = stroka1.split()
if len(phrases) < 2:
	print('Количество фраз должно быть больше одной!')
else:
	countVowels = []
	
	for i in phrases:
		countVowels.append(len([x for x in i if x.lower() in vowels]))
	
	if countVowels.count(countVowels[0]) == len(countVowels):
		print('Парам пам-пам')
	else:
		print('Пам парам')
    
    
    





def print_operation_table(operation, num_rows = 9, num_columns = 9):
	if num_rows < 2 or num_columns < 2:
		print('ОШИБКА! Размерности таблицы должны быть больше 2!')
	else:
		print('	'.join([str(i) for i in range(1, num_columns + 1)]))
		for i in range(2, num_rows + 1):
			print(i, end = '	')
			for j in range(2, num_columns + 1):
				print(operation(i, j), end = '	')
			print()

print_operation_table(lambda x, y: x * y)
