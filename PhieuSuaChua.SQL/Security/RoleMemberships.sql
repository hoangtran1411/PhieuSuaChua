ALTER ROLE [db_owner] ADD MEMBER [HOANG-HOME\Administrator];


GO
ALTER ROLE [db_accessadmin] ADD MEMBER [HOANG-HOME\Administrator];


GO
ALTER ROLE [db_accessadmin] ADD MEMBER [sasa];


GO
ALTER ROLE [db_ddladmin] ADD MEMBER [HOANG-HOME\Administrator];


GO
ALTER ROLE [db_backupoperator] ADD MEMBER [HOANG-HOME\Administrator];


GO
ALTER ROLE [db_backupoperator] ADD MEMBER [sasa];


GO
ALTER ROLE [db_datareader] ADD MEMBER [HOANG-HOME\Administrator];


GO
ALTER ROLE [db_datareader] ADD MEMBER [sasa];


GO
ALTER ROLE [db_datawriter] ADD MEMBER [HOANG-HOME\Administrator];


GO
ALTER ROLE [db_datawriter] ADD MEMBER [sasa];


GO
ALTER ROLE [db_denydatareader] ADD MEMBER [HOANG-HOME\Administrator];


GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [HOANG-HOME\Administrator];

