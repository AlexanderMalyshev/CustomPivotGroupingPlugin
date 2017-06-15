
from nltk.corpus import wordnet
from itertools import product

groupNames = ['Fruit', 'Berry', 'Vegetable', 'Plant', 'Mushroom']
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
    maxMix = max(maxMixSims)[0]
    print('mix:', max(maxMixSims))
    res.append((maxMix, groupItem, [maxMixSim[2] for maxMixSim in maxMixSims if maxMixSim[0] == maxMix]))

print('result:')
for item in res:
    print(item[1], " is a ", item[2])



#---------------------------------------------------------------------------------------------
     path: [(0.3333333333333333, 'Apple', 'Fruit'), (0.3333333333333333, 'Apple', 'Berry'), (0.25, 'Apple', 'Vegetable'), (0.2, 'Apple', 'Mushroom'), (0.125, 'Apple', 'Plant')]
     wup: [(0.9, 'Apple', 'Fruit'), (0.8571428571428571, 'Apple', 'Berry'), (0.8, 'Apple', 'Vegetable'), (0.75, 'Apple', 'Mushroom'), (0.6666666666666666, 'Apple', 'Plant')]
     mix: [(0.3, 'Apple', 'Fruit'), (0.2857142857142857, 'Apple', 'Berry'), (0.2, 'Apple', 'Vegetable'), (0.15000000000000002, 'Apple', 'Mushroom'), (0.08333333333333333, 'Apple', 'Plant')]
path: (0.3333333333333333, 'Apple', 'Fruit')
wup: (0.9, 'Apple', 'Fruit')
mix: (0.3, 'Apple', 'Fruit')
     path: [(0.3333333333333333, 'Carrot', 'Vegetable'), (0.25, 'Carrot', 'Plant'), (0.25, 'Carrot', 'Mushroom'), (0.2, 'Carrot', 'Fruit'), (0.16666666666666666, 'Carrot', 'Berry')]
     wup: [(0.9, 'Carrot', 'Vegetable'), (0.8235294117647058, 'Carrot', 'Plant'), (0.8235294117647058, 'Carrot', 'Mushroom'), (0.7777777777777778, 'Carrot', 'Fruit'), (0.7368421052631579, 'Carrot', 'Berry')]
     mix: [(0.3, 'Carrot', 'Vegetable'), (0.20588235294117646, 'Carrot', 'Plant'), (0.20588235294117646, 'Carrot', 'Mushroom'), (0.15555555555555556, 'Carrot', 'Fruit'), (0.12280701754385964, 'Carrot', 'Berry')]
path: (0.3333333333333333, 'Carrot', 'Vegetable')
wup: (0.9, 'Carrot', 'Vegetable')
mix: (0.3, 'Carrot', 'Vegetable')
     path: [(0.5, 'Strawberry', 'Berry'), (0.3333333333333333, 'Strawberry', 'Vegetable'), (0.25, 'Strawberry', 'Fruit'), (0.25, 'Strawberry', 'Plant'), (0.16666666666666666, 'Strawberry', 'Mushroom')]
     wup: [(0.9, 'Strawberry', 'Vegetable'), (0.8571428571428571, 'Strawberry', 'Fruit'), (0.8235294117647058, 'Strawberry', 'Plant'), (0.8181818181818182, 'Strawberry', 'Berry'), (0.7058823529411765, 'Strawberry', 'Mushroom')]
     mix: [(0.4090909090909091, 'Strawberry', 'Berry'), (0.3, 'Strawberry', 'Vegetable'), (0.21428571428571427, 'Strawberry', 'Fruit'), (0.20588235294117646, 'Strawberry', 'Plant'), (0.11764705882352941, 'Strawberry', 'Mushroom')]
path: (0.5, 'Strawberry', 'Berry')
wup: (0.9, 'Strawberry', 'Vegetable')
mix: (0.4090909090909091, 'Strawberry', 'Berry')
     path: [(0.3333333333333333, 'Tomato', 'Vegetable'), (0.25, 'Tomato', 'Plant'), (0.25, 'Tomato', 'Mushroom'), (0.16666666666666666, 'Tomato', 'Berry'), (0.09090909090909091, 'Tomato', 'Fruit')]
     wup: [(0.9, 'Tomato', 'Vegetable'), (0.8235294117647058, 'Tomato', 'Plant'), (0.8235294117647058, 'Tomato', 'Mushroom'), (0.7058823529411765, 'Tomato', 'Berry'), (0.4444444444444444, 'Tomato', 'Fruit')]
     mix: [(0.3, 'Tomato', 'Vegetable'), (0.20588235294117646, 'Tomato', 'Plant'), (0.20588235294117646, 'Tomato', 'Mushroom'), (0.11764705882352941, 'Tomato', 'Berry'), (0.0404040404040404, 'Tomato', 'Fruit')]
path: (0.3333333333333333, 'Tomato', 'Vegetable')
wup: (0.9, 'Tomato', 'Vegetable')
mix: (0.3, 'Tomato', 'Vegetable')
     path: [(0.25, 'Lemon', 'Fruit'), (0.25, 'Lemon', 'Berry'), (0.2, 'Lemon', 'Vegetable'), (0.2, 'Lemon', 'Plant'), (0.16666666666666666, 'Lemon', 'Mushroom')]
     wup: [(0.8571428571428571, 'Lemon', 'Fruit'), (0.8181818181818182, 'Lemon', 'Berry'), (0.75, 'Lemon', 'Vegetable'), (0.7142857142857143, 'Lemon', 'Plant'), (0.7058823529411765, 'Lemon', 'Mushroom')]
     mix: [(0.21428571428571427, 'Lemon', 'Fruit'), (0.20454545454545456, 'Lemon', 'Berry'), (0.15000000000000002, 'Lemon', 'Vegetable'), (0.14285714285714288, 'Lemon', 'Plant'), (0.11764705882352941, 'Lemon', 'Mushroom')]
