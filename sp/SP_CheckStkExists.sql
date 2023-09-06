USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[SP_CheckStkExists]    Script Date: 6/4/2023 7:27:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[SP_CheckStkExists]
@SOTK nchar(9)
AS
BEGIN
	
	IF EXISTS (SELECT 1 FROM DBO.TaiKhoan WHERE DBO.TaiKhoan.SOTK = @SOTK) 
	BEGIN
		RETURN 1;
	END
	RETURN 0;
END
