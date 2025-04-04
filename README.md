# Разработка фрагмента информационной системы производственной фирмы

## Описание системы

Фирма отказалась от приобретения некоторых товаров у своих поставщиков, решив самостоятельно наладить их производство. С этой целью она организовала сеть специализированных цехов, каждый из которых принимает определенное участие в технологическом процессе.

## Учет выпускаемой продукции

Каждому виду выпускаемой продукции присваивается уникальный **шифр товара**, под которым он значится в файле товарных запасов. Этот же номер служит и **шифром продукта**. В записи с этим шифром указываются:
- Дата изготовления последней партии;
- Стоимость;
- Количество операций, потребовавшихся для производства.

## Операции производства

Операцией считается законченная часть процесса производства, выполняемая одним цехом в соответствии с техническими требованиями, указанными в отдельном чертеже. Для каждой операции ведется запись, содержащая:
- Описание операции;
- Среднюю продолжительность;
- Номер чертежа, по которому можно найти соответствующую техническую документацию;
- Номер цеха, выполняющего операцию.

## Учет расходуемых материалов

В запись, связанную с конкретной операцией, заносятся:
- Количество расходуемых материалов;
- Шифры используемых материалов;
- Фактически выданное количество;
- Шифр товара;
- Номер служащего, ответственного за выдачу;
- Дата и время выдачи;
- Номер операции;
- Номер наряда на проведение работ.

Фактическое количество использованных материалов может отличаться от расчетного из-за брака продукции.

## Учет инструментов и приспособлений

Цеха располагают многочисленными инструментами и приспособлениями. Если инструментов не хватает, цех может обратиться в **центральную инструментальную** за недостающими.

Каждый **тип инструмента** снабжен отдельным номером, и ведется запись:
- Описание инструмента;
- Количество инструментов, выделенных цехам;
- Количество инструментов, оставшихся в инструментальной.

Каждый **экземпляр инструмента** конкретного типа (например, гаечные ключи одного размера) различается по индивидуальному номеру. В записи указывается:
- Перечень всех индивидуальных номеров инструмента;
- Даты их поступления на склад.

При выполнении операции указывается:
- Типы и количество инструментов, необходимых для выполнения работы;
- Индивидуальные номера взятых инструментов;
- Номер заказавшего их цеха;
- Номер наряда на проведение работ.

Фактическое количество затребованных инструментов может отличаться от заказанного.

## Наряд на проведение работ

Наряд на проведение работ напоминает **заказ на приобретение товаров**, но направляется не поставщику, а в один из цехов. Оформление наряда происходит после того, как руководство фирмы принимает решение о выпуске партии продукции.

В наряде указываются:
- Шифр продукта;
- Дата оформления наряда;
- Срок выполнения заказа;
- Требуемое количество продукции.

