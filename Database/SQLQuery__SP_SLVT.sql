CREATE PROC [dbo].[SP_SLVT] @mavt NCHAR(4),@sl int
AS
BEGIN
	 SET XACT_ABORT ON 
  --SET TRAN ISOLATION LEVEL SNAPSHOT
	BEGIN DISTRIBUTED TRANSACTION;
	UPDATE dbo.Vattu SET SOLUONGTON = SOLUONGTON+@sl WHERE MAVT = @mavt
	UPDATE LINK_QLVT.QLVT_DATHANG.dbo.Vattu SET SOLUONGTON= SOLUONGTON+@sl WHERE MAVT = @mavt
	COMMIT TRAN
END