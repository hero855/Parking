ALTER TABLE dbo.[Этажи]
ADD CONSTRAINT FK_ПланЭтаж
FOREIGN KEY ([Требуемый план абонимента]) REFERENCES dbo.[Планы абониментов]([Название плана]);

ALTER TABLE dbo.[Парковочные места]
ADD CONSTRAINT FK_ЭтажМесто
FOREIGN KEY ([Номер этажа]) REFERENCES dbo.Этажи([Номер этажа]);

ALTER TABLE dbo.[Парковочные места]
ADD CONSTRAINT FK_КлиентМесто
FOREIGN KEY ([Номер клиента]) REFERENCES dbo.Клиенты([Номер клиента]);

ALTER TABLE dbo.[Клиенты]
ADD CONSTRAINT FK_АбониментКлиент
FOREIGN KEY ([Номер абонимента]) REFERENCES dbo.Абонименты([Номер абонимента]);

ALTER TABLE dbo.[Абонименты]
ADD CONSTRAINT FK_ПланАбонимент
FOREIGN KEY ([Название плана]) REFERENCES dbo.[Планы абониментов]([Название плана]);

ALTER TABLE dbo.[Регистр использования парковочных мест]
ADD CONSTRAINT FK_МестоРегистр
FOREIGN KEY ([Номер парковочного места]) REFERENCES dbo.[Парковочные места]([Номер места]);

ALTER TABLE dbo.[Регистр использования парковочных мест]
ADD CONSTRAINT FK_КлиентРегистр
FOREIGN KEY ([Номер клиента]) REFERENCES dbo.Клиенты([Номер клиента]);


