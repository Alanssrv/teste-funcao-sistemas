﻿CREATE OR ALTER PROC FI_SP_AltCliente  
    @NOME          VARCHAR (50) ,  
    @SOBRENOME     VARCHAR (255),  
    @CPF           VARCHAR (11) ,
    @NACIONALIDADE VARCHAR (50) ,  
    @CEP           VARCHAR (9)  ,  
    @ESTADO        VARCHAR (2)  ,  
    @CIDADE        VARCHAR (50) ,  
    @LOGRADOURO    VARCHAR (500),  
    @EMAIL         VARCHAR (2079),  
    @TELEFONE      VARCHAR (15),  
    @Id           BIGINT  
AS  
BEGIN  
 UPDATE CLIENTES   
 SET   
  NOME = @NOME,   
  SOBRENOME = @SOBRENOME,   
  CPF = @CPF,
  NACIONALIDADE = @NACIONALIDADE,   
  CEP = @CEP,   
  ESTADO = @ESTADO,   
  CIDADE = @CIDADE,   
  LOGRADOURO = @LOGRADOURO,   
  EMAIL = @EMAIL,   
  TELEFONE = @TELEFONE  
 WHERE Id = @Id  
END
GO