path: (0.25, 'Lemon', 'Fruit')
wup: (0.8571428571428571, 'Lemon', 'Fruit')
mix: (0.21428571428571427, 'Lemon', 'Fruit')
     path: [(0.3333333333333333, 'Orange', 'Fruit'), (0.25, 'Orange', 'Berry'), (0.2, 'Orange', 'Vegetable'), (0.2, 'Orange', 'Plant'), (0.2, 'Orange', 'Mushroom')]
     wup: [(0.8571428571428571, 'Orange', 'Fruit'), (0.8181818181818182, 'Orange', 'Berry'), (0.75, 'Orange', 'Vegetable'), (0.7058823529411765, 'Orange', 'Mushroom'), (0.6666666666666666, 'Orange', 'Plant')]
     mix: [(0.2857142857142857, 'Orange', 'Fruit'), (0.20454545454545456, 'Orange', 'Berry'), (0.15000000000000002, 'Orange', 'Vegetable'), (0.14117647058823532, 'Orange', 'Mushroom'), (0.13333333333333333, 'Orange', 'Plant')]
path: (0.3333333333333333, 'Orange', 'Fruit')
wup: (0.8571428571428571, 'Orange', 'Fruit')
mix: (0.2857142857142857, 'Orange', 'Fruit')
     path: [(0.3333333333333333, 'Banana', 'Fruit'), (0.3333333333333333, 'Banana', 'Berry'), (0.3333333333333333, 'Banana', 'Vegetable'), (0.25, 'Banana', 'Plant'), (0.2, 'Banana', 'Mushroom')]
     wup: [(0.9, 'Banana', 'Fruit'), (0.9, 'Banana', 'Vegetable'), (0.8571428571428571, 'Banana', 'Berry'), (0.8235294117647058, 'Banana', 'Plant'), (0.75, 'Banana', 'Mushroom')]
     mix: [(0.3, 'Banana', 'Fruit'), (0.3, 'Banana', 'Vegetable'), (0.2857142857142857, 'Banana', 'Berry'), (0.20588235294117646, 'Banana', 'Plant'), (0.15000000000000002, 'Banana', 'Mushroom')]
path: (0.3333333333333333, 'Banana', 'Vegetable')
wup: (0.9, 'Banana', 'Vegetable')
mix: (0.3, 'Banana', 'Vegetable')
     path: [(0.5, 'Blueberry', 'Berry'), (0.25, 'Blueberry', 'Fruit'), (0.2, 'Blueberry', 'Vegetable'), (0.2, 'Blueberry', 'Plant'), (0.16666666666666666, 'Blueberry', 'Mushroom')]
     wup: [(0.8571428571428571, 'Blueberry', 'Fruit'), (0.8181818181818182, 'Blueberry', 'Berry'), (0.7777777777777778, 'Blueberry', 'Plant'), (0.7619047619047619, 'Blueberry', 'Vegetable'), (0.7058823529411765, 'Blueberry', 'Mushroom')]
     mix: [(0.4090909090909091, 'Blueberry', 'Berry'), (0.21428571428571427, 'Blueberry', 'Fruit'), (0.15555555555555556, 'Blueberry', 'Plant'), (0.1523809523809524, 'Blueberry', 'Vegetable'), (0.11764705882352941, 'Blueberry', 'Mushroom')]
path: (0.5, 'Blueberry', 'Berry')
wup: (0.8571428571428571, 'Blueberry', 'Fruit')
mix: (0.4090909090909091, 'Blueberry', 'Berry')
     path: [(0.5, 'Cucumber', 'Vegetable'), (0.3333333333333333, 'Cucumber', 'Mushroom'), (0.2, 'Cucumber', 'Berry'), (0.16666666666666666, 'Cucumber', 'Plant'), (0.1, 'Cucumber', 'Fruit')]
     wup: [(0.9333333333333333, 'Cucumber', 'Vegetable'), (0.875, 'Cucumber', 'Mushroom'), (0.75, 'Cucumber', 'Berry'), (0.7368421052631579, 'Cucumber', 'Plant'), (0.4, 'Cucumber', 'Fruit')]
     mix: [(0.4666666666666667, 'Cucumber', 'Vegetable'), (0.29166666666666663, 'Cucumber', 'Mushroom'), (0.15000000000000002, 'Cucumber', 'Berry'), (0.12280701754385964, 'Cucumber', 'Plant'), (0.04000000000000001, 'Cucumber', 'Fruit')]
path: (0.5, 'Cucumber', 'Vegetable')
wup: (0.9333333333333333, 'Cucumber', 'Vegetable')
mix: (0.4666666666666667, 'Cucumber', 'Vegetable')
result:
Apple  is a  ['Fruit']
Carrot  is a  ['Vegetable']
Strawberry  is a  ['Berry']
Tomato  is a  ['Vegetable']
Lemon  is a  ['Fruit']
Orange  is a  ['Fruit']
Banana  is a  ['Fruit', 'Vegetable']
Blueberry  is a  ['Berry']
Cucumber  is a  ['Vegetable']
