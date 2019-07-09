SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
USE QLVT_DATHANG
GO
CREATE PROCEDURE CreateRoleSystem
AS
BEGIN
	EXEC sp_addrole 'CONGTY'; 
	EXEC sp_addrole 'CHINHANH';
	EXEC sp_addrole 'USER';
	EXEC sp_addrolemember db_owner, 'CHINHANH';
	EXEC sp_addrolemember db_securityadmin, 'CONGTY';
	EXEC sp_addrolemember db_accessadmin, 'CONGTY';
	EXEC sp_addrolemember db_datareader, 'CONGTY';
	EXEC sp_addrolemember db_datareader, 'USER';
	EXEC sp_addrolemember db_datawriter, 'USER';
END