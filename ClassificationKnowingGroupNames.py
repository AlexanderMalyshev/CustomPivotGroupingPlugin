from nltk.corpus import wordnet
from itertools import product

groupNames = ['Fruit', 'Berry', 'Vegetable']
groupItemList = ['Apple', 'Carrot', 'Strawberry', 'Tomato', 'Lemon', 'Orange', 'Banana', 'Blueberry', 'Cucumber']
res = []

for groupItem, groupName in product(groupItemList, groupNames):
    groupNameSynsets = wordnet.synsets(groupName)
    groupItemSynsets = wordnet.synsets(groupItem)
    psSims = []
    for nameSyns, itemSyns in product(groupNameSynsets, groupItemSynsets):
        ps = wordnet.path_similarity(nameSyns, itemSyns) or 0
        psSims.append((ps, groupItem, groupName))
    
    print(max(psSims))

#---------------------------------------------------------------------------------------------
(0.3333333333333333, 'Apple', 'Fruit')
(0.3333333333333333, 'Apple', 'Berry')
(0.25, 'Apple', 'Vegetable')

(0.2, 'Carrot', 'Fruit')
(0.16666666666666666, 'Carrot', 'Berry')
(0.3333333333333333, 'Carrot', 'Vegetable')

(0.25, 'Strawberry', 'Fruit')
(0.5, 'Strawberry', 'Berry')
(0.3333333333333333, 'Strawberry', 'Vegetable')

(0.09090909090909091, 'Tomato', 'Fruit')
(0.16666666666666666, 'Tomato', 'Berry')
(0.3333333333333333, 'Tomato', 'Vegetable')

(0.25, 'Lemon', 'Fruit')
(0.25, 'Lemon', 'Berry')
(0.2, 'Lemon', 'Vegetable')

(0.3333333333333333, 'Orange', 'Fruit')
(0.25, 'Orange', 'Berry')
(0.2, 'Orange', 'Vegetable')

(0.3333333333333333, 'Banana', 'Fruit')
(0.3333333333333333, 'Banana', 'Berry')
(0.3333333333333333, 'Banana', 'Vegetable')

(0.25, 'Blueberry', 'Fruit')
(0.5, 'Blueberry', 'Berry')
(0.2, 'Blueberry', 'Vegetable')

(0.1, 'Cucumber', 'Fruit')
(0.2, 'Cucumber', 'Berry')
(0.5, 'Cucumber', 'Vegetable')
