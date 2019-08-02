CREATE PROC [dbo].[SP_DDH_CHUA_NHAP]
AS
BEGIN
	select dh.MasoDDH, dh.NGAY, dh.NhaCC, nv.HO+' '+nv.TEN as HOTEN, vt.TENVT, ct.SOLUONG, ct.DONGIA
	from DatHang dh
	inner join NhanVien nv on nv.MANV = dh.MANV
	inner join CTDDH ct on ct.MasoDDH = dh.MasoDDH
	inner join Vattu vt on vt.MAVT = ct.MAVT
	where dh.MasoDDH not in (select MasoDDH from PhieuNhap)
END