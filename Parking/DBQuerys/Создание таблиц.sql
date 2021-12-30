
CREATE TABLE Этажи
(
	[Номер этажа] INT NOT NULL PRIMARY KEY,
	[Количество мест] INT NOT NULL,
	[Требуемый план абонимента] VARCHAR(80) NOT NULL
);

CREATE TABLE [Парковочные места]
(
	[Номер места] INT NOT NULL PRIMARY KEY,
	[Номер этажа] INT NOT NULL,
	[Номер клиента] INT,
	[Занято] BIT NOT NULL
);

--TODO: IDENTITY(1, 1)
CREATE TABLE [Регистр использования парковочных мест]
(
	[Номер использования] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[Номер парковочного места] INT NOT NULL,
	[Номер клиента] INT NOt NULL,
	[Начало аренды] DATETIME NOT NULL,
	[Конец аренды] DATETIME,
	[Номер купленного абонимента] INT
);

--TODO: IDENTITY(1, 1)
CREATE TABLE Клиенты
(
	[Номер клиента] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[Тип машины] VARCHAR(80) NOT NULL,
	[Это постоянный клиент] BIT NOT NULL,
	[Номер абонимента] INT,
	[Контактный номер] VARCHAR(20)
);

--TODO: IDENTITY(1, 1)
CREATE TABLE Абонименты
(
	[Номер абонимента] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[Дата активации] DATE NOT NULL,
	[Дата диактивации] DATE,
	[Название плана] VARCHAR(80) NOT NULL
);

CREATE TABLE [Планы абониментов]
(
	[Название плана] VARCHAR(80) NOT NULL PRIMARY KEY,
	[Стоимость (руб.)] INT NOT NULL,
	[Длительность (дней)] INT NOT NULL
);
