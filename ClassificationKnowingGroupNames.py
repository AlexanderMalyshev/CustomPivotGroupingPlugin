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
