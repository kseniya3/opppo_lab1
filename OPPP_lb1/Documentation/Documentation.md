<a name='assembly'></a>
# OPPP_lb1

## Contents

- [Bus](#T-OPPP_lb1-Bus 'OPPP_lb1.Bus')
  - [Show(id)](#M-OPPP_lb1-Bus-Show-System-Int32- 'OPPP_lb1.Bus.Show(System.Int32)')
- [Field](#T-OPPP_lb1-Field 'OPPP_lb1.Field')
  - [GetId()](#M-OPPP_lb1-Field-GetId 'OPPP_lb1.Field.GetId')
  - [Show()](#M-OPPP_lb1-Field-Show-System-Int32- 'OPPP_lb1.Field.Show(System.Int32)')
- [Jsonfield](#T-OPPP_lb1-Jsonfield 'OPPP_lb1.Jsonfield')
  - [jsonfield(item)](#M-OPPP_lb1-Jsonfield-jsonfield-Newtonsoft-Json-Linq-JToken- 'OPPP_lb1.Jsonfield.jsonfield(Newtonsoft.Json.Linq.JToken)')
- [List](#T-OPPP_lb1-List 'OPPP_lb1.List')
  - [Add(value)](#M-OPPP_lb1-List-Add-OPPP_lb1-Field- 'OPPP_lb1.List.Add(OPPP_lb1.Field)')
  - [Remove()](#M-OPPP_lb1-List-Remove-System-String- 'OPPP_lb1.List.Remove(System.String)')
  - [Show()](#M-OPPP_lb1-List-Show 'OPPP_lb1.List.Show')
  - [Sort()](#M-OPPP_lb1-List-Sort 'OPPP_lb1.List.Sort')
  - [addDataFromFile(path)](#M-OPPP_lb1-List-addDataFromFile-System-String- 'OPPP_lb1.List.addDataFromFile(System.String)')
  - [getPosition()](#M-OPPP_lb1-List-getPosition-System-Int32- 'OPPP_lb1.List.getPosition(System.Int32)')
- [Node](#T-OPPP_lb1-Node 'OPPP_lb1.Node')
- [Program](#T-OPPP_lb1-Program 'OPPP_lb1.Program')
- [Truck](#T-OPPP_lb1-Truck 'OPPP_lb1.Truck')
  - [Show(id)](#M-OPPP_lb1-Truck-Show-System-Int32- 'OPPP_lb1.Truck.Show(System.Int32)')

<a name='T-OPPP_lb1-Bus'></a>
## Bus `type`

##### Namespace

OPPP_lb1

##### Summary

Наследуемый класс -> Автобус

<a name='M-OPPP_lb1-Bus-Show-System-Int32-'></a>
### Show(id) `method`

##### Summary

Функция для отображения.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-OPPP_lb1-Field'></a>
## Field `type`

##### Namespace

OPPP_lb1

##### Summary

Обобщающий класс. Класс содержимого элемента односвязного списка

<a name='M-OPPP_lb1-Field-GetId'></a>
### GetId() `method`

##### Summary

Функция для получения id.

##### Parameters

This method has no parameters.

<a name='M-OPPP_lb1-Field-Show-System-Int32-'></a>
### Show() `method`

##### Summary

Функция для отображения.

##### Parameters

This method has no parameters.

<a name='T-OPPP_lb1-Jsonfield'></a>
## Jsonfield `type`

##### Namespace

OPPP_lb1

<a name='M-OPPP_lb1-Jsonfield-jsonfield-Newtonsoft-Json-Linq-JToken-'></a>
### jsonfield(item) `method`

##### Summary

Функция для работы с json токеном

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [Newtonsoft.Json.Linq.JToken](#T-Newtonsoft-Json-Linq-JToken 'Newtonsoft.Json.Linq.JToken') |  |

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

<a name='M-OPPP_lb1-List-Remove-System-String-'></a>
### Remove() `method`

##### Summary

Функция удаление объектов по типу.

##### Parameters

This method has no parameters.

<a name='M-OPPP_lb1-List-Show'></a>
### Show() `method`

##### Summary

Функция для отображения листа

##### Parameters

This method has no parameters.

<a name='M-OPPP_lb1-List-Sort'></a>
### Sort() `method`

##### Summary

Функция для сортировки.

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

<a name='M-OPPP_lb1-List-getPosition-System-Int32-'></a>
### getPosition() `method`

##### Summary

Функция для получения позиции элемента в списке.

##### Parameters

This method has no parameters.

<a name='T-OPPP_lb1-Node'></a>
## Node `type`

##### Namespace

OPPP_lb1

##### Summary

Класс элемента односвязного списка

<a name='T-OPPP_lb1-Program'></a>
## Program `type`

##### Namespace

OPPP_lb1

##### Summary

Main

<a name='T-OPPP_lb1-Truck'></a>
## Truck `type`

##### Namespace

OPPP_lb1

##### Summary

Наследуемый класс -> Транспорт

<a name='M-OPPP_lb1-Truck-Show-System-Int32-'></a>
### Show(id) `method`

##### Summary

Функция для отображения.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
