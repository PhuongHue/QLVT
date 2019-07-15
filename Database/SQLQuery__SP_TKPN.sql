CREATE PROC [dbo].[SP_TKPN] @start NVARCHAR(20),@end NVARCHAR(20),@ct int
AS
BEGIN
	IF 1=0 BEGIN
		SET FMTONLY OFF
	END

	SELECT * INTO #pn  FROM dbo.PhieuNhap WHERE NGAY BETWEEN CONVERT(DATETIME,@start,103) AND CONVERT(DATETIME,@end,103)
	SELECT MAVT,CAST(Month(#pn.NGAY) as varchar) + '-' + cast(YEAR(#pn.NGAY) as varchar) AS NGAY,SUM(SOLUONG) AS TONGSL,SUM(DONGIA) AS TONGGIA
	INTO #temp
	FROM #pn JOIN dbo.CTPN on CTPN.MAPN=#pn.MAPN  
	GROUP BY MAVT,CAST(Month(#pn.NGAY) as varchar) + '-' + cast(YEAR(#pn.NGAY) as varchar) 

	SELECT NGAY,TENVT,TONGSL,TONGGIA INTO #kq FROM #temp JOIN dbo.Vattu ON Vattu.MAVT = #temp.MAVT
	
	IF(@ct=0)
	BEGIN
		SELECT * FROM #kq
	END
	ELSE
	BEGIN
	
	SELECT * INTO #pn1  FROM LINK_QLVT.QLVT_DATHANG.dbo.PhieuNhap WHERE NGAY BETWEEN CONVERT(DATETIME,@start,103) AND CONVERT(DATETIME,@end,103)
	SELECT MAVT,CAST(Month(#pn1.NGAY) as varchar) + '-' + cast(YEAR(#pn1.NGAY) as varchar) AS NGAY,SUM(SOLUONG) AS TONGSL,SUM(DONGIA) AS TONGGIA
	INTO #temp1
	FROM #pn1 JOIN LINK_QLVT.QLVT_DATHANG.dbo.CTPN AS ct on ct.MAPN=#pn1.MAPN  
	GROUP BY MAVT,CAST(Month(#pn1.NGAY) as varchar) + '-' + cast(YEAR(#pn1.NGAY) as varchar) 

	SELECT NGAY,TENVT,TONGSL,TONGGIA INTO #kq1 FROM #temp1 JOIN dbo.Vattu ON Vattu.MAVT = #temp1.MAVT

	INSERT INTO #kq1 SELECT * FROM #kq
	SELECT NGAY,TENVT,SUM(TONGSL) AS TONGSL,SUM(TONGGIA) as TONGGIA FROM #kq1 GROUP BY TENVT,NGAY
	END
END