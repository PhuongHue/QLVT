CREATE PROC [dbo].[SP_DDH_CHUA_NHAP]
AS
BEGIN
	SELECT temp.MasoDDH,temp.NGAY,temp.NhaCC,temp.HOTEN,TENVT,temp.SOLUONG,temp.DONGIA from
	(SELECT CTDDH.MasoDDH,dhnv.NGAY,dhnv.NhaCC,dhnv.HOTEN,MAVT,SOLUONG,DONGIA from
	(SELECT dh.MasoDDH,dh.NGAY,dh.NhaCC,HOTEN=HO+' '+TEN from
	(SELECT	* FROM dbo.DatHang WHERE MasoDDH NOT IN (SELECT MasoDDH FROM dbo.PhieuNhap)) AS dh
	JOIN dbo.NhanVien on dh.MANV =dbo.NhanVien.MANV) AS dhnv JOIN dbo.CTDDH ON CTDDH.MasoDDH = dhnv.MasoDDH) AS temp
	JOIN dbo.Vattu on temp.MAVT=dbo.Vattu.MAVT
END