CREATE TRIGGER TG_INSERT_NhapHang
ON CTPN
FOR INSERT
AS
BEGIN
	DECLARE @HieuSo INT, @InsertedSOLUONG INT, @InsertedMAVT nvarchar(4), @SOLUONG_NHAP INT;
	SET @InsertedSOLUONG = (SELECT SOLUONG FROM inserted);
	SET @InsertedMAVT = (SELECT MAVT FROM inserted);
	SET @SOLUONG_NHAP = (SELECT SOLUONG FROM CTDDH WHERE MAVT = @InsertedMAVT);
	if(@InsertedSOLUONG > @SOLUONG_NHAP)
	begin
		RAISERROR(N'QUA SO LUONG at column SOLUONG.',16,1);
		ROLLBACK;

	end
END