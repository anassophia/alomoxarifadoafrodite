USE bdAlmoxarifado
---ADICIONANDO

INSERT INTO CATEGORIA (Descri��o )
VALUES ('Alimentos');
INSERT INTO CATEGORIA (Descri��o )
VALUES ('Bebidas');
INSERT INTO CATEGORIA (Descri��o )
VALUES ('Moveis');
INSERT INTO CATEGORIA (Descri��o )
VALUES ('Eletroncos');
INSERT INTO CATEGORIA (Descri��o )
VALUES ('Eletrodomesticos');
INSERT INTO CATEGORIA (Descri��o )
VALUES ('Limpeza');
SELECT * FROM CATEGORIA

INSERT INTO FORNECEDOR(NomeForn , Endere�oForn )
VALUES ('Americana', 'Avenida');
INSERT INTO FORNECEDOR (NomeForn , Endere�oForn )
VALUES ('Casas Bahia', 'Rua C');
INSERT INTO FORNECEDOR (NomeForn , Endere�oForn )
VALUES ('Dinosauro', 'Feira');
SELECT * FROM FORNECEDOR


INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Cuscuz' , 'Pacote' , '100' , 0 , 1);
INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Caf�' , 'k' , '25' , '0' , 2);
INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Coxinha' , 'k' , '100' , '0' , 1);

INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Coca Cola' , 'L' , '200' , '0' , 2);
INSERT INTO PRODUTO ( DescricaoProd , UnidadeDeMedida , EstoqueAtual , EPermanente , IdCategoria)
VALUES ('Sof�' , 'M' , '20' , '1' , 3);
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
VALUES ('Sa�de')
INSERT INTO SECRETARIA (NomeSec)
VALUES ('Educa��o')
INSERT INTO SECRETARIA (NomeSec)
VALUES ('Obras')
SELECT * FROM SECRETARIA
