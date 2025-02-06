--DROP DATABASE dbAlmoxarifado
GO
CREATE DATABASE dbAlmoxarifado

USE bdAlmoxarifado

---PRODUTO
CREATE TABLE PRODUTO (
IdProd INT IDENTITY (1,1) PRIMARY KEY ,
DescricaoProd VARCHAR (100) NOT NULL ,
UnidadeDeMedida VARCHAR (100) NOT NULL,
EstoqueAtual FLOAT (2) DEFAULT '0.00',
EPermanente BIT DEFAULT 0,
IdCategoria INT NULL
)

ALTER TABLE PRODUTO
ADD FOREIGN KEY (IdCategoria) REFERENCES CATEGORIA(Codigo);

---FORNECEDOR 

CREATE TABLE FORNECEDOR (
IdForn INT IDENTITY (1,1) PRIMARY KEY,
NomeForn VARCHAR (100) ,
EndereçoForn VARCHAR (100)
)
 
---SECRETARIA

CREATE TABLE SECRETARIA (
IdSec INT IDENTITY (1,1) PRIMARY KEY,
NomeSec VARCHAR (100)
)

---ENTRADA 

CREATE TABLE ENTRADA (
IdEnt INT IDENTITY (1,1) PRIMARY KEY,
IdForn INT NULL,
DataEntrada DATETIME NOT NULL
)

ALTER TABLE ENTRADA
ADD FOREIGN KEY (IdForn) REFERENCES FORNECEDOR(IdForn);


---SAIDA 

CREATE TABLE SAIDA (
IdSaida INT IDENTITY (1,1) PRIMARY KEY,
IdSec INT NULL,
DataSaida DATETIME NOT NULL
)
ALTER TABLE SAIDA
ADD FOREIGN KEY (IdSec) REFERENCES SECRETARIA (IdSec);

---ITENENTRADA

CREATE TABLE ITENENTRADA (
IdItenEntrada INT IDENTITY (1,1) PRIMARY KEY,
IdEnt INT NULL
)
ALTER TABLE ITENENTRADA
ADD FOREIGN KEY (IdEnt) REFERENCES  ENTRADA (IdEnt);

ALTER TABLE ITENENTRADA
ADD FOREIGN KEY (IdProd) REFERENCES  PRODUTO (IdProd);
ADD IdProd INT NULL



---ITENSAIDA

CREATE TABLE ITENSAIDA (
IdItenSaida INT IDENTITY (1,1) PRIMARY KEY,
IdSaida INT NULL
)

ALTER TABLE ITENSAIDA
ADD FOREIGN KEY (IdProd) REFERENCES  PRODUTO (IdProd);


ALTER TABLE ITENSAIDA
ADD FOREIGN KEY (IdSaida) REFERENCES SAIDA (IdSaida);

---ADICIONANDO

INSERT INTO CATEGORIA (Descrição )
VALUES ('Alimentos');
INSERT INTO CATEGORIA (Descrição )
VALUES ('Bebidas');
INSERT INTO CATEGORIA (Descrição )
VALUES ('Moveis');
INSERT INTO CATEGORIA (Descrição )
VALUES ('Eletroncos');
INSERT INTO CATEGORIA (Descrição )
VALUES ('Eletrodomesticos');
INSERT INTO CATEGORIA (Descrição )
VALUES ('Limpeza');
SELECT * FROM CATEGORIA

INSERT INTO FORNECEDOR(NomeForn , EndereçoForn )
VALUES ('Americana', 'Avenida');
INSERT INTO FORNECEDOR (NomeForn , EndereçoForn )
VALUES ('Casas Bahia', 'Rua C');
INSERT INTO FORNECEDOR (NomeForn , EndereçoForn )
VALUES ('Dinosauro', 'Feira');
SELECT * FROM FORNECEDOR


INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Cuscuz' , 'Pacote' , '100' , 0 , 1);
INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Café' , 'k' , '25' , '0' , 2);
INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Coxinha' , 'k' , '100' , '0' , 1);

INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Coca Cola' , 'L' , '200' , '0' , 2);
INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Sofá' , 'M' , '20' , '1' , 3);
INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Cadeiras' , 'M' , '750' , '1' , 3);
INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Fones de fio' , 'M' , '50' , '1' , 4);
INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Computadores' , 'GB' , '400' , '1' , 4);
INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Maquina de Lavar' , 'L' , '13' , '1' , 5);
INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Ar condicionado' , 'M' , '50' , '1' , 5);
INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Agua Sanitaria' , 'L' , '186' , '0' , 6);
INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Amaciante' , 'L' , '46' , '0' , 6);
SELECT * FROM PRODUTO

INSERT INTO SECRETARIA (NomeSec)
VALUES ('ADM')
INSERT INTO SECRETARIA (NomeSec)
VALUES ('Saúde')
INSERT INTO SECRETARIA (NomeSec)
VALUES ('Educação')
INSERT INTO SECRETARIA (NomeSec)
VALUES ('Obras')
SELECT * FROM SECRETARIA
