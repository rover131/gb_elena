import pandas as pd
import random
lst = ['robot'] * 10
lst += ['human'] * 10
random.shuffle(lst)
data = pd.DataFrame({'whoAmI':lst})
data.head(10)

variants = ['robot', 'human']
for i in variants:
  data.loc[data['whoAmI'] == i, i] = 1
data[variants].fillna(0).astype(int).head(10)
