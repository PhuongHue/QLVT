create proc [dbo].[SP_THONG_KE_NHAP]
@NGAYBATDAU datetime = null,
@NGAYKETTHUC datetime = null
as
begin

	declare @Temp table (MAVT nchar(4), TENVT nvarchar(30), THANG int, NAM int, SOLUONG int, DONGIA float, GIA float)

		insert into @Temp (MAVT, TENVT, THANG, NAM, SOLUONG, DONGIA, GIA)
		select ct.MAVT, Vattu.TENVT, MONTH(pn.NGAY), YEAR(pn.NGAY), ct.SOLUONG, ct.DONGIA, ct.SOLUONG * ct.DONGIA
		from CTPN ct
		inner join PhieuNhap pn on pn.MAPN = ct.MAPN AND pn.NGAY > @NGAYBATDAU AND pn.NGAY < @NGAYKETTHUC
		inner join Vattu on Vattu.MAVT = ct.MAVT

	select THANG_NAM=cast((cast(THANG as nvarchar(2))+'/01/'+cast(NAM as nchar(4))) as date),TENVT,TONGSL=sum(SOLUONG),TONGGIA=sum(GIA)
	from @Temp
	group by THANG, NAM, TENVT
	
end