from nltk.corpus import wordnet
from itertools import product

groupNames = ['Fruit', 'Berry', 'Vegetable']
groupItemList = ['Apple', 'Carrot', 'Strawberry', 'Tomato', 'Lemon', 'Orange', 'Banana', 'Blueberry', 'Cucumber']
res = []

for groupItem in groupItemList:
    maxPsSims = []
    maxWupSims = []
    maxMixSims = []
    for groupName in groupNames:
        groupNameSynsets = wordnet.synsets(groupName)
        groupItemSynsets = wordnet.synsets(groupItem)
        psSims = []
        wupSims = []
        for nameSyns, itemSyns in product(groupNameSynsets, groupItemSynsets):
            ps = wordnet.path_similarity(nameSyns, itemSyns) or 0
            psSims.append((ps, groupItem, groupName))
            wup = wordnet.wup_similarity(nameSyns, itemSyns) or 0
            wupSims.append((wup, groupItem, groupName))
        maxPsSims.append(max(psSims))
        maxWupSims.append(max(wupSims))
        maxMixSims.append((max(psSims)[0] * max(wupSims)[0], groupItem, groupName))
    print('     path:', sorted(maxPsSims, key=lambda item: item[0], reverse=True))
    print('     wup:', sorted(maxWupSims, key=lambda item: item[0], reverse=True))
    print('     mix:', sorted(maxMixSims, key=lambda item: item[0], reverse=True))
    print('path:', max(maxPsSims))
    print('wup:', max(maxWupSims))
    print('mix:', max(maxMixSims))
    res.append(max(maxMixSims))

print('result:')
for item in res:
    print(item[1], " is a ", item[2])

#---------------------------------------------------------------------------------------------
     path: [(0.3333333333333333, 'Apple', 'Fruit'), (0.3333333333333333, 'Apple', 'Berry'), (0.25, 'Apple', 'Vegetable')]
     wup: [(0.9, 'Apple', 'Fruit'), (0.8571428571428571, 'Apple', 'Berry'), (0.8, 'Apple', 'Vegetable')]
     mix: [(0.3, 'Apple', 'Fruit'), (0.2857142857142857, 'Apple', 'Berry'), (0.2, 'Apple', 'Vegetable')]
path: (0.3333333333333333, 'Apple', 'Fruit')
wup: (0.9, 'Apple', 'Fruit')
mix: (0.3, 'Apple', 'Fruit')
     path: [(0.3333333333333333, 'Carrot', 'Vegetable'), (0.2, 'Carrot', 'Fruit'), (0.16666666666666666, 'Carrot', 'Berry')]
     wup: [(0.9, 'Carrot', 'Vegetable'), (0.7777777777777778, 'Carrot', 'Fruit'), (0.7368421052631579, 'Carrot', 'Berry')]
     mix: [(0.3, 'Carrot', 'Vegetable'), (0.15555555555555556, 'Carrot', 'Fruit'), (0.12280701754385964, 'Carrot', 'Berry')]
path: (0.3333333333333333, 'Carrot', 'Vegetable')
wup: (0.9, 'Carrot', 'Vegetable')
mix: (0.3, 'Carrot', 'Vegetable')
     path: [(0.5, 'Strawberry', 'Berry'), (0.3333333333333333, 'Strawberry', 'Vegetable'), (0.25, 'Strawberry', 'Fruit')]
     wup: [(0.9, 'Strawberry', 'Vegetable'), (0.8571428571428571, 'Strawberry', 'Fruit'), (0.8181818181818182, 'Strawberry', 'Berry')]
     mix: [(0.4090909090909091, 'Strawberry', 'Berry'), (0.3, 'Strawberry', 'Vegetable'), (0.21428571428571427, 'Strawberry', 'Fruit')]
path: (0.5, 'Strawberry', 'Berry')
wup: (0.9, 'Strawberry', 'Vegetable')
mix: (0.4090909090909091, 'Strawberry', 'Berry')
     path: [(0.3333333333333333, 'Tomato', 'Vegetable'), (0.16666666666666666, 'Tomato', 'Berry'), (0.09090909090909091, 'Tomato', 'Fruit')]
     wup: [(0.9, 'Tomato', 'Vegetable'), (0.7058823529411765, 'Tomato', 'Berry'), (0.4444444444444444, 'Tomato', 'Fruit')]
     mix: [(0.3, 'Tomato', 'Vegetable'), (0.11764705882352941, 'Tomato', 'Berry'), (0.0404040404040404, 'Tomato', 'Fruit')]
