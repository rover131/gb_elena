def name_data():
    name = input('Введите Ваше имя: ')
    print('Очень красивое имя! (а меня зовут гб_бот, меня создала компания GeekBrains!')
    return name


def surname_data():
    surname = input('Введите Вашу фамилию: ')
    return surname


def phone_data():
    # import re
    phone = input('Введите Ваш телефон: ')
    return phone


def address_data():
    address = input('Введите Ваш адрес: ')
    return address
  
def input_data():
    name = name_data()
    surname = surname_data()
    phone = phone_data()
    address = address_data()
    var = int(input(f"В каком формате Вы хотите записать данные?\n\n"
                    f"1 Вариант:\n\n"
                    f"{surname}\n"
                    f"{name}\n"
                    f"{phone}\n"
                    f"{address}\n\n"
                    f"2 Вариант:\n\n"
                    f"{surname};{name};{phone};{address}\n\n"
                    f"Выберите номер варианта: "))

    while var != 1 and var != 2:
        print('Ты дурак?! Даю тебе последний шанс')
        var = int(input("Введите номер варианта: "))

    if var == 1:
        with open('data_first_variant.csv', 'a', encoding='utf-8') as file:
            file.write(f'{name}\n{surname}\n{phone}\n{address}\n\n')
    else:
        with open('data_second_variant.csv', 'a', encoding='utf-8') as file:
            file.write(f'{name};{surname};{phone};{address}\n\n')


def print_data():
    print('Вывожу данные для Вас данные из 1-ого файла\n')
    with open('data_first_variant.csv', 'r', encoding='utf-8') as file:
        data_first = file.readlines()
        data_first_version_second = []
        data_middle = ''
        j = 0
        for i in range(len(data_first)):
            if data_first[i] == '\n' or i == len(data_first) - 1:
                data_first_version_second.append(''.join(data_first[j:i + 1]))
                j = i
        data_first = data_first_version_second
        print(''.join(data_first))
    print('Вывожу данные для Вас данные из 2-ого файла\n')
    with open('data_second_variant.csv', 'r', encoding='utf-8') as file:
        data_second = list(file.readlines())
        print(*data_second)
    return data_first, data_second




def interface():
    command = -1
    while command != 5:
        print('Доброго времени суток!\n'
              '1. Записать данные(в 2-ух форматах)\n'
              '2. Вывести данные\n'
              '3. Выход')
        command = int(input("Введите номер операции: "))

        if command == 1:
            input_data()
        elif command == 2:
            print_data()
        elif command == 3:
            print("Спасибо, что воспользовались нашими услугами. Всего доброго!
                  
if __name__ == "__main__":
    interface()
