# opppo_lab1
Organization of the software design process. Read objects and display content on screen.

<a name='assembly'></a>
# OPPP_lb1

## Contents

- [Bus](#T-OPPP_lb1-Bus 'OPPP_lb1.Bus')
- [Field](#T-OPPP_lb1-Field 'OPPP_lb1.Field')
- [List](#T-OPPP_lb1-List 'OPPP_lb1.List')
  - [Add(value)](#M-OPPP_lb1-List-Add-OPPP_lb1-Field- 'OPPP_lb1.List.Add(OPPP_lb1.Field)')
  - [Show()](#M-OPPP_lb1-List-Show 'OPPP_lb1.List.Show')
  - [addDataFromFile(path)](#M-OPPP_lb1-List-addDataFromFile-System-String- 'OPPP_lb1.List.addDataFromFile(System.String)')
  - [jsonfield(item)](#M-OPPP_lb1-List-jsonfield-Newtonsoft-Json-Linq-JToken- 'OPPP_lb1.List.jsonfield(Newtonsoft.Json.Linq.JToken)')
- [Node](#T-OPPP_lb1-Node 'OPPP_lb1.Node')
- [Truck](#T-OPPP_lb1-Truck 'OPPP_lb1.Truck')

<a name='T-OPPP_lb1-Bus'></a>
## Bus `type`

##### Namespace

OPPP_lb1

##### Summary

Наследуемый класс -> Автобус

<a name='T-OPPP_lb1-Field'></a>
## Field `type`

##### Namespace

OPPP_lb1

##### Summary

Обобщающий класс. Класс содержимого элемента односвязного списка

<a name='T-OPPP_lb1-List'></a>
## List `type`

##### Namespace

OPPP_lb1

##### Summary

Класс реализующий односвязный список

<a name='M-OPPP_lb1-List-Add-OPPP_lb1-Field-'></a>
### Add(value) `method`

##### Summary

Функция добавления в односвязный список

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [OPPP_lb1.Field](#T-OPPP_lb1-Field 'OPPP_lb1.Field') |  |

<a name='M-OPPP_lb1-List-Show'></a>
### Show() `method`

##### Summary

Функция для отображения листа

##### Parameters

This method has no parameters.

<a name='M-OPPP_lb1-List-addDataFromFile-System-String-'></a>
### addDataFromFile(path) `method`

##### Summary

Функция чтения данных из файла и парсинга в массив.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-OPPP_lb1-List-jsonfield-Newtonsoft-Json-Linq-JToken-'></a>
### jsonfield(item) `method`

##### Summary

Функция для работы с json токеном

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [Newtonsoft.Json.Linq.JToken](#T-Newtonsoft-Json-Linq-JToken 'Newtonsoft.Json.Linq.JToken') |  |

<a name='T-OPPP_lb1-Node'></a>
## Node `type`

##### Namespace

OPPP_lb1

##### Summary

Класс элемента односвязного списка

<a name='T-OPPP_lb1-Truck'></a>
## Truck `type`

##### Namespace

OPPP_lb1

##### Summary

Наследуемый класс -> Транспорт