path: (0.3333333333333333, 'Tomato', 'Vegetable')
wup: (0.9, 'Tomato', 'Vegetable')
mix: (0.3, 'Tomato', 'Vegetable')
     path: [(0.25, 'Lemon', 'Fruit'), (0.25, 'Lemon', 'Berry'), (0.2, 'Lemon', 'Vegetable')]
     wup: [(0.8571428571428571, 'Lemon', 'Fruit'), (0.8181818181818182, 'Lemon', 'Berry'), (0.75, 'Lemon', 'Vegetable')]
     mix: [(0.21428571428571427, 'Lemon', 'Fruit'), (0.20454545454545456, 'Lemon', 'Berry'), (0.15000000000000002, 'Lemon', 'Vegetable')]
path: (0.25, 'Lemon', 'Fruit')
wup: (0.8571428571428571, 'Lemon', 'Fruit')
mix: (0.21428571428571427, 'Lemon', 'Fruit')
     path: [(0.3333333333333333, 'Orange', 'Fruit'), (0.25, 'Orange', 'Berry'), (0.2, 'Orange', 'Vegetable')]
     wup: [(0.8571428571428571, 'Orange', 'Fruit'), (0.8181818181818182, 'Orange', 'Berry'), (0.75, 'Orange', 'Vegetable')]
     mix: [(0.2857142857142857, 'Orange', 'Fruit'), (0.20454545454545456, 'Orange', 'Berry'), (0.15000000000000002, 'Orange', 'Vegetable')]
path: (0.3333333333333333, 'Orange', 'Fruit')
wup: (0.8571428571428571, 'Orange', 'Fruit')
mix: (0.2857142857142857, 'Orange', 'Fruit')
     path: [(0.3333333333333333, 'Banana', 'Fruit'), (0.3333333333333333, 'Banana', 'Berry'), (0.3333333333333333, 'Banana', 'Vegetable')]
     wup: [(0.9, 'Banana', 'Fruit'), (0.9, 'Banana', 'Vegetable'), (0.8571428571428571, 'Banana', 'Berry')]
     mix: [(0.3, 'Banana', 'Fruit'), (0.3, 'Banana', 'Vegetable'), (0.2857142857142857, 'Banana', 'Berry')]
path: (0.3333333333333333, 'Banana', 'Vegetable')
wup: (0.9, 'Banana', 'Vegetable')
mix: (0.3, 'Banana', 'Vegetable')
     path: [(0.5, 'Blueberry', 'Berry'), (0.25, 'Blueberry', 'Fruit'), (0.2, 'Blueberry', 'Vegetable')]
     wup: [(0.8571428571428571, 'Blueberry', 'Fruit'), (0.8181818181818182, 'Blueberry', 'Berry'), (0.7619047619047619, 'Blueberry', 'Vegetable')]
     mix: [(0.4090909090909091, 'Blueberry', 'Berry'), (0.21428571428571427, 'Blueberry', 'Fruit'), (0.1523809523809524, 'Blueberry', 'Vegetable')]
path: (0.5, 'Blueberry', 'Berry')
wup: (0.8571428571428571, 'Blueberry', 'Fruit')
mix: (0.4090909090909091, 'Blueberry', 'Berry')
     path: [(0.5, 'Cucumber', 'Vegetable'), (0.2, 'Cucumber', 'Berry'), (0.1, 'Cucumber', 'Fruit')]
     wup: [(0.9333333333333333, 'Cucumber', 'Vegetable'), (0.75, 'Cucumber', 'Berry'), (0.4, 'Cucumber', 'Fruit')]
     mix: [(0.4666666666666667, 'Cucumber', 'Vegetable'), (0.15000000000000002, 'Cucumber', 'Berry'), (0.04000000000000001, 'Cucumber', 'Fruit')]
path: (0.5, 'Cucumber', 'Vegetable')
wup: (0.9333333333333333, 'Cucumber', 'Vegetable')
mix: (0.4666666666666667, 'Cucumber', 'Vegetable')
reult:
Apple  is a  Fruit
Carrot  is a  Vegetable
Strawberry  is a  Berry
Tomato  is a  Vegetable
Lemon  is a  Fruit
Orange  is a  Fruit
Banana  is a  Vegetable
Blueberry  is a  Berry
Cucumber  is a  Vegetable
