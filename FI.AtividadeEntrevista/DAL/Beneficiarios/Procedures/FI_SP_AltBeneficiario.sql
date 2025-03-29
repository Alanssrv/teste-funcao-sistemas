﻿CREATE PROCEDURE FI_SP_AltBeneficiario
	@ID BIGINT,
	@NOME VARCHAR(50),
	@CPF VARCHAR(11)
AS
BEGIN
	UPDATE BENEFICIARIOS
	SET NOME = @NOME, CPF = @CPF
	WHERE ID = @ID
END
GO