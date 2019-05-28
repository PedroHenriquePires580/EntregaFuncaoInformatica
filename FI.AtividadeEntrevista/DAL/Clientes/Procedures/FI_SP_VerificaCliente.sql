﻿CREATE PROC FI_SP_VerificaCliente
	@CPF           VARCHAR (15)
AS
BEGIN
	IF(ISNULL(@CPF,null) = null)
		SELECT ID FROM CLIENTES WITH(NOLOCK) WHERE CPF = @CPF
	ELSE
		SELECT ID FROM CLIENTES WITH(NOLOCK) WHERE CPF = @CPF
END