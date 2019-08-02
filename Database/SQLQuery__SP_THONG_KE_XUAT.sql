CREATE proc [dbo].[SP_THONG_KE_XUAT]
@NGAYBATDAU datetime = null,
@NGAYKETTHUC datetime = null
as
begin
	declare @Temp table (THANG int, NAM int, MAVT nchar(4), TENVT nvarchar(30), SOLUONG int, GIA float)
	
	insert into @Temp (THANG, NAM, MAVT, TENVT, SOLUONG, GIA)
	select month(px.NGAY), year(px.NGAY), ct.MAVT, vt.TENVT, ct.SOLUONG, ct.SOLUONG * ct.DONGIA
	from CTPX ct
	inner join PhieuXuat px on px.MAPX = ct.MAPX AND px.NGAY > @NGAYBATDAU AND px.NGAY < @NGAYKETTHUC
	inner join Vattu vt on vt.MAVT = ct.MAVT
	
	select THANG_NAM = cast(cast(THANG as nvarchar(2)) + '/01/' + cast(NAM as nchar(4)) as date),
		   TENVT, TONGSOLUONG = sum(SOLUONG), TONGTRIGIA = sum(GIA)
	from @Temp
	group by THANG, NAM, TENVT
end
GO

