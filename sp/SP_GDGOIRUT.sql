USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[SP_GDGOIRUT]    Script Date: 6/4/2023 7:27:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_GDGOIRUT] @SOTIEN MONEY,
@TYPE nchar(2),
@SOTK nchar(9)
AS
DECLARE @USERNAME NCHAR(50);
SET @USERNAME = ( SELECT CURRENT_USER );
SET XACT_ABORT ON;
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

BEGIN TRY
	BEGIN TRAN
	IF(@TYPE = 'RT')
		IF EXISTS(SELECT 1 FROM dbo.TaiKhoan WHERE dbo.TaiKhoan.SOTK =  @SOTK AND dbo.TaiKhoan.SODU > @SOTIEN)
			BEGIN
				UPDATE dbo.TaiKhoan SET SODU = SODU - @SOTIEN WHERE SOTK = @SOTK
				INSERT INTO dbo.GD_GOIRUT (SOTK, LOAIGD, SOTIEN, MANV) VALUES (@SOTK, @TYPE, @SOTIEN, @USERNAME);
			END
			

	IF(@TYPE = 'GT')
		IF EXISTS(SELECT 1 FROM dbo.TaiKhoan WHERE dbo.TaiKhoan.SOTK =  @SOTK)
			BEGIN
				UPDATE dbo.TaiKhoan SET SODU = SODU + @SOTIEN WHERE SOTK = @SOTK
				INSERT INTO dbo.GD_GOIRUT (SOTK, LOAIGD, SOTIEN, MANV) VALUES (@SOTK, @TYPE, @SOTIEN, @USERNAME);
			END
	COMMIT TRAN;
END TRY
BEGIN CATCH
	BEGIN
		ROLLBACK TRAN;
	END;
	THROW;
END CATCH

