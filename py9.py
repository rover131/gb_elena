import pandas as pd
df = pd.read_csv('sample_data/california_housing_train.csv')



df[(df['population'] > 0) & (df['population'] < 500)]['median_house_value'].mean()  # Средняя стоимость дома, где количество людей от 0 до 500



df[df['population'] == df['population'].min()]['households'].max()  # Узнать какая максимальная households в зоне минимального значения population
