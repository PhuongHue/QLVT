USE [QLVT_DATHANG]
GO
CREATE PROC SP_List_LOGIN
AS
BEGIN 
	SELECT NhanVien.MANV, NhanVien.HO, NhanVien.TEN, NhanVien.MACN FROM 
	(SELECT logins.name AS LOGINNAME, users.name AS USERNAME
		FROM sys.database_principals AS users 
		INNER JOIN sys.server_principals AS logins 
			ON logins.sid = users.sid WHERE users.name != 'dbo' and users.name != 'HTKN' 
	) 
	AS LG 
	full outer join
	NhanVien 
	ON LG.USERNAME = NhanVien.MANV WHERE LOGINNAME IS NULL;
END
