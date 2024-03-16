Код для создания таблицы:
CREATE TABLE product (
    id SERIAL PRIMARY KEY,
    article INTEGER,
    name VARCHAR(255),
    typeproduct VARCHAR(255),
    imagepath VARCHAR(255),
    numpeople INTEGER,
    cexnumber INTEGER,
    agentprice MONEY,
    descript VARCHAR(255)
);
добавлять данные надо в бд в ручную(
в imagepath написать путь
