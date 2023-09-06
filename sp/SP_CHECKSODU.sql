USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKSODU]    Script Date: 6/4/2023 7:27:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[SP_CHECKSODU]
@SOTIEN money, @SOTK nchar(9)
AS
BEGIN
	
	IF EXISTS (SELECT 1 FROM DBO.TaiKhoan WHERE DBO.TaiKhoan.SOTK = @SOTK) 
	BEGIN
		IF EXISTS (SELECT 1 FROM DBO.TaiKhoan WHERE DBO.TaiKhoan.SODU > @SOTIEN and DBO.TaiKhoan.SOTK = @SOTK) 
			BEGIN
			RETURN 0
			END
		RETURN 2
	END
	RETURN 1
END
