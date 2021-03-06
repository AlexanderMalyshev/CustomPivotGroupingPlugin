import web
from nltk.corpus import wordnet
from ClassificationKnowingGroupNames import *
import json

urls = (
    '/group', 'GroupServer'
)
app = web.application(urls, globals())

class GroupServer:        
    def POST(self):
        data = json.loads(web.data())
        groupNames = data['groups'] # ['Fruit', 'Berry', 'Vegetable', 'Plant', 'Mushroom']
        groupItemList = data['items'] #['Apple', 'Carrot', 'Strawberry', 'Tomato', 'Boletus_edulis', 'Lemon', 'Orange', 'Banana', 'Blueberry', 'Cucumber', 'Calvatia_gigantea']

        print('result:')
        res = spreadItemsIntoGroups(groupNames, groupItemList)
        for item in res:
            print(item[1], " is a ", item[2])

        return json.dumps(res)

if __name__ == "__main__":
    app.run()
    
    
//------------------------------
Request

{
  "groups": ["Fruit", "Berry", "Vegetable", "Plant", "Mushroom"],
  "items": ["Apple", "Carrot", "Strawberry", "Tomato", "Boletus_edulis", "Lemon", "Orange", "Banana", "Blueberry", "Cucumber", "Calvatia_gigantea"]
}
