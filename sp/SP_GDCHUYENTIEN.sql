USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[SP_GDCHUYENTIEN]    Script Date: 6/4/2023 7:27:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_GDCHUYENTIEN] 
@SOTK_CHUYEN nchar(9),
@SOTIEN MONEY,
@SOTK_NHAN nchar(9)
AS
DECLARE @USERNAME NCHAR(50);
SET @USERNAME = ( SELECT CURRENT_USER );
SET XACT_ABORT ON;
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

BEGIN TRY
	BEGIN TRAN
		IF EXISTS(SELECT 1 FROM dbo.TaiKhoan WHERE dbo.TaiKhoan.SOTK =  @SOTK_CHUYEN AND dbo.TaiKhoan.SODU > @SOTIEN
			AND (EXISTS(SELECT 1 FROM dbo.TaiKhoan WHERE dbo.TaiKhoan.SOTK = @SOTK_NHAN)))
			BEGIN
				UPDATE dbo.TaiKhoan SET SODU = SODU - @SOTIEN WHERE SOTK = @SOTK_CHUYEN
				UPDATE dbo.TaiKhoan SET SODU = SODU + @SOTIEN WHERE SOTK = @SOTK_NHAN
				INSERT INTO dbo.GD_CHUYENTIEN(SOTK_CHUYEN, SOTIEN, SOTK_NHAN, MANV) VALUES (@SOTK_CHUYEN, @SOTIEN, @SOTK_NHAN, @USERNAME);
				SELECT RESULT = 0
			END
		ELSE SELECT RESULT = 1
	COMMIT TRAN;
END TRY
BEGIN CATCH
	IF (@@TRANCOUNT > 0)
	BEGIN
		ROLLBACK TRAN;
	END;
	THROW;
END CATCH