USE bdAlmoxarifado
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
