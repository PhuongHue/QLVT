USE QLVT_DATHANG
GO
CREATE PROC [dbo].[SP_CHUYEN_CHI_NHANH] 
@MANV int
AS
BEGIN
	IF(EXISTS (SELECT MANV FROM LINK_QLVT.QLVT_DATHANG.dbo.NhanVien WHERE MANV = @MANV))
		UPDATE LINK_QLVT.QLVT_DATHANG.dbo.NhanVien SET TrangThaiXoa = 0 WHERE MANV = @MANV
	ELSE
	INSERT INTO LINK_QLVT.QLVT_DATHANG.dbo.NhanVien SELECT * FROM NhanVien WHERE MANV = @MANV
	UPDATE NhanVien SET TrangThaiXoa = 1 WHERE MANV = @MANV
END 